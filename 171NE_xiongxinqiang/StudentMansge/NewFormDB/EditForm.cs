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

namespace NewFormDB
{
    public partial class EditForm : Form
    {
        public readonly Dataservices dataservices = new Dataservices();
        public readonly User user;
        public readonly EditMode mode;

        public EditForm(User user,EditMode mode)
        {
            InitializeComponent();
            this.user = user ?? new User();
            this.mode = mode;
            Initialize();
        }

        public void Initialize()
        {
            if(mode == EditMode.View)
            {
                textBoxName.ReadOnly = true;
                textBoxClassID.ReadOnly = true;
                textBoxCredit.ReadOnly = true;
                textBoxGithub.ReadOnly = true;
            }
            this.textBoxName.Text = this.user.Name;
            this.textBoxClassID.Text = this.user.ClassId;
            this.textBoxCredit.Text = this.user.Credits.ToString();//转换成字符串
            this.textBoxGithub.Text = this.user.GitHub;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSure_Click(object sender, EventArgs e)
        {
            switch (this.mode)
            {
                case EditMode.Create:
                    this.user.Name = this.textBoxName.Text;
                    this.user.ClassId = this.textBoxClassID.Text;
                    this.user.Credits = int.Parse(this.textBoxCredit.Text);
                    this.user.GitHub = this.textBoxGithub.Text;
                    this.dataservices.Addmember(this.user);
                    break;

                case EditMode.Edit:
                    this.user.Name = this.textBoxName.Text;
                    this.user.ClassId = this.textBoxClassID.Text;
                    this.user.Credits = int.Parse(this.textBoxCredit.Text);
                    this.user.GitHub = this.textBoxGithub.Text;
                    this.dataservices.Updatamember(this.user);
                    break;
            }
            this.Close();
        }
    }
}
