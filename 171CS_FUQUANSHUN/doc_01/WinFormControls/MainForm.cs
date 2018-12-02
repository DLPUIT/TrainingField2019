using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WinFormControls
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.pictureBox1.Image = Image.FromFile("F:\\picture\\001.jpg");
            this.pictureBox2.Image = Image.FromFile("F:\\picture\\002.jpg");
            this.pictureBox3.Image = Image.FromFile("F:\\picture\\003.jpg");
            this.pictureBox4.Image = Image.FromFile("F:\\picture\\004.jpg");
            this.pictureBox5.Image = Image.FromFile("F:\\picture\\005.jpg");
            this.pictureBox6.Image = Image.FromFile("F:\\picture\\006.jpg");
            this.pictureBox7.Image = Image.FromFile("F:\\picture\\007.jpg");
            this.pictureBox8.Image = Image.FromFile("F:\\picture\\008.jpg");
            this.ProBar();
            this.TimeChanged();
        }
        System.Timers.Timer timer = new System.Timers.Timer();
        public void TimeChanged()
        {
            // System.Timers.Timer timer = new System.Timers.Timer();
            int i = 0;
            timer.Elapsed += Change;
           /* {
                i++; 
                pictureBox9.Image = Image.FromFile("F:\\picture\\00" + i + ".jpg");
                timer.Interval = 4000;
                if (i == 8)
                    i = 0;               
            }; */          
            timer.Start();                      
        }
        int i = 0;
        public void Change(object sender, ElapsedEventArgs e)
        {
            
            i++;
            pictureBox9.Image = Image.FromFile("F:\\picture\\00" + i + ".jpg");
            timer.Interval = 4000;
            if (i == 8)
                i = 0;
        }
        public void ProBar()
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 50;
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            /*
            if (int.Parse(this.Text) == int.Parse(this.Text) + 1)
            {
                pictureBox9.Image = Image.FromFile("F:\\picture\\00" + this.Text + ".jpg");
            } 
            if (int.Parse(this.Text) == int.Parse(this.Text) - 1)
            {
                pictureBox9.Image = Image.FromFile("F:\\picture\\00" + this.Text + ".jpg");
            }
            */

        }
    }
}
