using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom; //设置为显示格式为自定义
            dateTimePicker1.CustomFormat = "yyyy-MM-dd"; //设置显示格式
            dateTimePicker1.ShowUpDown = false;
            textBoxnowdate.Text = DateTime.Now.Date.ToString(); //设为当前日期
            String Byear = dateTimePicker1.Value.Year.ToString();               
            String Bmonth = dateTimePicker1.Value.Month.ToString();
           // int byear = Integer.parseInt(Byear);
            String Bday = dateTimePicker1.Value.Day.ToString();
            String Nyear = DateTime.Now.Date.Year.ToString();
            String Nmonth = DateTime.Now.Date.Month.ToString();
            String Nday = DateTime.Now.Date.Day.ToString();


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBoxshowyear.Text = dateTimePicker1.Value.Year.ToString() + "年";
            textBoxshowmonth.Text = dateTimePicker1.Value.Month.ToString() + "月";
            textBoxshowday.Text = dateTimePicker1.Value.Day.ToString() + "日";          
            textBoxvalueshow.Text = dateTimePicker1.Value.ToString();
            textBoxtextshow.Text = dateTimePicker1.Text.ToString();
            textBoxvalueshow.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");
        }
    }
}
