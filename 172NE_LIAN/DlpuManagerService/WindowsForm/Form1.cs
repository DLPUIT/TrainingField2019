using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DlpuManager.Service;
namespace WindowsForm
{
    public partial class Form1 : Form
    {
        private readonly DlpuManagerService service = new DlpuManagerService();
        public Form1()
        {
            InitializeComponent();
            this.LoadData();
        }
        public void LoadData()
        {
            var allMember = this.service.GetAllMember();
            this.dataGridView1.DataSource = allMember;
            /*var dataTable = new DataTable();
            dataTable.Columns.Add("姓名", typeof(string));
            dataTable.Columns.Add("性别", typeof(string));
            dataTable.Columns.Add("班级 ID", typeof(string));
            dataTable.Columns.Add("积分", typeof(int));
            dataTable.Columns.Add("GitHub", typeof(string));
            dataTable.Columns.Add("Id", typeof(string));

            foreach (var user in allMember)
            {
                dataTable.Rows.Add(user.Name, user.Sex, user.ClassId, user.Credits, user.GitHub, user.ID);
            }

            this.dataGridView1.DataSource = dataTable;*/
            this.dataGridView1.Columns["Id"].Visible = false;
            this.dataGridView1.Columns["Geolocation"].Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var allMembers = this.service.GetAllMember();
            dataGridView1.DataSource = allMembers;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var AddWindow = new AddNew();            
            AddWindow.Show();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count < 1) { return; }
            var name = (string)this.dataGridView1.SelectedRows[0].Cells[1].Value;
            var confirmResult = MessageBox.Show("你确定要删除这位成员吗?", "删除成员", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (confirmResult == DialogResult.Yes)
            {
                this.service.DeleteMember(name);                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {            
            var confirmResult = MessageBox.Show("您确定更改该同学的信息么。", "Are you sure", MessageBoxButtons.OK, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
