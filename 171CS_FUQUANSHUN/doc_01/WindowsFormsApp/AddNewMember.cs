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
                Name = this.textBox1.Text,
                ClassId = this.textBox2.Text,
                Credit = int.Parse(this.textBox3.Text),
                GitHub = this.textBox4.Text
            };
            this.Close();
        }

        private void AddNewMember_Load(object sender, EventArgs e)
        {


        }
    }
}
