using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBrower
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.webBrowser.ScriptErrorsSuppressed = true;
        }

        private void textBoxRefresh_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadPage()
        {
            var url = this.textBoxRefresh.Text;
            if (url.StartsWith("http://") || url.StartsWith("https://"))
            {
                this.webBrowser1.Navigate(textBoxRefresh.Text);
                this.webBrowser1.Url = new Uri(url);
            }
            //this.webBrowser1.Url = new Uri(url);

            this.webBrowser1.Refresh();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.LoadPage();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxRefresh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.LoadPage();
            }
        }
    }
}
