namespace Linklabel_listbox_Texbox
{
    partial class mainform
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.baidu1 = new System.Windows.Forms.LinkLabel();
            this.linklist = new System.Windows.Forms.LinkLabel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // baidu1
            // 
            this.baidu1.AutoSize = true;
            this.baidu1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.baidu1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.baidu1.Location = new System.Drawing.Point(49, 18);
            this.baidu1.Name = "baidu1";
            this.baidu1.Size = new System.Drawing.Size(29, 12);
            this.baidu1.TabIndex = 0;
            this.baidu1.TabStop = true;
            this.baidu1.Text = "百度";
            this.baidu1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.baidu1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.baidu1_LinkClicked);
            // 
            // linklist
            // 
            this.linklist.AutoSize = true;
            this.linklist.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linklist.LinkVisited = true;
            this.linklist.Location = new System.Drawing.Point(95, 18);
            this.linklist.Name = "linklist";
            this.linklist.Size = new System.Drawing.Size(101, 12);
            this.linklist.TabIndex = 1;
            this.linklist.TabStop = true;
            this.linklist.Text = "CSDN Github 百度";
            this.linklist.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklist_LinkClicked);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(18, 57);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(771, 360);
            this.webBrowser1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Listbox";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(360, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 22);
            this.button2.TabIndex = 4;
            this.button2.Text = "MaskedTextBox";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.linklist);
            this.Controls.Add(this.baidu1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "mainform";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel baidu1;
        private System.Windows.Forms.LinkLabel linklist;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

