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

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        private readonly DlpuManagerService service = new DlpuManagerService();
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Button1_Click(object sender, EventArgs e)
        {
            var allMember = this.service.GetAllMember();
            //dataGridView1.DataSource = allMembers;
            var datatable = new DataTable();
            datatable.Columns.Add("姓名",typeof(string));
            datatable.Columns.Add("班ID",typeof(string));
            datatable.Columns.Add("积分",typeof(int));
            datatable.Columns.Add("Github",typeof(string));
            datatable.Columns.Add("ClassName", typeof(string));
            datatable.Columns.Add("Id",typeof(string));
            foreach(var user in allMember)
            {
                datatable.Rows.Add(user.Name,user.ClassId,user.Credits,user.GitHub, user.ClassName);
            }
            this.dataGridView1.DataSource = datatable;
            this.dataGridView1.Columns["Id"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var name =(string)dataGridView1.SelectedRows[0].Cells[1].Value;
            this.service.DeleteMember(name);
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var addWindows = new Form2();
            addWindows.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var addWindows = new Form3();
            addWindows.Show();
        }
    }
}
