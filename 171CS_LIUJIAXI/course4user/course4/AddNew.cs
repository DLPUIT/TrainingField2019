using DlpuManager.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course4
{
    public partial class AddNew : Form
    {

        private readonly DlpuManagerService service = new DlpuManagerService();

        public AddNew()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                ClassId = this.textBox1.Text,
                ClassName = this.textBox2.Text,
                Name = this.textBox3.Text,
                Credits = int.Parse(this.textBox4.Text),
                Gender = this.textBox5.Text,
                GitHub = this.textBox6.Text
            };
            this.service.AddMember(user);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
