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
        private List<string> listCombobox;
        public Form1()
        {
            InitializeComponent();
           // comboBox1.SelectedIndex = 0;           
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            labelshowselected.Text = comboBox1.SelectedItem.ToString();
        }

        private void labelshowselected_Click(object sender, EventArgs e)
        {


        }
        //按钮name属性写错了   是添加按钮对应的代码
        private void buttonselectedshow_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text != "")
            {
                string newItem = comboBox1.Text.Trim();
                bool flag = false;
                for (int i = 0; i < comboBox1.Items.Count; i++)
                {
                    if (string.Compare(newItem, comboBox1.Items[i].ToString()) == 0)
                    {
                        flag = true;
                        this.BackColor = Color.Red;
                        MessageBox.Show("已经有相同项，不能再添加");
                    }
                }

                if (flag == false)
                {
                    comboBox1.Items.Add(newItem);               
                    comboBox1.Text = "";
                }
            }


        }
         void MainForm_Load(object sender, EventArgs e)
        {
            listCombobox = getComboboxItems(this.comboBox1);//获取Item      
        }
        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            selectCombobox(comboBox1, listCombobox);
        }
        #region 设置Combobox的方法
        //模糊查询
        //得到Combobox的数据，返回一个List
        public List<string> getComboboxItems(ComboBox cb)
        {
            //初始化绑定默认关键词
            List<string> listOnit = new List<string>();
            //将数据项添加到listOnit中
            for (int i = 0; i < cb.Items.Count; i++)
            {
                listOnit.Add(cb.Items[i].ToString());
            }
            return listOnit;
        }
        //模糊查询Combobox
        public void selectCombobox(ComboBox cb, List<string> listOnit)
        {
            //输入key之后返回的关键词
            List<string> listNew = new List<string>();
            //清空combobox
            cb.Items.Clear();
            //清空listNew
            listNew.Clear();
            //遍历全部备查数据
            foreach (var item in listOnit)
            {
                if (item.Contains(cb.Text))
                {
                    //符合，插入ListNew
                    listNew.Add(item);
                }
            }
            //combobox添加已经查询到的关键字
            cb.Items.AddRange(listNew.ToArray());
            //设置光标位置，否则光标位置始终保持在第一列，造成输入关键词的倒序排列
            cb.SelectionStart = cb.Text.Length;
            //保持鼠标指针原来状态，有时鼠标指针会被下拉框覆盖，所以要进行一次设置
            Cursor = Cursors.Default;
            //自动弹出下拉框
            cb.DroppedDown = true;
        }
        #endregion
        private void btDelete_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }
    }
}
