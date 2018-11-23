using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       /*    private List<MyComboItem> CreateComboItems()
        {
            List<MyComboItem> list = new List<MyComboItem>();
            list.Add(new MyComboItem("列表框项目1"));
            list.Add(new MyComboItem("列表框项目2"));
            list.Add(new MyComboItem("列表框项目3"));
          list.Add(new MyComboItem("列表框项目4"));
            list.Add(new MyComboItem("列表框项目5"));
            return list;
        }


        private void comboBox1_SelectedIndexChanged(object sender,
                EventArgs e)
        {
            // 获取被选中项目
            MyComboItem item = comboBox1.SelectedItem as MyComboItem;
            // 执行操作
            item.Action();
        }
        //数据集绑定
        private void BindCombox1()
         {
             DataTable dt = new DataTable();
             DataColumn dc1 = new DataColumn("id");
             DataColumn dc2 = new DataColumn("name");
             dt.Columns.Add(dc1);
             dt.Columns.Add(dc2);

             DataRow dr1 = dt.NewRow();
             dr1["id"] = "1";
             dr1["name"] = "aaaaaa";

             DataRow dr2 = dt.NewRow();
             dr2["id"] = "2";
             dr2["name"] = "bbbbbb";

             dt.Rows.Add(dr1);
             dt.Rows.Add(dr2);

             comboBox1.DataSource = dt;
             comboBox1.ValueMember = "id";
             comboBox1.DisplayMember = "name";
         }*/


       private void Form1_Load(object sender, EventArgs e)
          {
              //先构造一个dataTable，或者从数据库读取到一个，这里自己构造一个
              DataTable dataTable = new DataTable("Student");
              dataTable.Columns.Add("Number", typeof(String));
              dataTable.Columns.Add("Name", typeof(String));
              dataTable.Columns.Add("RealName", typeof(String));
              dataTable.Columns.Add("UserName", typeof(String));
              dataTable.Columns.Add("Address", typeof(String));
              dataTable.Rows.Add(new String[] { "1", "James", "张三", "james.zhang", "长沙" });
              dataTable.Rows.Add(new String[] { "2", "Mary", "李四", "mary.xu", "山东" });
              dataTable.Rows.Add(new String[] { "3", "Jack", "王五", "jack.li", "台湾" });
              dataTable.Rows.Add(new String[] { "4", "joy", "赵六", "joy.zhou", "济南" });
              dataTable.Rows.Add(new String[] { "5", "jay", "钱七", "jay.ji", "美国" });
              dataTable.Rows.Add(new String[] { "6", "stephen", "康忠鑫", "Stephen.Kang", "深圳" });
              comboBox1.DataSource = dataTable;//绑定
              comboBox1.DisplayMember = dataTable.Columns[2].ColumnName;//显示的文本
              comboBox1.ValueMember = dataTable.Columns[1].ColumnName;//对应的值
          }
          
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            this.comboBox1.Text = "请选择城市";
            labelshowselected.Text = comboBox1.SelectedItem.ToString();
        }

        private void labelshowselected_Click(object sender, EventArgs e)
       {
         
        }

        private void buttonselectedshow_Click(object sender, EventArgs e)
        {
            labelshowselected.Text = comboBox1.SelectedItem.ToString();
        }
    }
}
