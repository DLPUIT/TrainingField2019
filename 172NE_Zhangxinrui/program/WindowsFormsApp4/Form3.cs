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

namespace WindowsFormsApp4
{
    public partial class Form3 : Form
    {
        private readonly DlpuManagerService service = new DlpuManagerService();
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text;

            var result = this.service.FindMember(name);
            if (result == null)
            {
                this.Close();
            }
            else
            {
                textBox2.Text = result.Name;
                textBox3.Text = result.ClassId;
                textBox4.Text = result.Credits.ToString();
                textBox5.Text = result.GitHub;
                textBox6.Text = result.ClassName;
            }
            
            this.service.DeleteMember(result.Name);
            this.service.DeleteMember(result.ClassId);
            this.service.DeleteMember(result.Credits.ToString());
            this.service.DeleteMember(result.GitHub);
            this.service.DeleteMember(result.ClassName);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                Name = textBox2.Text,
                ClassId = textBox3.Text,
                ClassName = textBox6.Text,
                Credits = int.Parse(textBox4.Text),
                GitHub = textBox5.Text
            };
            this.service.AddMember(user);
            this.Close();
        }
    }
}
