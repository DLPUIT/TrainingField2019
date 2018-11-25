namespace WindowsFormsApp1
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.displaycheckedbutton = new System.Windows.Forms.Button();
            this.addbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.insertbutton = new System.Windows.Forms.Button();
            this.clearcheckedbutton = new System.Windows.Forms.Button();
            this.buttondisplay = new System.Windows.Forms.Button();
            this.buttonvalue = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "篮球",
            "swimming",
            "running"});
            this.checkedListBox1.Location = new System.Drawing.Point(3, 42);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(497, 184);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.checkedListBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.03057F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.96943F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(503, 366);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "您的兴趣爱好是？";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 2;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.displaycheckedbutton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.addbutton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.deletebutton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.insertbutton, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.clearcheckedbutton, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttondisplay, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonvalue, 6, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 325);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(497, 37);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // displaycheckedbutton
            // 
            this.displaycheckedbutton.Location = new System.Drawing.Point(3, 3);
            this.displaycheckedbutton.Name = "displaycheckedbutton";
            this.displaycheckedbutton.Size = new System.Drawing.Size(63, 23);
            this.displaycheckedbutton.TabIndex = 3;
            this.displaycheckedbutton.Text = "显示勾选项";
            this.displaycheckedbutton.UseVisualStyleBackColor = true;
            this.displaycheckedbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(72, 3);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(63, 23);
            this.addbutton.TabIndex = 4;
            this.addbutton.Text = "增加条目";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(141, 3);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(63, 23);
            this.deletebutton.TabIndex = 5;
            this.deletebutton.Text = "删除条目";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // insertbutton
            // 
            this.insertbutton.Location = new System.Drawing.Point(210, 3);
            this.insertbutton.Name = "insertbutton";
            this.insertbutton.Size = new System.Drawing.Size(63, 23);
            this.insertbutton.TabIndex = 6;
            this.insertbutton.Text = "插入条目";
            this.insertbutton.UseVisualStyleBackColor = true;
            this.insertbutton.Click += new System.EventHandler(this.insertbutton_Click);
            // 
            // clearcheckedbutton
            // 
            this.clearcheckedbutton.Location = new System.Drawing.Point(279, 3);
            this.clearcheckedbutton.Name = "clearcheckedbutton";
            this.clearcheckedbutton.Size = new System.Drawing.Size(63, 23);
            this.clearcheckedbutton.TabIndex = 7;
            this.clearcheckedbutton.Text = "清除选择";
            this.clearcheckedbutton.UseVisualStyleBackColor = true;
            this.clearcheckedbutton.Click += new System.EventHandler(this.clearcheckedbutton_Click);
            // 
            // buttondisplay
            // 
            this.buttondisplay.Location = new System.Drawing.Point(348, 3);
            this.buttondisplay.Name = "buttondisplay";
            this.buttondisplay.Size = new System.Drawing.Size(68, 23);
            this.buttondisplay.TabIndex = 8;
            this.buttondisplay.Text = "显示文本";
            this.buttondisplay.UseVisualStyleBackColor = true;
            this.buttondisplay.Click += new System.EventHandler(this.buttondisplay_Click);
            // 
            // buttonvalue
            // 
            this.buttonvalue.Location = new System.Drawing.Point(422, 3);
            this.buttonvalue.Name = "buttonvalue";
            this.buttonvalue.Size = new System.Drawing.Size(72, 23);
            this.buttonvalue.TabIndex = 9;
            this.buttonvalue.Text = "显示实际";
            this.buttonvalue.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 366);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button displaycheckedbutton;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button insertbutton;
        private System.Windows.Forms.Button clearcheckedbutton;
        private System.Windows.Forms.Button buttondisplay;
        private System.Windows.Forms.Button buttonvalue;
    }
}

