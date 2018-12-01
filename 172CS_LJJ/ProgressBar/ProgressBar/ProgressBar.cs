using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class ProgressBar : Form
    {
        public ProgressBar()
        {
            InitializeComponent();
            displayLog("程序已启动");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(length.Text))
                return;
            int result;
            if (int.TryParse(length.Text, out result))
            {
                progressBar1.Maximum = result;
                timer1.Enabled = true;
                displayLog("进度条开始运行");
            }       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                button2.Text = "继续";
                timer1.Enabled = false;
                displayLog("进度条暂停运行");
            }
            else
            {
                button2.Text = "暂停";
                timer1.Enabled = true;
                displayLog("进度条继续运行");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            timer1.Enabled = false;
            displayLog("进度条停止运行");
        }

        public void displayLog(string log)
        {
            info.AppendText(DateTime.Now.ToString("HH:MM:ss  ") + log + "\r\n");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value+=100;
                displayLog("进度进行中" + "[" + progressBar1.Value + "/" + progressBar1.Maximum + "]...");
            }
            else
            {
                displayLog("进度已完成");
                timer1.Enabled = false;
            }
        }
    }
}
