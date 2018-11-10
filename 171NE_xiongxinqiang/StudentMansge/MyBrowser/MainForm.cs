using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MyBrowser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void Loadpage()
        {
            var url = textBoxSearch.Text;
            if (Regex.IsMatch(url,"http") || Regex.IsMatch(url, "https"))
            {
                this.webBrowser1.Url = new Uri(url);
                this.webBrowser1.Refresh();
            }
            else
            {
                url = "https://" + url;
                this.webBrowser1.Url = new Uri(url);
                this.webBrowser1.Refresh();
            }

            
        }

        private void buttonRefalsh_Click(object sender, EventArgs e)
        {
            this.Loadpage();
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.Loadpage();
            }
        }
    }
}
