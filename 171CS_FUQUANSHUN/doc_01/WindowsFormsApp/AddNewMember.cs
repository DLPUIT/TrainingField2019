using DLPU_Manager;
using DLPU_Manager.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class AddNewMember : Form
    {
        public AddNewMember()
        {
            InitializeComponent();
        }

        private readonly DLPU_ManageService service = new DLPU_ManageService();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newUser = new User
            {
                ClassId = this.textBox1.Text,
                Name = this.textBox2.Text,                ,
                EnglishName = this.textBox3.Text,
                Gender = this.textBox4.Text,
                Credit = int.Parse(this.textBox5.Text),
                GitHub = this.textBox6.Text,
                CSDN = this.textBox7.Text,
                Email = this.textBox8.Text,                
            };
            this.Close();
        }

        private void AddNewMember_Load(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) 
        {

        }
    }
}
