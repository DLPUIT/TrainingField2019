namespace TabControl
{
    partial class TabControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.隶书 = new System.Windows.Forms.Button();
            this.楷体 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Green = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(128, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(375, 221);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.隶书);
            this.tabPage1.Controls.Add(this.楷体);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(367, 195);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "设置字体";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // 隶书
            // 
            this.隶书.Location = new System.Drawing.Point(203, 75);
            this.隶书.Name = "隶书";
            this.隶书.Size = new System.Drawing.Size(94, 38);
            this.隶书.TabIndex = 1;
            this.隶书.Text = "隶书";
            this.隶书.UseVisualStyleBackColor = true;
            this.隶书.Click += new System.EventHandler(this.button2_Click);
            // 
            // 楷体
            // 
            this.楷体.Location = new System.Drawing.Point(67, 75);
            this.楷体.Name = "楷体";
            this.楷体.Size = new System.Drawing.Size(95, 38);
            this.楷体.TabIndex = 0;
            this.楷体.Text = "楷体";
            this.楷体.UseVisualStyleBackColor = true;
            this.楷体.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Green);
            this.tabPage2.Controls.Add(this.Red);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(367, 195);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "设置颜色";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Green
            // 
            this.Green.Location = new System.Drawing.Point(214, 69);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(105, 41);
            this.Green.TabIndex = 1;
            this.Green.Text = "绿色";
            this.Green.UseVisualStyleBackColor = true;
            this.Green.Click += new System.EventHandler(this.button4_Click);
            // 
            // Red
            // 
            this.Red.Location = new System.Drawing.Point(46, 69);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(105, 41);
            this.Red.TabIndex = 0;
            this.Red.Text = "红色";
            this.Red.UseVisualStyleBackColor = true;
            this.Red.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.CausesValidation = false;
            this.textBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(521, 63);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(187, 195);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "添加选项卡";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "移除选项卡";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // TabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "TabControl";
            this.Text = "TabControl";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button 隶书;
        private System.Windows.Forms.Button 楷体;
        private System.Windows.Forms.Button Green;
        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

