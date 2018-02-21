using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novelis
{
    class TextEditor
    {
        #region Formatting
        public static void Bold(RichTextBox txtBox)
        {
            Font boldFont = new Font(txtBox.SelectionFont.FontFamily, txtBox.SelectionFont.SizeInPoints, FontStyle.Bold);
            Font regFont = new Font(txtBox.SelectionFont.FontFamily, txtBox.SelectionFont.SizeInPoints, FontStyle.Regular);

            if(txtBox.SelectionFont.Bold)
            {
                txtBox.SelectionFont = regFont;
            } else
            {
                txtBox.SelectionFont = boldFont;
            }
        }      

        #endregion
    }
}
