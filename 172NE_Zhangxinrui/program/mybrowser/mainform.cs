using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mybrowser
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
            this.webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void Loadpage()
        {
            var url = this.textBox1.Text;
            var s = textBox1.Text;
            if(s.Substring(0, 7) == "http://" )
            {
                this.webBrowser1.Url = new Uri(url);
                this.webBrowser1.Refresh();
            }
            else
            {
                textBox1.Text = "http://" + textBox1.Text;
            }

            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Loadpage();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Loadpage();
            }
            //else return;
        }
    }
}
