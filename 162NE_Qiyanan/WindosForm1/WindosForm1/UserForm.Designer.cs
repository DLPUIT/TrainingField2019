namespace WindosForm1
{
    partial class UserForm
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
            this.ClassId = new System.Windows.Forms.TextBox();
            this.ClassName = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.Credit = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.TextBox();
            this.Team = new System.Windows.Forms.TextBox();
            this.GitHub = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClassId
            // 
            this.ClassId.Location = new System.Drawing.Point(216, 35);
            this.ClassId.Margin = new System.Windows.Forms.Padding(4);
            this.ClassId.Name = "ClassId";
            this.ClassId.Size = new System.Drawing.Size(244, 25);
            this.ClassId.TabIndex = 7;
            this.ClassId.TextChanged += new System.EventHandler(this.ClassId_TextChanged);
            // 
            // ClassName
            // 
            this.ClassName.Location = new System.Drawing.Point(216, 94);
            this.ClassName.Margin = new System.Windows.Forms.Padding(4);
            this.ClassName.Name = "ClassName";
            this.ClassName.Size = new System.Drawing.Size(240, 25);
            this.ClassName.TabIndex = 8;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(216, 152);
            this.Name.Margin = new System.Windows.Forms.Padding(4);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(235, 25);
            this.Name.TabIndex = 9;
            // 
            // Credit
            // 
            this.Credit.Location = new System.Drawing.Point(216, 214);
            this.Credit.Margin = new System.Windows.Forms.Padding(4);
            this.Credit.Name = "Credit";
            this.Credit.Size = new System.Drawing.Size(236, 25);
            this.Credit.TabIndex = 10;
            // 
            // Gender
            // 
            this.Gender.Location = new System.Drawing.Point(216, 282);
            this.Gender.Margin = new System.Windows.Forms.Padding(4);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(236, 25);
            this.Gender.TabIndex = 11;
            // 
            // Team
            // 
            this.Team.Location = new System.Drawing.Point(219, 350);
            this.Team.Margin = new System.Windows.Forms.Padding(4);
            this.Team.Name = "Team";
            this.Team.Size = new System.Drawing.Size(231, 25);
            this.Team.TabIndex = 12;
            // 
            // GitHub
            // 
            this.GitHub.Location = new System.Drawing.Point(220, 408);
            this.GitHub.Margin = new System.Windows.Forms.Padding(4);
            this.GitHub.Name = "GitHub";
            this.GitHub.Size = new System.Drawing.Size(232, 25);
            this.GitHub.TabIndex = 13;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(227, 485);
            this.Submit.Margin = new System.Windows.Forms.Padding(4);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(71, 34);
            this.Submit.TabIndex = 14;
            this.Submit.Text = "提交";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(452, 489);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(113, 29);
            this.Cancel.TabIndex = 15;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "班级号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "班级名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "姓名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "积分";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 294);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "性别";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 361);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "团队";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 419);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "github";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 562);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.GitHub);
            this.Controls.Add(this.Team);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Credit);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.ClassName);
            this.Controls.Add(this.ClassId);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.TextBox ClassId;
        private System.Windows.Forms.TextBox ClassName;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Credit;
        private System.Windows.Forms.TextBox Gender;
        private System.Windows.Forms.TextBox Team;
        private System.Windows.Forms.TextBox GitHub;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}