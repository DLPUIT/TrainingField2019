using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
        }
        private void loadpage()
        {
            var url = textBox1.Text;

            if (url.StartsWith("Http://")) { 
            this.webBrowser1.Url = new Uri(url);
            this.webBrowser1.Refresh();
            }
            else
            {
                url= "http://" + textBox1.Text;
                this.webBrowser1.Url = new Uri(url);
                this.webBrowser1.Refresh();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadpage();
        }
        



        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                loadpage();

            }
        }
    }
}
