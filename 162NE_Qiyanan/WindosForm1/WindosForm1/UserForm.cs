using Repository;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindosForm1
{
    public partial class UserForm : Form
    {
        private Manage newManage = new Manage();
        private UserModel user=new UserModel();
        public UserForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.user.classId= this.textBox1.Text ;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.user.className=this.textBox2.Text ;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.user.name =this.textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.user.credits = Convert.ToInt32(this.textBox4.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            this.user.gender= this.textBox5.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            this.user.team= this.textBox6.Text  ;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            this.user.github= this.textBox7.Text ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.newManage.AddUser(this.user);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
