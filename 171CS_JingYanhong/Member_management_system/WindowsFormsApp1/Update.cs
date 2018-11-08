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
    public partial class Update : Form
    {
        private readonly Member_management_system_Service service = new Member_management_system_Service();
        public Update()
        {
            InitializeComponent();
        }
        

        private void Update_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name = this.textBox1.Text;
            User Result = this.service.FindMember(name);
            Result.Name = this.textBox4.Text;
            Result.ClassId = this.textBox2.Text;
            Result.GitHub = this.textBox7.Text;
            Result.Credits = int.Parse(this.textBox5.Text);
            Result.ClassName = this.textBox3.Text;
            Result.Reportto = this.textBox6.Text;
            this.service.Update(Result);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
