using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataService;

namespace NewFormDB
{
    public partial class MainForm : Form
    {
        private readonly Dataservices dataservices = new Dataservices();
        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            var allmember = this.dataservices.GetAllmenber();
            var dataTable = new DataTable();

            dataTable.Columns.Add("姓名", typeof(string));
            dataTable.Columns.Add("班级 ID", typeof(string));
            dataTable.Columns.Add("积分", typeof(int));
            dataTable.Columns.Add("GitHub", typeof(string));

            foreach(var user in allmember)
            {
                dataTable.Rows.Add(user.Name, user.ClassId, user.Credits, user.GitHub);
            }

            this.dataGridView1.DataSource = dataTable;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var addForm = new EditForm(new User(), EditMode.Create);

            //只能打开一个子窗口
            addForm.ShowDialog();
        }

        private void buttonFlash_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count < 1) { return; }
            var currentSelectedMemberName = (string)this.dataGridView1.SelectedRows[0].Cells["姓名"].Value;
            var confirmResult = MessageBox.Show("你确定要删除这位成员吗?", "删除成员", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (confirmResult == DialogResult.Yes)
            {
                this.dataservices.DeleteMember(currentSelectedMemberName);
                this.LoadData();
            }
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count < 1) { return; }
            var currentSelectedMemberName = (string)this.dataGridView1.SelectedRows[0].Cells["姓名"].Value;
            var userInfo = this.dataservices.FindMember(currentSelectedMemberName);
            var infoWindow = new EditForm(userInfo, EditMode.Edit);
            infoWindow.ShowDialog();
        }
    }
}
