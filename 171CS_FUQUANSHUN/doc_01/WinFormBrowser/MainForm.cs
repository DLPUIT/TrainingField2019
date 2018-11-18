using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormBrowser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            var url = this.webBrowser1.Url;
            this.webBrowser1.Url = url;
            this.webBrowser1.Refresh();
            // 获取当前页面的 url ，重载该 url            
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var url = this.textBox.Text;        // 获取输入内容 
                char[] str = url.ToCharArray();     // 将 url 转化为字符串数组,大小写                    
                char[] str1 = new char[7];
                for (int i = 0; i < 7; i++)
                {
                    str1[i] = str[i];

                    if (str1.Length == 7)
                    {
                        var str2 = new string(str1);
                        if (str2 == "http://")
                        {
                            this.webBrowser1.Url = new Uri(url);
                            this.webBrowser1.Refresh();         // 不写也可以
                        }
                        else
                        {
                            url = "http://" + url;
                            this.webBrowser1.Url = new Uri(url);
                            this.webBrowser1.Refresh();
                        }
                    }
                } 
            }
        }
    }
}
