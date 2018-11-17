using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppBrowse
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.webBrowser1.ScriptErrorsSuppressed = true; // 消除script error
        }

        private void LoadPage() 
        {
            var url = this.textBox.Text;
            this.webBrowser1.Url = new Uri(url);
            this.webBrowser1.Refresh();           
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.LoadPage();
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.LoadPage();
            }
    }
}
