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

    public partial class Form2 : Form
    {
        private readonly DlpuManagerService service = new DlpuManagerService();
        public Form2()
        {
            InitializeComponent();
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
                Name = textBox1.Text,
                ClassId = textBox4.Text,
                ClassName = textBox5.Text,
                Credits = int.Parse(textBox3.Text),
                GitHub = textBox2.Text
            };
            this.service.AddMember(user);
            this.Close();
        }
        
    }
}