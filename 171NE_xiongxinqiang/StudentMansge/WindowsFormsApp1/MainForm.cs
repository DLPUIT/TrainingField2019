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

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.InitializeComponent();
            this.LoadData();
        }

        private readonly Dataservices dataservices = new Dataservices();

        public void LoadData()
        {
            var allMember = this.dataservices.GetAllmenber();

            var dataTable = new DataTable();
            dataTable.Columns.Add("姓名", typeof(string));
            dataTable.Columns.Add("班级 ID", typeof(string));
            dataTable.Columns.Add("性别", typeof(string));
            dataTable.Columns.Add("积分", typeof(int));
            dataTable.Columns.Add("GitHub", typeof(string));
            dataTable.Columns.Add("CSDN", typeof(string));
            dataTable.Columns.Add("英文名", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));

            foreach (var user in allMember)
            {
                dataTable.Rows.Add(user.Name, user.ClassId, user.Gender, user.Credits, user.GitHub, user.CSDN,user.English_Name,user.Email);
            }

            this.dataGridView1.DataSource = dataTable;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var addForm = new AddForm();
            addForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count < 1) { return; }
            var currentSelectedMemberName = (string)this.dataGridView1.SelectedRows[0].Cells["姓名"].Value;
            this.dataservices.FindMember(currentSelectedMemberName);

            User getuser = this.dataservices.FindMember(currentSelectedMemberName);
            var updata = new UpdataForm(getuser);

            updata.ShowDialog();
        }
    }
}
