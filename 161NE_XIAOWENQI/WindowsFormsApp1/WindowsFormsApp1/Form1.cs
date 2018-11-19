using DlpuManager.Service;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.LoadData();
        }
        private readonly DlpuManagerService service = new DlpuManagerService();


        public void LoadData()
        {
            var allMember = this.service.GetAllMember();

            var dataTable = new DataTable();
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("EnglishName", typeof(string));
            dataTable.Columns.Add("Gender", typeof(string));
            dataTable.Columns.Add("ClassId", typeof(string));
            dataTable.Columns.Add("Credits", typeof(int));
            dataTable.Columns.Add("GitHub", typeof(string));

            dataTable.Columns.Add("Id", typeof(string));

            foreach (var user in allMember)
            {
                dataTable.Rows.Add(user.Name,user.EnglishName,user.Gender, user.ClassId, user.Credits, user.GitHub);
            }

            this.dataGridView1.DataSource = dataTable;
            this.dataGridView1.Columns["Id"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var allMembers = this.service.GetAllMember();
            dataGridView1.DataSource = allMembers;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count < 1) { return; }
            var currentSelectedMemberName = (string)this.dataGridView1.SelectedRows[0].Cells["Name"].Value;
            var confirmResult = MessageBox.Show("你确定要删除这位成员吗?", "删除成员", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (confirmResult == DialogResult.Yes)
            {
                this.service.DeleteMember(currentSelectedMemberName);
                this.LoadData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var addWindow = new AddForm(new User(), EditMode.Create);
            addWindow.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count < 1) { return; }
            var currentSelectedMemberName = (string)this.dataGridView1.SelectedRows[0].Cells["Name"].Value;
            var userInfo = this.service.FindMember(currentSelectedMemberName);
            var infoWindow = new AddForm(userInfo, EditMode.Edit);
            infoWindow.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请双击要查找的人");
        }

      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count < 1) { return; }
            var currentSelectedMemberName = (string)this.dataGridView1.SelectedRows[0].Cells["Name"].Value;
            var user = this.service.FindMember(currentSelectedMemberName);
            var infoWindow = new AddForm(user, EditMode.View);
            infoWindow.ShowDialog();
        }
    }
}
