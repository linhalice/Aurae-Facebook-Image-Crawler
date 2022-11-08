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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Token:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cookie:";
            // 
            // textBoxToken
            // 
            this.textBoxToken.Location = new System.Drawing.Point(59, 11);
            this.textBoxToken.Name = "textBoxToken";
            this.textBoxToken.Size = new System.Drawing.Size(489, 20);
            this.textBoxToken.TabIndex = 2;
            this.textBoxToken.TextChanged += new System.EventHandler(this.textBoxToken_TextChanged);
            // 
            // textBoxCookie
            // 
            this.textBoxCookie.Location = new System.Drawing.Point(59, 47);
            this.textBoxCookie.Name = "textBoxCookie";
            this.textBoxCookie.Size = new System.Drawing.Size(489, 20);
            this.textBoxCookie.TabIndex = 3;
            this.textBoxCookie.TextChanged += new System.EventHandler(this.textBoxCookie_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 117);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(533, 20);
            this.progressBar1.TabIndex = 5;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(131, 83);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(139, 20);
            this.textBoxId.TabIndex = 7;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Id Group/page/profile:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Count Post:";
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(358, 83);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(61, 20);
            this.textBoxMax.TabIndex = 9;
            this.textBoxMax.Text = "1000";
            this.textBoxMax.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxDelay
            // 
            this.textBoxDelay.Location = new System.Drawing.Point(487, 83);
            this.textBoxDelay.Name = "textBoxDelay";
            this.textBoxDelay.Size = new System.Drawing.Size(61, 20);
            this.textBoxDelay.TabIndex = 11;
            this.textBoxDelay.Text = "500";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Delay(ms):";
            // 
            // labelProcess
            // 
            this.labelProcess.AutoSize = true;
            this.labelProcess.BackColor = System.Drawing.Color.Transparent;
            this.labelProcess.Location = new System.Drawing.Point(258, 120);
            this.labelProcess.Name = "labelProcess";
            this.labelProcess.Size = new System.Drawing.Size(24, 13);
            this.labelProcess.TabIndex = 12;
            this.labelProcess.Text = "0/0";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 176);
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
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aurae Facebook Image Crawler";
            this.Load += new System.EventHandler(this.FormMain_Load);
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
    }
}

