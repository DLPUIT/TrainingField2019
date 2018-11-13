using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBrowser
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
            this.webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void LoadPage()
        {
            var url = this.textBox1.Text;
            if (url.Contains("http://") || url.Contains("https://"))
            {
            }
            else
            {
                url = "http://" + url;                
            }
            this.webBrowser1.Url = new Uri(url);
            this.webBrowser1.Refresh();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.LoadPage();
        }
        
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.LoadPage();
            }
        }
    }
}
