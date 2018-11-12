using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browsers
{
    public partial class MyBrowsers : Form
    {
        public MyBrowsers()
        {
            InitializeComponent();
            this.webBrowser1.ScriptErrorsSuppressed = true;//一旦构造出方法，便执行;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void Load()
        {
            string  url = this.textBox.Text;
            if ((url.IndexOf("http://") >= 0) || (url.IndexOf("https://")) >= 0)
            {
                this.webBrowser1.Url = new Uri(url);//url为string类型 需要转化为URL类型
                this.webBrowser1.Refresh();
            }
            else
            {
                string u = "http://" + url;
                this.webBrowser1.Url = new Uri(u);//url为string类型 需要转化为URL类型
                this.webBrowser1.Refresh();
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            this.Load();
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)// KeyEventArgs事件参数，包含当前事件所有相关的事。sender,表示当前事件是谁触发的
            //此时sender指textBox
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.Load();
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
