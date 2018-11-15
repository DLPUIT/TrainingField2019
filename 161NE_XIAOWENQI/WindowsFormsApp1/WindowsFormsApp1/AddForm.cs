using System;
using System.Windows.Forms;
using DlpuManager.Service;

namespace WindowsFormsApp1
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }
        private readonly DatabaseOperation service = new DatabaseOperation();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = new User();
            {
                user.Name = textBox1.Text;
                user.EnglishName = textBox6.Text;
                user.Gender = textBox5.Text;
                user.ClassId= textBox2.Text;
                user.Credits= int.Parse(textBox3.Text);
                user.GitHub = textBox4.Text;
            }
            this.service.Add(user);
            this.Close();
        }
    }
}
