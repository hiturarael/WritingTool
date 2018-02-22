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

            if ((ModifierKeys & Keys.Control) == Keys.Control && e.KeyChar== 9)
            {
                TextEditor.Italics(rtbChapter);
            }

            if ((ModifierKeys & Keys.Control) == Keys.Control && e.KeyChar == 21)
            {
                TextEditor.Underline(rtbChapter);
            }

            if ((ModifierKeys & Keys.Control) == Keys.Control && e.KeyChar==20)
            {
                TextEditor.Strikethrough(rtbChapter);
            }
        }

        private void BtnBold_Click(object sender, EventArgs e)
        {
            TextEditor.Bold(rtbChapter);
        }

        private void BtnItalic_Click(object sender, EventArgs e)
        {
            TextEditor.Italics(rtbChapter);
        }

        private void BtnUnderline_Click(object sender, EventArgs e)
        {
            TextEditor.Underline(rtbChapter);
        }

        private void BtnStrike_Click(object sender, EventArgs e)
        {
            TextEditor.Strikethrough(rtbChapter);
        }

        private void Chapter_Load(object sender, EventArgs e)
        {
            TextEditor.GetFontCollection(DrpDwnFontStyle);
            TextEditor.GetFontSizeCollection(DrpDwnFontSize);
        }
    }
}
