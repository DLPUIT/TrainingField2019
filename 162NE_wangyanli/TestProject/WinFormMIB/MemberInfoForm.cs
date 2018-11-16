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
    public partial class MemberInfoForm : Form
    {
        private readonly DlpuManagerService service = new DlpuManagerService();
        private readonly EditMode mode;
        private readonly User user;
        public MemberInfoForm(User user, EditMode create)
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (this.mode)
            {
                case EditMode.Create:
                    this.service.AddMember(this.user);
                    break;

                case EditMode.Edit:
                    this.service.UpdateMember(this.user);
                    break;

                case EditMode.View:
                    break;
            }
            this.Close();
        }
    }
}
