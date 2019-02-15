using Db;
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
        Operation operation = new Operation();
        public Form1()
        {
            InitializeComponent();
            this.LoadData();
        }

        private void LoadData()
        {
#pragma warning disable CS8321 // 已声明本地函数，但从未使用过
            void LoadData()
#pragma warning restore CS8321 // 已声明本地函数，但从未使用过
            {
                var allMember = this.operation.GetAllUser();

                
                var dataTable = new DataTable();
                dataTable.Columns.Add("姓名", typeof(string));
                dataTable.Columns.Add("Class", typeof(string));
                dataTable.Columns.Add("Credit", typeof(int));
                dataTable.Columns.Add("ID", typeof(string));

                foreach (var user in allMember)
                {
                    dataTable.Rows.Add(user.Name, user.Class, user.Credit, user.ID);
                }

               
            }
        }

        //private void LoadData()
        //{
        //    throw new NotImplementedException();
        //}

        //private void addButton_Click(object sender, EventArgs e)
        //{

        //}

        //private void allUser_Click(object sender, EventArgs e)
        //{
        //    var alUser = operation.GetAllUser();
        //    this.dataGridView1.DataSource = allUser;
        //}

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }
    }
}
