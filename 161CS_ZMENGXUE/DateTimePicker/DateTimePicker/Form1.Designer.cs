namespace DateTimePicker
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelbirthday = new System.Windows.Forms.Label();
            this.selectedyear = new System.Windows.Forms.Label();
            this.labelmonth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxshowyear = new System.Windows.Forms.TextBox();
            this.textBoxshowmonth = new System.Windows.Forms.TextBox();
            this.textBoxshowday = new System.Windows.Forms.TextBox();
            this.textBoxnowdate = new System.Windows.Forms.TextBox();
            this.labelnowdate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(136, 53);
            this.dateTimePicker1.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // labelbirthday
            // 
            this.labelbirthday.AutoSize = true;
            this.labelbirthday.Location = new System.Drawing.Point(55, 53);
            this.labelbirthday.Name = "labelbirthday";
            this.labelbirthday.Size = new System.Drawing.Size(53, 12);
            this.labelbirthday.TabIndex = 1;
            this.labelbirthday.Text = "您的生日";
            // 
            // selectedyear
            // 
            this.selectedyear.AutoSize = true;
            this.selectedyear.Location = new System.Drawing.Point(55, 92);
            this.selectedyear.Name = "selectedyear";
            this.selectedyear.Size = new System.Drawing.Size(53, 12);
            this.selectedyear.TabIndex = 2;
            this.selectedyear.Text = "所选年：";
            // 
            // labelmonth
            // 
            this.labelmonth.AutoSize = true;
            this.labelmonth.Location = new System.Drawing.Point(55, 127);
            this.labelmonth.Name = "labelmonth";
            this.labelmonth.Size = new System.Drawing.Size(53, 12);
            this.labelmonth.TabIndex = 3;
            this.labelmonth.Text = "所选月：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "所选日：";
            // 
            // textBoxshowyear
            // 
            this.textBoxshowyear.Location = new System.Drawing.Point(136, 89);
            this.textBoxshowyear.Name = "textBoxshowyear";
            this.textBoxshowyear.Size = new System.Drawing.Size(200, 21);
            this.textBoxshowyear.TabIndex = 5;
            // 
            // textBoxshowmonth
            // 
            this.textBoxshowmonth.Location = new System.Drawing.Point(136, 127);
            this.textBoxshowmonth.Name = "textBoxshowmonth";
            this.textBoxshowmonth.Size = new System.Drawing.Size(200, 21);
            this.textBoxshowmonth.TabIndex = 6;
            // 
            // textBoxshowday
            // 
            this.textBoxshowday.Location = new System.Drawing.Point(136, 164);
            this.textBoxshowday.Name = "textBoxshowday";
            this.textBoxshowday.Size = new System.Drawing.Size(200, 21);
            this.textBoxshowday.TabIndex = 7;
            // 
            // textBoxnowdate
            // 
            this.textBoxnowdate.Location = new System.Drawing.Point(136, 20);
            this.textBoxnowdate.Name = "textBoxnowdate";
            this.textBoxnowdate.Size = new System.Drawing.Size(200, 21);
            this.textBoxnowdate.TabIndex = 8;
            // 
            // labelnowdate
            // 
            this.labelnowdate.AutoSize = true;
            this.labelnowdate.Location = new System.Drawing.Point(55, 20);
            this.labelnowdate.Name = "labelnowdate";
            this.labelnowdate.Size = new System.Drawing.Size(53, 12);
            this.labelnowdate.TabIndex = 9;
            this.labelnowdate.Text = "当前日期";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelnowdate);
            this.Controls.Add(this.textBoxnowdate);
            this.Controls.Add(this.textBoxshowday);
            this.Controls.Add(this.textBoxshowmonth);
            this.Controls.Add(this.textBoxshowyear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelmonth);
            this.Controls.Add(this.selectedyear);
            this.Controls.Add(this.labelbirthday);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelbirthday;
        private System.Windows.Forms.Label selectedyear;
        private System.Windows.Forms.Label labelmonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxshowyear;
        private System.Windows.Forms.TextBox textBoxshowmonth;
        private System.Windows.Forms.TextBox textBoxshowday;
        private System.Windows.Forms.TextBox textBoxnowdate;
        private System.Windows.Forms.Label labelnowdate;
    }
}

