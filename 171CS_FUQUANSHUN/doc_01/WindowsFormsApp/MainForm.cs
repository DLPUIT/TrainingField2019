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
    public partial class MainForm : Form
    {
        private readonly DLPU_ManageService service = new DLPU_ManageService();
        public MainForm()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            var allMembers = this.service.GetAllMember();
            // dataGridView1.DataSource = allMembers;  加载数据太水了
            // 用如下方法
            var dataTable = new DataTable();
            dataTable.Columns.Add("班级 ID", typeof(string));
            dataTable.Columns.Add("姓名", typeof(string));
            dataTable.Columns.Add("English Name", typeof(string));
            dataTable.Columns.Add("性别", typeof(string));
            dataTable.Columns.Add("当前积分", typeof(int));
            dataTable.Columns.Add("GitHub", typeof(string));
            dataTable.Columns.Add("CSDN", typeof(string));
            dataTable.Columns.Add("电子邮箱", typeof(string));
            dataTable.Columns.Add("ID", typeof(string));
            foreach (var user in allMembers)
            {
                dataTable.Rows.Add
                (
                    user.ClassId,
                    user.Name,
                    user.EnglishName,
                    user.Gender,
                    user.Credit,
                    user.GitHub,
                    user.CSDN,
                    user.Email,
                    user.Id
                 );
            }
            this.dataGridView1.DataSource = dataTable;
            this.dataGridView1.Columns["Id"].Visible = false;
        }
        private void winformManagement_Load(object sender, EventArgs e)
        {

        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var addWinFormMember = new EditMember();       // 新窗口实例化
            addWinFormMember.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // var deleteWindowsFormMember = dataGridView1.SelectedRows[0].Cells[1].Value as string;
            // as string 强制类型转换
            // this.service.DeleteMember(deleteWindowsFormMember);
            if(this.dataGridView1.SelectedRows.Count < 1) { return; }
            
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.buttonAdd_Click(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
