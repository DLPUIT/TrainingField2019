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

namespace course4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private readonly DlpuManagerService service = new DlpuManagerService();
        private void button1_Click(object sender, EventArgs e)
        {
            var allMembers = this.service.GetAllMember();
            dataGridView1.DataSource = allMembers;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var name = (string)dataGridView1.SelectedRows[0].Cells[2].Value;//as string; 
            this.service.DeleteMember(name);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var addWindow = new AddNew();
            addWindow.Show();

        }
    }
}
