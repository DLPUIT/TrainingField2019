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
    public partial class winformManagement : Form
    {
        public winformManagement()
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
            var deleteWindowsFormMember = dataGridView1.SelectedRows[0].Cells[1].Value as string;
            // as string 强制类型转换
            this.service.DeleteMember(deleteWindowsFormMember);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var addWinFormMember = new EditMember();
            addWinFormMember.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var editWinFormMember = dataGridView1.SelectedRows[0].Cells[1].Value as string;
            this.service.FindMember(editWinFormMember);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void winformManagement_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.button1_Click(sender,e);
        }
    }
}
