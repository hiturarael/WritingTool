using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Novelis.NewForms
{
    public partial class Chapter : Form
    {
        public Chapter()
        {
            InitializeComponent();
        }

        public void RtbChapter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 9)
            {
                e.Handled = true;
                SendKeys.Send("     ");
                e.ToString();
            }

            if((ModifierKeys & Keys.Control) == Keys.Control && e.KeyChar == 2)
            {
                TextEditor.Bold(rtbChapter);
            }
        }

        private void BtnBold_Click(object sender, EventArgs e)
        {
            TextEditor.Bold(rtbChapter);
        }
    }
}
