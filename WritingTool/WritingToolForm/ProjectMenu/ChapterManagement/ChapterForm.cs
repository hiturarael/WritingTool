﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novelis.ProjectMenu.ChapterManagement
{
    public partial class ChapterForm : Form
    {
        public ChapterForm()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAddChapter_Click(object sender, EventArgs e)
        {
            NewForms.Chapter newChapter = new NewForms.Chapter();

            newChapter.ShowDialog();
        }
    }
}
