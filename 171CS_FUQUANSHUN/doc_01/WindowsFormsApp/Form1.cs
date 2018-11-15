using DLPU_Manager.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly DLPU_ManageService service = new DLPU_ManageService();
             

        private void button1_Click(object sender, EventArgs e)
        {
            var allMembers = this.service.GetAllMember();
            dataGridView1.DataSource = allMembers;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var name = dataGridView1.SelectedRows[0].Cells[1].Value as string;
            // as 强制类型转换
            this.service.DeleteMember(name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var addWindowsForm = new AddNewMember();
            addWindowsForm.Show();
        }
    }
}
