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

namespace WinFormMIB
{
   
    public partial class MainForm : Form
    {
        private readonly DlpuManagerService service = new DlpuManagerService();
        public MainForm()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            var allMember = this.service.GetAllMember();

            // Way 1: 水军写法
            //this.dataGridViewAllUser.DataSource = allMember;

            // Way 2: 正规写法，去除或隐藏无用的列字段
            var dataTable = new DataTable();
            dataTable.Columns.Add("姓名", typeof(string));
            dataTable.Columns.Add("班级 ID", typeof(string));
            dataTable.Columns.Add("积分", typeof(int));
            dataTable.Columns.Add("GitHub", typeof(string));
            dataTable.Columns.Add("Id", typeof(string));

            foreach (var user in allMember)
            {
                dataTable.Rows.Add(user.Name, user.ClassId, user.Credits, user.GitHub, user.Id);
            }

            this.dataGridViewAllUser.DataSource = dataTable;
            this.dataGridViewAllUser.Columns["Id"].Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
            // 更好的方式是下边这种: 为什么？
            // infoWindow.ShowDialog();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var infoWindow = new MemberInfoForm(new User(), EditMode.Create);

            infoWindow.Show();
            // 更好的方式是下边这种: 为什么？
            // infoWindow.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var name = this.dataGridViewAllUser.CurrentRow.Cells[1].Value;

            // 记得设置 SelectionMode 属性！！！否则总是点选一个单元格

            if (this.dataGridViewAllUser.SelectedRows.Count < 1) { return; }
            var currentSelectedMemberName = (string)this.dataGridViewAllUser.SelectedRows[0].Cells["姓名"].Value;
            var confirmResult = MessageBox.Show("你确定要删除这位成员吗?", "删除成员", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (confirmResult == DialogResult.Yes)
            {
                this.service.DeleteMember(currentSelectedMemberName);
                this.LoadData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }
    }
}
