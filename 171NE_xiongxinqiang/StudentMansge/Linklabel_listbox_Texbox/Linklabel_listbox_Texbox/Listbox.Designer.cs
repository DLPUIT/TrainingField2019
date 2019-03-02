namespace Linklabel_listbox_Texbox
{
    partial class Listbox
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
            this.listBoxBuy = new System.Windows.Forms.ListBox();
            this.listBoxSale = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxBuy
            // 
            this.listBoxBuy.FormattingEnabled = true;
            this.listBoxBuy.ItemHeight = 12;
            this.listBoxBuy.Location = new System.Drawing.Point(96, 164);
            this.listBoxBuy.Name = "listBoxBuy";
            this.listBoxBuy.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxBuy.Size = new System.Drawing.Size(202, 244);
            this.listBoxBuy.TabIndex = 0;
            // 
            // listBoxSale
            // 
            this.listBoxSale.FormattingEnabled = true;
            this.listBoxSale.ItemHeight = 12;
            this.listBoxSale.Location = new System.Drawing.Point(507, 164);
            this.listBoxSale.Name = "listBoxSale";
            this.listBoxSale.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxSale.Size = new System.Drawing.Size(199, 244);
            this.listBoxSale.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(413, 39);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 24);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "添加成员";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Location = new System.Drawing.Point(165, 42);
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(242, 21);
            this.textBoxAdd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "采购部门";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "销售部门";
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(341, 173);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(116, 32);
            this.buttonRight.TabIndex = 6;
            this.buttonRight.Text = "转移人员>>>";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(341, 233);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(116, 32);
            this.buttonLeft.TabIndex = 7;
            this.buttonLeft.Text = "<<<转移人员";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "删除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(339, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 33);
            this.button2.TabIndex = 9;
            this.button2.Text = "上移";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Listbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAdd);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxSale);
            this.Controls.Add(this.listBoxBuy);
            this.Name = "Listbox";
            this.Text = "Listbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBuy;
        private System.Windows.Forms.ListBox listBoxSale;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}