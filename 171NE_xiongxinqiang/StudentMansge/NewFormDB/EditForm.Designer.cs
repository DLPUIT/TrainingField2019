namespace NewFormDB
{
    partial class EditForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxGithub = new System.Windows.Forms.TextBox();
            this.textBoxCredit = new System.Windows.Forms.TextBox();
            this.textBoxClassID = new System.Windows.Forms.TextBox();
            this.buttonSure = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "班级ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "积分";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "GitHub";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(128, 47);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(236, 21);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxGithub
            // 
            this.textBoxGithub.Location = new System.Drawing.Point(128, 163);
            this.textBoxGithub.Name = "textBoxGithub";
            this.textBoxGithub.Size = new System.Drawing.Size(236, 21);
            this.textBoxGithub.TabIndex = 5;
            // 
            // textBoxCredit
            // 
            this.textBoxCredit.Location = new System.Drawing.Point(128, 124);
            this.textBoxCredit.Name = "textBoxCredit";
            this.textBoxCredit.Size = new System.Drawing.Size(236, 21);
            this.textBoxCredit.TabIndex = 6;
            // 
            // textBoxClassID
            // 
            this.textBoxClassID.Location = new System.Drawing.Point(128, 84);
            this.textBoxClassID.Name = "textBoxClassID";
            this.textBoxClassID.Size = new System.Drawing.Size(236, 21);
            this.textBoxClassID.TabIndex = 7;
            // 
            // buttonSure
            // 
            this.buttonSure.Location = new System.Drawing.Point(145, 207);
            this.buttonSure.Name = "buttonSure";
            this.buttonSure.Size = new System.Drawing.Size(71, 28);
            this.buttonSure.TabIndex = 8;
            this.buttonSure.Text = "确定";
            this.buttonSure.UseVisualStyleBackColor = true;
            this.buttonSure.Click += new System.EventHandler(this.buttonSure_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(236, 207);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(76, 28);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "取消";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 266);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSure);
            this.Controls.Add(this.textBoxClassID);
            this.Controls.Add(this.textBoxCredit);
            this.Controls.Add(this.textBoxGithub);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxGithub;
        private System.Windows.Forms.TextBox textBoxCredit;
        private System.Windows.Forms.TextBox textBoxClassID;
        private System.Windows.Forms.Button buttonSure;
        private System.Windows.Forms.Button buttonClose;
    }
}