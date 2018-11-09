using Member_management_system;
using Member_management_system.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Find : Form
    {
        private readonly Member_management_system_Service service = new Member_management_system_Service();
        public Find()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var n = this.textBox1.Text;
            var Member = this.service.FindMember(n);
            // dataGridView1.DataSource = AllMember;
            //严格
            var dataTable = new DataTable();
            dataTable.Columns.Add("班级 ID", typeof(string));
            dataTable.Columns.Add("班级 Name", typeof(string));
            dataTable.Columns.Add("姓名", typeof(string));
            dataTable.Columns.Add("积分", typeof(int));
            dataTable.Columns.Add("Leader", typeof(string));
            dataTable.Columns.Add("GitHub", typeof(string));
            //dataTable.Columns.Add("Id", typeof(string));
            dataTable.Rows.Add(Member.ClassId, Member.ClassName, Member.Name, Member.Credits, Member.Reportto, Member.GitHub);
            this.dataGridView1.DataSource = dataTable;

        }

        private void Find_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
