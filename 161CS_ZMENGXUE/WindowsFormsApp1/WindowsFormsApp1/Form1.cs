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
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
          
            var dataTable = new MyDataTable();
            //checkedListBox1.DataSource = MyDataTable;
            checkedListBox1.ValueMember = "ID";
            checkedListBox1.DisplayMember = "TypeName";
           // dataTable.Columns.Add("ID", typeof(string));
            //dataTable.Columns.Add("类型名称", typeof(string));
           
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            //勾选双击/单击：
            //checkedListBox1.CheckOnClick = false;
            checkedListBox1.CheckOnClick = true;
            //是否按顺序
            //checkedListBox1.Sorted = true;
            //条目总数
            //int count = checkedListBox1.Items.Count;
            //多列显示  不正确!!
            //checkedListBox1.MultiColumn = true;
            //checkedListBox1.ColumnWidth = 1;
        }
   
        private void label2_Click(object sender, EventArgs e)
        {
      
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void addbutton_Click(object sender, EventArgs e)
        {
            //增加---方法一：
            //checkedListBox1.Items.Add("跑步");
            //checkedListBox1.Items.Add("游泳");
            //checke dListBox1.Items.Add("瑜伽", true);
            //增加---方法二：
           String[] arr = new String[] { "足球", "篮球", "排球" };
             for (int i = 0; i < arr.Count(); i++)
           {
               checkedListBox1.Items.Add(arr[i]);
           }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int count = checkedListBox1.Items.Count;
            string sb = "您的兴趣爱好是：";

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))//先判断是否被选中
                {
                    sb = sb + checkedListBox1.CheckedItems[i].ToString();//将选中的值取出
                }
            }
            label2.Text = sb;

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {    //从零开始
            checkedListBox1.Items.RemoveAt(1);

        }

        private void insertbutton_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Insert(1, "高尔夫");
        }

        private void clearcheckedbutton_Click(object sender, EventArgs e)
        {
            //方式一，测试现ClearSelected()不起作用
           /* if (checkedListBox1.CheckedItems.Count > 0)
            { checkedListBox1.ClearSelected(); } */
            //方式二,获取选中元素的下标
            
           if (checkedListBox1.CheckedItems.Count > 0) 
            { foreach(int index in this.checkedListBox1.CheckedIndices)
                {
                    checkedListBox1.SetItemChecked(index,true);
                }
            }                   
        }

        private void buttondisplay_Click(object sender, EventArgs e)
        {
          
        }
    }
}
