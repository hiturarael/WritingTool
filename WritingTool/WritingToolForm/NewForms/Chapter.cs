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
                TextEditor.Bold(rtbChapter, btnBold);
            }

            if ((ModifierKeys & Keys.Control) == Keys.Control && e.KeyChar== 9)
            {
                TextEditor.Italics(rtbChapter, btnItalic);
            }

            if ((ModifierKeys & Keys.Control) == Keys.Control && e.KeyChar == 21)
            {
                TextEditor.Underline(rtbChapter, btnUnderline);
            }

            if ((ModifierKeys & Keys.Control) == Keys.Control && e.KeyChar==20)
            {
                TextEditor.Strikethrough(rtbChapter, btnStrike);
            }
        }

        private void BtnBold_Click(object sender, EventArgs e)
        {
            TextEditor.Bold(rtbChapter, btnBold);
        }

        private void BtnItalic_Click(object sender, EventArgs e)
        {
            TextEditor.Italics(rtbChapter, btnItalic);
        }

        private void BtnUnderline_Click(object sender, EventArgs e)
        {
            TextEditor.Underline(rtbChapter, btnUnderline);
        }

        private void BtnStrike_Click(object sender, EventArgs e)
        {
            TextEditor.Strikethrough(rtbChapter, btnStrike);
        }

        private void Chapter_Load(object sender, EventArgs e)
        {
            TextEditor.GetFontCollection(DrpDwnFontStyle);
            TextEditor.GetFontSizeCollection(DrpDwnFontSize, rtbChapter.Font);
        }

        private void DrpDwnFontStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextEditor.SetFontFamily(rtbChapter, DrpDwnFontStyle);
        }

        private void DrpDwnFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextEditor.SetFontSize(rtbChapter, DrpDwnFontSize);
        }

        private void rtbChapter_MouseUp(object sender, MouseEventArgs e)
        {
            TextEditor.UpdateFontStyle(rtbChapter, DrpDwnFontStyle, DrpDwnFontSize, btnBold, btnItalic, btnUnderline, btnStrike);
        }

        private void rtbChapter_KeyUp(object sender, KeyEventArgs e)
        {
            TextEditor.UpdateFontStyle(rtbChapter, DrpDwnFontStyle, DrpDwnFontSize, btnBold, btnItalic, btnUnderline, btnStrike);
        }
    }
}
