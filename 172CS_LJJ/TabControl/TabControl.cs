using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControl
{
    public partial class TabControl : Form
    {
        public TabControl()
        {
            InitializeComponent();
            textBox1.Text = "大家好.我叫刘俊杰.哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈";
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            textBox1.Font = new Font("楷体",textBox1.Font.Size, textBox1.Font.Style);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font("隶书",textBox1.Font.Size, textBox1.Font.Style);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //textBox1.ForeColor = Color.Red;
            textBox1.ForeColor = Color.FromArgb(255, 255, 0, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Green;
        }
        int i = 0;
        private void button1_Click_1(object sender, EventArgs e)
        {
            TabPage Page = new TabPage();         
            i += 1;
            Page.Text = Convert.ToString(i);           
            tabControl1.Controls.Add(Page);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.tabControl1.Controls.RemoveAt(this.tabControl1.SelectedIndex);
        }
    }
}
