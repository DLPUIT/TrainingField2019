using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataService;

namespace WindowsFormsApp1
{
    
    public partial class AddForm : Form
    {
        private readonly Dataservices dataservices = new Dataservices();
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newUser = new User();
            ConstructUser(newUser);

            this.dataservices.Addmember(newUser);
            this.Close();
        }

        private void ConstructUser(User newUser)
        {
            newUser.ClassId = this.textBox1.Text;
            newUser.Name = this.textBox2.Text;
            newUser.Gender = this.textBox3.Text;
            newUser.Credits = int.Parse(this.textBox7.Text);
            newUser.CSDN = this.textBox5.Text;
            newUser.GitHub = this.textBox6.Text;
            newUser.English_Name = this.textBox4.Text;
            newUser.Email = this.textBox8.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
