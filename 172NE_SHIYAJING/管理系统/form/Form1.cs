using DLPU.Service;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly DLPUService service = new DLPUService();
        private void button1_Click(object sender, EventArgs e)
        {
            var allmember = this.service.GetAllmember();
            dataGridView1.DataSource = allmember;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           var addwindow= new Form2();
            addwindow.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = dataGridView1.SelectedRows[0].Cells[2].Value as string;
            this.service.Delmember(name);

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            var addwindow2 = new Form3();
            addwindow2.Show();
        }
    }
}
