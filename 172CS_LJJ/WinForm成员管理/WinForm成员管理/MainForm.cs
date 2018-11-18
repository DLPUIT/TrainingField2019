using DBService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WinForm成员管理
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private readonly MainService service = new MainService();
        private void button1_Click(object sender, EventArgs e)
        {
            var allMembers = this.service.GetAllMembers();
            dataGridView1.DataSource = allMembers;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newWindow = new AddForm();
            newWindow.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var name = dataGridView1.SelectedRows[0].Cells[2].Value as string;
            this.service.DeleteMember(name);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newWindow = new UpdateForm();
            newWindow.Show();
            }
    }
}
