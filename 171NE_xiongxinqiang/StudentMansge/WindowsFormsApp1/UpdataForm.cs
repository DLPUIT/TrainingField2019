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
    public partial class UpdataForm : Form
    {
        private readonly Dataservices dataservices = new Dataservices();
        public class CommonData
        {
            public static User newUser { get; set; }
        }
        public UpdataForm(User user)
        {
            CommonData.newUser = user;
            User newuser = user;
            InitializeComponent();
            LoadData(newuser);
        }

        public void LoadData(User user)
        {
            this.textBox1.Text = user.Name;
            this.textBox2.Text = user.ClassId;
            this.textBox3.Text = user.Gender;
            this.textBox4.Text = Convert.ToString(user.Credits);
            this.textBox5.Text = user.GitHub;
            this.textBox6.Text = user.CSDN;
            this.textBox7.Text = user.English_Name;
            this.textBox8.Text = user.Email;
        }

        private void ReconstructUser(User result)
        {
            result.Name = this.textBox1.Text;
            result.ClassId = this.textBox2.Text;
            result.Gender = this.textBox3.Text;
            result.Credits = int.Parse(this.textBox4.Text);
            result.GitHub = this.textBox5.Text;
            result.CSDN = this.textBox6.Text;
            result.English_Name = this.textBox7.Text;
            result.Email = this.textBox8.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User result = CommonData.newUser;
            ReconstructUser(result);

            this.dataservices.Updatamember(result);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
