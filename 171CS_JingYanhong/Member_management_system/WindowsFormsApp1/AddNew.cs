using Member_management_system;
using Member_management_system.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
   
    public partial class AddNew : Form
    {
        private readonly Member_management_system_Service service = new Member_management_system_Service();
        public AddNew()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
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
                Name = this.textBox1.Text,
                ClassId = this.textBox2.Text,
                GitHub = this.textBox3.Text,
                Credits = int.Parse(this.textBox3.Text),
                ClassName = this.textBox5.Text,
                Reportto = this.textBox6.Text,
            };
            this.service.AddMember(user);
            this.Close();
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddNew_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
