namespace Aurae_Facebook_Image_Crawler
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxToken = new System.Windows.Forms.TextBox();
            this.textBoxCookie = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.textBoxDelay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelProcess = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Token:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cookie:";
            // 
            // textBoxToken
            // 
            this.textBoxToken.Location = new System.Drawing.Point(88, 17);
            this.textBoxToken.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxToken.Name = "textBoxToken";
            this.textBoxToken.Size = new System.Drawing.Size(732, 26);
            this.textBoxToken.TabIndex = 2;
            this.textBoxToken.TextChanged += new System.EventHandler(this.textBoxToken_TextChanged);
            // 
            // textBoxCookie
            // 
            this.textBoxCookie.Location = new System.Drawing.Point(88, 72);
            this.textBoxCookie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCookie.Name = "textBoxCookie";
            this.textBoxCookie.Size = new System.Drawing.Size(732, 26);
            this.textBoxCookie.TabIndex = 3;
            this.textBoxCookie.TextChanged += new System.EventHandler(this.textBoxCookie_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(658, 225);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(22, 180);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(800, 31);
            this.progressBar1.TabIndex = 5;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(196, 128);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(206, 26);
            this.textBoxId.TabIndex = 7;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Id Group/page/profile:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Count Post:";
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(537, 128);
            this.textBoxMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(90, 26);
            this.textBoxMax.TabIndex = 9;
            this.textBoxMax.Text = "1000";
            this.textBoxMax.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxDelay
            // 
            this.textBoxDelay.Location = new System.Drawing.Point(730, 128);
            this.textBoxDelay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDelay.Name = "textBoxDelay";
            this.textBoxDelay.Size = new System.Drawing.Size(90, 26);
            this.textBoxDelay.TabIndex = 11;
            this.textBoxDelay.Text = "500";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(648, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Delay(ms):";
            // 
            // labelProcess
            // 
            this.labelProcess.AutoSize = true;
            this.labelProcess.BackColor = System.Drawing.Color.Transparent;
            this.labelProcess.Location = new System.Drawing.Point(413, 185);
            this.labelProcess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProcess.Name = "labelProcess";
            this.labelProcess.Size = new System.Drawing.Size(31, 20);
            this.labelProcess.TabIndex = 12;
            this.labelProcess.Text = "0/0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(150, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(150, 599);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 34);
            this.button2.TabIndex = 14;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(570, 599);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 34);
            this.button3.TabIndex = 15;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(271, 599);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 34);
            this.button4.TabIndex = 16;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(420, 599);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 34);
            this.button5.TabIndex = 17;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(351, 66);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(112, 34);
            this.button6.TabIndex = 18;
            this.button6.Text = "Reload";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.BackColor = System.Drawing.Color.Transparent;
            this.labelFilePath.Location = new System.Drawing.Point(153, 567);
            this.labelFilePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(46, 20);
            this.labelFilePath.TabIndex = 19;
            this.labelFilePath.Text = "Path:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelFilePath);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(22, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 661);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Duyệt ảnh";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(846, 940);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelProcess);
            this.Controls.Add(this.textBoxDelay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxCookie);
            this.Controls.Add(this.textBoxToken);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aurae Facebook Image Crawler";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.FormMain_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxToken;
        private System.Windows.Forms.TextBox textBoxCookie;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.TextBox textBoxDelay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelProcess;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

