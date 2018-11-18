using DBService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm成员管理
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }
        private readonly MainService service = new MainService();
        private void button1_Click(object sender, EventArgs e)
        {
            var name = textBox3.Text;
            var result = this.service.FindMember(name);
            result.ClassId = textBox1.Text;
            result.ClassName = textBox2.Text;
            result.Name = textBox3.Text;
            result.Gender = textBox4.Text;
            result.Credits = int.Parse(textBox5.Text);
            result.GitHub = textBox6.Text;
            result.ReportTo = textBox7.Text;
            result.EnglishName = textBox8.Text;
            this.service.UpdateMember(result);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
