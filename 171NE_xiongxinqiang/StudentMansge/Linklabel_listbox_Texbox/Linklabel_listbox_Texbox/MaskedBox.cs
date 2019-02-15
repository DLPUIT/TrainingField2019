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
    public partial class MaskedBox : Form
    {
        public MaskedBox()
        {
            InitializeComponent();
            maskedTextBox1.Mask = "00/00/0000";

            maskedTextBox1.MaskInputRejected += new MaskInputRejectedEventHandler(maskedTextBox1_MaskInputRejected);
            maskedTextBox1.KeyDown += new KeyEventHandler(maskedTextBox1_KeyDown);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (maskedTextBox1.MaskFull)
            {
                toolTip1.ToolTipTitle = "输入溺出";
                toolTip1.Show("You cannot enter any more data into the date field. Delete some characters in order to insert more data.", maskedTextBox1, 0, -20, 5000);
            }
            else if (e.Position == maskedTextBox1.Mask.Length)
            {
                toolTip1.ToolTipTitle = "Input Rejected - End of Field";
                toolTip1.Show("You cannot add extra characters to the end of this date field.", maskedTextBox1, 0, -20, 5000);
            }
            else
            {
                toolTip1.ToolTipTitle = "Input Rejected";
                toolTip1.Show("You can only add numeric characters (0-9) into this date field.", maskedTextBox1, 0, -40, 5000);
            }
        }

        void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //提示只显示5秒，如果期间输入任何数据，则自动折叠
            toolTip1.Hide(maskedTextBox1);
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }
    }
}
