﻿using DLPU.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private readonly DLPUService service = new DLPUService();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
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
                Name = this.textBox1.Text,
                ClassId = this.textBox2.Text,
                Gredits = int.Parse(this.textBox3.Text),
                Github= this.textBox4.Text,
                ReportTo=this.textBox5.Text,
            };
            this.service.Addnewmember(user);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
