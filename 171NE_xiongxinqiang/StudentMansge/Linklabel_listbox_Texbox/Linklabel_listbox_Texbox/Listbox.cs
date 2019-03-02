using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linklabel_listbox_Texbox
{
    public partial class Listbox : Form
    {
        public Listbox()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //获取添加人的值
            string peopleText = this.textBoxAdd.Text.Trim().ToString();
            //获取listboxBuy的对象
            ListBox list1 = this.listBoxBuy;
            //判断人员是否已经添加过
            if (!list1.Items.Contains(peopleText))
            {
                list1.Items.Add(peopleText);
                textBoxAdd.Text = null;
            }
            else
            {
                MessageBox.Show("该人员已经添加过，无法重复添加！");
                textBoxAdd.Text = null;
            }
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            if (this.listBoxBuy.SelectedItems.Count > 0)
            {
                string checkPeople = this.listBoxBuy.SelectedItem.ToString();
                if (!this.listBoxSale.Items.Contains(checkPeople))
                {
                    this.listBoxSale.Items.Add(checkPeople);
                    this.listBoxBuy.Items.Remove(checkPeople);
                }
                else
                {
                    MessageBox.Show("该人员已经转移过，无法重复转移！");
                }

            }
            else
            {
                MessageBox.Show("未选中采购人员，无法转移销售部门！");
            }
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (this.listBoxSale.SelectedItems.Count > 0)
            {
                string checkPeople = this.listBoxSale.SelectedItem.ToString();
                if (!this.listBoxBuy.Items.Contains(checkPeople))
                {
                    this.listBoxBuy.Items.Add(checkPeople);
                    this.listBoxSale.Items.Remove(checkPeople);
                }
                else
                {
                    MessageBox.Show("该人员已经转移过，无法重复转移！");
                }

            }
            else
            {
                MessageBox.Show("未选中采购人员，无法转移销售部门！");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.listBoxSale.SelectedItems.Count > 0)
            {
                while (this.listBoxSale.SelectedItem != null)
                {
                    this.listBoxSale.Items.Remove(this.listBoxSale.SelectedItem);
                }
            }
            else if(this.listBoxBuy.SelectedItems.Count > 0)
            {
                while (this.listBoxBuy.SelectedItem != null)
                {
                    this.listBoxBuy.Items.Remove(this.listBoxBuy.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("未选中人员，无法删除！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int lbxLength = this.listBoxBuy.Items.Count; 
            int iselect = this.listBoxBuy.SelectedIndex; 
            if (lbxLength > iselect && iselect > 0)
            {
                object oTempItem = this.listBoxBuy.SelectedItem;
                this.listBoxBuy.Items.RemoveAt(iselect);
                this.listBoxBuy.Items.Insert(iselect - 1, oTempItem);
                this.listBoxBuy.SelectedIndex = iselect - 1;
            }
        }
    }
}
