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

        public static void Bold(RichTextBox txtBox, ToolStripButton btn)
        {
            bool bold = txtBox.SelectionFont.Bold;
            Bold(txtBox);

            bold = txtBox.SelectionFont.Bold;

            if (bold)
            {
                btn.BackColor = Color.Silver;
            } else
            {
                btn.BackColor = Color.Transparent;
            }
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

        public static void Italics(RichTextBox txtBox, ToolStripButton btn)
        {
            bool italics = txtBox.SelectionFont.Italic;

            Italics(txtBox);

            italics = txtBox.SelectionFont.Italic;

            if (italics)
            {
                btn.BackColor = Color.Silver;
            }
            else
            {
                btn.BackColor = Color.Transparent;
            }
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

        public static void Underline(RichTextBox txtBox, ToolStripButton btn)
        {
            bool underline = txtBox.SelectionFont.Underline;
            Underline(txtBox);

            underline = txtBox.SelectionFont.Underline;

            if (underline)
            {
                btn.BackColor = Color.Silver;
            }
            else
            {
                btn.BackColor = Color.Transparent;
            }
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

        public static void Strikethrough(RichTextBox txtBox, ToolStripButton btn)
        {
            bool strike = txtBox.SelectionFont.Underline;
            Strikethrough(txtBox);

            strike = txtBox.SelectionFont.Underline;

            if (strike)
            {
                btn.BackColor = Color.Silver;
            }
            else
            {
                btn.BackColor = Color.Transparent;
            }
        }

        public static void SetFontFamily(RichTextBox txtBox, ComboBox fontBox)
        {
            Font old = txtBox.SelectionFont;
            Font New = new Font(fontBox.SelectedItem.ToString(), old.Size, old.Style);

            txtBox.SelectionFont = New;
        }

        public static void SetFontFamily(RichTextBox txtBox, ToolStripComboBox fontBox)
        {
            Font old = txtBox.SelectionFont;
            Font New = new Font(fontBox.SelectedItem.ToString(), old.Size, old.Style);

            txtBox.SelectionFont = New;
        }

        public static void SetFontSize(RichTextBox txtBox, ComboBox fontBox)
        {
            Font old = txtBox.SelectionFont;
            Font New = new Font(old.FontFamily, Convert.ToInt16(fontBox.SelectedItem.ToString()), old.Style);

            txtBox.SelectionFont = New;
        }

        public static void SetFontSize(RichTextBox txtBox, ToolStripComboBox fontBox)
        {
            Font old = txtBox.SelectionFont;
            Font New = new Font(old.FontFamily, Convert.ToInt16(fontBox.SelectedItem.ToString()), old.Style);

            txtBox.SelectionFont = New;
        }

        public static void GetFontCollection(ComboBox fontBox)
        {
            InstalledFontCollection fonts = new InstalledFontCollection();

            foreach(FontFamily font in fonts.Families)
            {
                fontBox.Items.Add(font.Name);
            }

            fontBox.SelectedItem = fontBox.Font.Name;
        }

        public static void GetFontCollection(ToolStripComboBox fontBox)
        {
            InstalledFontCollection fonts = new InstalledFontCollection();

            foreach (FontFamily font in fonts.Families)
            {
                fontBox.Items.Add(font.Name);
            }

            fontBox.SelectedItem = fontBox.Font.Name;
        }

        public static void GetFontSizeCollection(ComboBox sizeBox)
        {
            int[] sizes = { 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };

            foreach(int size in sizes)
            {
                sizeBox.Items.Add(size);
            }

            sizeBox.SelectedItem = sizeBox.Font.Size.ToString();
        }

        public static void GetFontSizeCollection(ToolStripComboBox sizeBox, Font baseFont)
        {
            int[] sizes = { 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            int selection = 0;
            int loopIteration = 0;

            foreach (int size in sizes)
            {
                if(size == baseFont.Size)
                {
                    selection = loopIteration;
                }

                sizeBox.Items.Add(size);
                loopIteration++;
            }

            sizeBox.SelectedItem = sizeBox.Items[selection];
        }

        public static void UpdateFontStyle(RichTextBox txtBox, ToolStripComboBox fontName, ToolStripComboBox fontSize, ToolStripButton bold, 
                                           ToolStripButton italic, ToolStripButton underline, ToolStripButton strike)
        {
            Font font = txtBox.SelectionFont;

            if (font != null)
            {
                #region buttons
                if (font.Bold)
                {
                    bold.BackColor = Color.Silver;
                }
                else
                {
                    bold.BackColor = Color.Transparent;
                }

                if (font.Italic)
                {
                    italic.BackColor = Color.Silver;
                }
                else
                {
                    italic.BackColor = Color.Transparent;
                }

                if (font.Underline)
                {
                    underline.BackColor = Color.Silver;
                }
                else
                {
                    underline.BackColor = Color.Transparent;
                }

                if (font.Strikeout)
                {
                    strike.BackColor = Color.Silver;
                }
                else
                {
                    strike.BackColor = Color.Transparent;
                }

                #endregion

                #region dropdowns
                fontName.SelectedItem = font.FontFamily.Name;

                foreach (object item in fontSize.Items)
                {
                    if (item.ToString() == font.Size.ToString())
                    {
                        fontSize.SelectedItem = item;
                    }
                }
                #endregion
            }
        }

        #endregion

        #region Undo/Redo

        #endregion

        #region Copy/Paste/Cut
        #endregion

        #region Save
        public static void Save(string filepath, string fileName)
        {
            int fileNum = 0;
        }
        #endregion
    }
}
