using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DlpuManager.Service;
namespace WindowsForm
{
    public partial class AddNew : Form
    {
        private readonly DlpuManagerService service = new DlpuManagerService();
                
        public AddNew()
        {
            this.InitializeComponent();
        }        
       
        private void button1_Click(object sender, EventArgs e)
        {
            var user = new User();
            user.Name = textBoxName.Text;
            user.Sex = this.textBoxSex.Text;
            user.ClassId = this.textBoxClassId.Text;
            user.Credits = int.Parse(this.textBoxCredit.Text);
            user.GitHub = this.textBoxGitHub.Text;
            user.ID = this.textBoxID.Text;
            this.service.AddMember(user);
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
