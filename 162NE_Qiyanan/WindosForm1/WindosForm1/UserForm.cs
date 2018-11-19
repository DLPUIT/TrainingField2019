using Repository;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindosForm1
{
    public partial class UserForm : Form
    {
        private Manage newManage = new Manage();
        private UserModel user;
        private EditMode model;
        public UserForm(UserModel newUser, EditMode model)
        {
            InitializeComponent();
            this.user = newUser ?? new UserModel();
            this.model = model;
            this.InitializeData();

        }
        private void InitializeData()
        {
            if (this.model == EditMode.View)
            {
                this.ClassId.ReadOnly = true;
                this.ClassName.ReadOnly = true;
                this.Name.ReadOnly = true;
                this.Credit.ReadOnly = true;
                this.Gender.ReadOnly = true;
                this.Team.ReadOnly = true;
                this.GitHub.ReadOnly = true;
            }
            else
            {
                this.ClassId.Text = this.user.ClassId;
                this.ClassName.Text = this.user.ClassName;
                this.Name.Text = this.user.Name;
                this.Credit.Text = this.user.Credits.ToString();
                this.Gender.Text = this.user.Gender;
                this.Team.Text = this.user.Team;
                this.GitHub.Text = this.user.GitHub;
            }

        }


        private void Submit_Click(object sender, EventArgs e)
        {
            if (model == EditMode.Create)
            {
                this.user.ClassId = this.ClassId.Text;
                this.user.ClassName = this.ClassName.Text;
                this.user.Credits = Convert.ToInt32(this.Credit.Text);
                this.user.Name = this.Name.Text;
                this.user.Gender = this.Gender.Text;
                this.user.Team = this.Gender.Text;
                this.user.GitHub = this.Gender.Text;
                this.newManage.AddUser(this.user);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void label6_Click(object sender, EventArgs e)
        {

        }



    }
}
