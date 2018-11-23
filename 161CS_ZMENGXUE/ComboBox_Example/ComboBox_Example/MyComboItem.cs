using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBox_Example
{
    class MyComboItem
    {
        private string text;
        public MyComboItem(string text)
        {
            this.text = text;
        }
        /// <summary>
        /// 项目被选中时执行的操作
        /// </summary>
        public void Action()
        {
           // MessageBox.Show(this.text);
        }
        /// <summary>
        /// 重写ToString()
        /// MyComboItem实例添加到Combo控件后，Combo控件
        /// 将显示ToString()返回的内容
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.text;
        }
    }
}
