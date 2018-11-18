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
        private readonly DatabaseOperation service = new DatabaseOperation();


        public void LoadData()
        {
            var allMember = this.service.GetAll();

            var dataTable = new DataTable();
            dataTable.Columns.Add("姓名", typeof(string));
            dataTable.Columns.Add("英文名", typeof(string));
            dataTable.Columns.Add("性别", typeof(string));
            dataTable.Columns.Add("班级 ID", typeof(string));
            dataTable.Columns.Add("得分", typeof(int));
            dataTable.Columns.Add("GitHub", typeof(string));

            dataTable.Columns.Add("Id", typeof(string));

            foreach (var user in allMember)
            {
                dataTable.Rows.Add(user.Name,user.EnglishName,user.Gender, user.ClassId, user.Credits, user.GitHub,user.Id);
            }

            this.dataGridView1.DataSource = dataTable;
            this.dataGridView1.Columns["Id"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var allMembers = this.service.GetAll();
            dataGridView1.DataSource = allMembers;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count < 1) { return; }
            var currentSelectedMemberName = (string)this.dataGridView1.SelectedRows[0].Cells["Name"].Value;
            var confirmResult = MessageBox.Show("你确定要删除这位成员吗?", "删除成员", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (confirmResult == DialogResult.Yes)
            {
                this.service.Delete(currentSelectedMemberName);
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
            var userInfo = this.service.Get(currentSelectedMemberName);
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
            var user = this.service.Get(currentSelectedMemberName);
            var infoWindow = new AddForm(user, EditMode.View);
            infoWindow.ShowDialog();
        }
    }
}
