using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpiltContainer_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void btUp_Click(object sender, EventArgs e)
        {
            if (this.btUp.Text == "↓")
            {
                this.btUp.Text = "↑";
                this.splitContainer2.Panel2.Hide();
                this.splitContainer2.Panel2Collapsed = true;
            }
            else
            {
                this.btUp.Text = "↓";
                this.splitContainer2.Panel2.Show();
                this.splitContainer2.Panel2Collapsed = false;
            }


        }


        private void btDown_Click(object sender, EventArgs e)
        {
            if (this.btDown.Text == "↑")
            {
                this.btDown.Text = "↓";
                this.splitContainer2.Panel1.Hide();
                this.splitContainer2.Panel1Collapsed = true;
            }
            else
            {
                this.btDown.Text = "↑";
                this.splitContainer2.Panel1.Show();
                this.splitContainer2.Panel1Collapsed = false;
            }
        }

        private void splitContainer2_SplitterMoved_1(object sender, SplitterEventArgs e)
        {
            labelmovemes.Text = "你移动鼠标使spiltcontainer布局发生变化";

        }
    }
}
