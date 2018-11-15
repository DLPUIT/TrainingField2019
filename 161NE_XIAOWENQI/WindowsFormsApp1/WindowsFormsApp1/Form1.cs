using DlpuManager.Service;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private readonly DatabaseOperation service = new DatabaseOperation();

        private void button1_Click(object sender, EventArgs e)
        {
            var allMembers = this.service.GetAll();
            dataGridView1.DataSource = allMembers;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var name=(string)dataGridView1.SelectedRows[0].Cells[1].Value;
            this.service.Delete(name);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var addWindow = new AddForm();
            addWindow.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
