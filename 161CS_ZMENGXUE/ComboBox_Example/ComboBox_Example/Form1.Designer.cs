namespace ComboBox_Example
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelshowselected = new System.Windows.Forms.Label();
            this.buttonselectedshow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "中国",
            "香港",
            "台湾",
            "美国",
            "日本"});
            this.comboBox1.Location = new System.Drawing.Point(111, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelshowselected
            // 
            this.labelshowselected.AutoSize = true;
            this.labelshowselected.Location = new System.Drawing.Point(256, 69);
            this.labelshowselected.Name = "labelshowselected";
            this.labelshowselected.Size = new System.Drawing.Size(0, 12);
            this.labelshowselected.TabIndex = 1;
            this.labelshowselected.Click += new System.EventHandler(this.labelshowselected_Click);
            // 
            // buttonselectedshow
            // 
            this.buttonselectedshow.Location = new System.Drawing.Point(226, 147);
            this.buttonselectedshow.Name = "buttonselectedshow";
            this.buttonselectedshow.Size = new System.Drawing.Size(75, 23);
            this.buttonselectedshow.TabIndex = 2;
            this.buttonselectedshow.Text = "显示选中项";
            this.buttonselectedshow.UseVisualStyleBackColor = true;
            this.buttonselectedshow.Click += new System.EventHandler(this.buttonselectedshow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonselectedshow);
            this.Controls.Add(this.labelshowselected);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelshowselected;
        private System.Windows.Forms.Button buttonselectedshow;
    }
}

