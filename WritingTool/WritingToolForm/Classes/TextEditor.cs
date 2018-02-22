using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
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
            Font old = txtBox.SelectionFont;
            Font New;

            if(old.Bold)
            {
                New = new Font(old, old.Style & ~FontStyle.Bold);
            } else
            {
                New = new Font(old, old.Style | FontStyle.Bold);
            }

            txtBox.SelectionFont = New;
        }
        
        public static void Italics(RichTextBox txtBox)
        {
            Font old = txtBox.SelectionFont;
            Font New;

            if (old.Bold)
            {
                New = new Font(old, old.Style & ~FontStyle.Italic);
            }
            else
            {
                New = new Font(old, old.Style | FontStyle.Italic);
            }

            txtBox.SelectionFont = New;
        }

        public static void Underline(RichTextBox txtBox)
        {
            Font old = txtBox.SelectionFont;
            Font New;

            if (old.Bold)
            {
                New = new Font(old, old.Style & ~FontStyle.Underline);
            }
            else
            {
                New = new Font(old, old.Style | FontStyle.Underline);
            }

            txtBox.SelectionFont = New;
        }

        public static void Strikethrough(RichTextBox txtBox)
        {
            Font old = txtBox.SelectionFont;
            Font New;

            if (old.Bold)
            {
                New = new Font(old, old.Style & ~FontStyle.Strikeout);
            }
            else
            {
                New = new Font(old, old.Style | FontStyle.Strikeout);
            }

            txtBox.SelectionFont = New;
        }

        public static void GetFontCollection(ComboBox fontBox)
        {
            InstalledFontCollection fonts = new InstalledFontCollection();

            foreach(FontFamily font in fonts.Families)
            {
                fontBox.Items.Add(font.Name);
            }

            fontBox.SelectedIndex = 0;
        }

        public static void GetFontCollection(ToolStripComboBox fontBox)
        {
            InstalledFontCollection fonts = new InstalledFontCollection();

            foreach (FontFamily font in fonts.Families)
            {
                fontBox.Items.Add(font.Name);
            }

            fontBox.SelectedIndex = 0;
        }

        public static void GetFontSizeCollection(ComboBox sizeBox)
        {
            int[] sizes = { 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };

            foreach(int size in sizes)
            {
                sizeBox.Items.Add(size);
            }

            sizeBox.SelectedIndex = 2;
        }

        public static void GetFontSizeCollection(ToolStripComboBox sizeBox)
        {
            int[] sizes = { 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };

            foreach (int size in sizes)
            {
                sizeBox.Items.Add(size);
            }

            sizeBox.SelectedIndex = 2;
        }
        #endregion

        #region Undo/Redo

        #endregion
    }
}
