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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private readonly Member_management_system_Service service = new Member_management_system_Service();

        private void button1_Click(object sender, EventArgs e)
        {
            //水
            var AllMember = this.service.GetAllMember();
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
            foreach(var user in AllMember)
            {
                dataTable.Rows.Add(user.ClassId, user.ClassName, user.Name, user.Credits, user.Reportto, user.GitHub);
            }
            this.dataGridView1.DataSource = dataTable;
            //this.dataGridView1.Columns["Id"].Visible = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var X = (string)dataGridView1.SelectedRows[0].Cells[1].Value ;
            this.service.DeleteMember(X);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var AddW =  new AddNew();
            AddW.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var AllMember = this.service.GetRank();
            var dataTable = new DataTable();
            dataTable.Columns.Add("班级 ID", typeof(string));
            dataTable.Columns.Add("班级 Name", typeof(string));
            dataTable.Columns.Add("姓名", typeof(string));
            dataTable.Columns.Add("积分", typeof(int));
            dataTable.Columns.Add("Leader", typeof(string));
            dataTable.Columns.Add("GitHub", typeof(string));
            //dataTable.Columns.Add("Id", typeof(string));
            foreach (var user in AllMember)
            {
                dataTable.Rows.Add(user.ClassId, user.ClassName, user.Name, user.Credits, user.Reportto, user.GitHub);
            }
            this.dataGridView1.DataSource = dataTable;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var Up = new Update();
            Up.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var f = new Find();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
