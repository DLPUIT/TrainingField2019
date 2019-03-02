using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linklabel_listbox_Texbox
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
            linklist.Text = "csdn Win 百度 谷歌 YAHOO";
            linklist.Links.Add(0, 4, "http://www.csdn.net/");
            linklist.Links.Add(9, 2, "http://www.baidu.com/");
            linklist.Links.Add(12, 2, "http://www.google.cn/");
            linklist.Links.Add(15, 5, "http://www.yahoo.com.cn/");
        }

        private void baidu1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore.exe", "http://www.baidu.com");
        }

        private void linklist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linklist.Links[linklist.Links.IndexOf(e.Link)].Visited = true;
            string targetUrl = e.Link.LinkData as string;
            if (string.IsNullOrEmpty(targetUrl))
                MessageBox.Show("没有链接地址！");
            else
                this.webBrowser1.Url = new Uri(targetUrl);
                this.webBrowser1.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Listbox = new Listbox();
            Listbox.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Maskbox = new MaskedBox();
            Maskbox.ShowDialog();
        }
    }
}
