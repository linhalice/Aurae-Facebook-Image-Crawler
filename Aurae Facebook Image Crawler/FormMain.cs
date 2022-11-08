using Leaf.xNet;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Aurae_Facebook_Image_Crawler.FeedPostModel;

namespace Aurae_Facebook_Image_Crawler
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string token = textBoxToken.Text;
            string id = textBoxId.Text;
            string cookie = textBoxCookie.Text;
            string max = textBoxMax.Text;
            string delay = textBoxDelay.Text;
            Thread thread = new Thread(() =>
            {
                ImageDownload(token, cookie, id, max, delay);
            });
            thread.IsBackground = true;
            thread.Start();
        }

        private void ImageDownload(string token, string cookie, string id, string max, string delay)
        {
            int intMax = 100;
            int intDelay = 500;
            try
            {
                intMax = Int32.Parse(max);
                intDelay = Int32.Parse(delay);
            }
            catch { }

            this.Invoke(new Action(() =>
            {
                progressBar1.Minimum = 0;
                progressBar1.Maximum = intMax;
            }));
            int iProg = 0;

            string subPath = "Image"; // Your code goes here

            bool exists = System.IO.Directory.Exists((subPath));

            if (!exists)
                System.IO.Directory.CreateDirectory((subPath));

            Process.Start("explorer.exe", System.IO.Directory.GetCurrentDirectory()+ @"\Image");

            string postUrl = $"https://graph.facebook.com/v14.0/{id}?fields=feed.limit({max})%7Bfull_picture%7D&access_token={token}";

            HttpRequest httpRequest = new HttpRequest();
            httpRequest.KeepAlive = true;
            httpRequest.Cookies = new CookieStorage();
            httpRequest.AddHeader(HttpHeader.Accept, "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3");
            httpRequest.AddHeader(HttpHeader.AcceptLanguage, "en-US,en;q=0.5");
            httpRequest.AddHeader("origin", "https://www.facebook.com");
            httpRequest.AddHeader("sec-fetch-dest", "empty");
            httpRequest.AddHeader("sec-fetch-mode", "cors");
            httpRequest.AddHeader("sec-fetch-site", "same-origin");
            httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/75.0.3770.100 Safari/537.36";

            cookie = cookie.Replace(" ", "");
            var temp = cookie.Split(';');
            foreach (var item in temp)
            {
                var temp2 = item.Split('=');
                if (temp2.Count() > 1)
                {
                    Cookie cookieTemp = new Cookie(temp2[0], temp2[1]) { Domain = ".facebook.com" };
                    httpRequest.Cookies.Add(cookieTemp);
                }
            }

            try
            {
                string jsonData = httpRequest.Get(postUrl).ToString();
                Root root = JsonConvert.DeserializeObject<Root>(jsonData);
                foreach (var item in root.feed.data)
                {
                    iProg++;
                    this.Invoke(new Action(() =>
                    {
                        labelProcess.Text = $"{iProg}/{intMax}";
                        progressBar1.Value = iProg;
                    }));
                    if (item.full_picture != null)
                    {
                        try
                        {
                            string pictureUrl = item.full_picture;
                            string pictureName = item.id.ToString();
                            httpRequest.Get(pictureUrl).ToFile($@"Image\{pictureName}.jpg");
                            Thread.Sleep(intDelay);
                        }
                        catch
                        { }
                    }
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void textBoxToken_TextChanged(object sender, EventArgs e)
        {
            ToolSettings.Default.Token = textBoxToken.Text;
            ToolSettings.Default.Save();
        }

        private void textBoxCookie_TextChanged(object sender, EventArgs e)
        {
            ToolSettings.Default.Cookie = textBoxCookie.Text;
            ToolSettings.Default.Save();
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            ToolSettings.Default.Id = textBoxId.Text;
            ToolSettings.Default.Save();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ToolSettings.Default.Max = textBoxMax.Text;
            ToolSettings.Default.Save();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            textBoxToken.Text = ToolSettings.Default.Token;
            textBoxCookie.Text = ToolSettings.Default.Cookie;
            textBoxId.Text = ToolSettings.Default.Id;
            textBoxMax.Text = ToolSettings.Default.Max;
        }


    }
}
