using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WritingToolForm.NewForms
{
    public partial class ProjectForm : Form
    {
        private Project project;
        private bool isNewProject = true;

        public ProjectForm()
        {
            InitializeComponent();
        }

        public ProjectForm(Project prj)
        {
            InitializeComponent();
            project = prj;

            if(prj.GetTitle() != "")
            { isNewProject = false; }

            if (prj.novel.GetTitle() != "")
            { txtNvlTitle.Text = prj.novel.GetTitle(); }

            if (prj.novel.GetAuthor() != "")
            { txtNvlAuthor.Text = prj.novel.GetAuthor(); }

            if(prj.novel.GetGenres().Count() > 0)
            {
                foreach (int index in prj.novel.GetGenreIndexes())
                {
                    lbGenres.SetSelected(index, true);
                }
            }

            if(prj.novel.GetSynopsis() != "")
            { txtBoxSynopsis.Text = prj.novel.GetSynopsis(); }
        }

        private void BtnSaveNvlProp_Click(object sender, EventArgs e)
        {

            if (IsFormValid())
            {
                SetPrjData(project.novel);

                Project.SaveProject(project, isNewProject);

                //close this open the project menu
                Close();
            }
        }

        private void SetPrjData(Novel novel)
        {
            novel.SetTitle(txtNvlTitle.Text);
            novel.SetAuthor(txtNvlAuthor.Text);
            novel.SetSynopsis(txtBoxSynopsis.Text);

            foreach(object item in lbGenres.SelectedItems)
            {
                novel.SetGenre(item.ToString());                
            }

            foreach(object item in lbGenres.SelectedIndices)
            {
                novel.SetGenreIndex(Convert.ToInt16(item));
            }
        }

        private void BtnCancelNvlProp_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool IsFormValid()
        {

            if(txtNvlTitle.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Title cannot be blank. This field can be changed in the property settings at anytime.",
                    "Blank Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNvlTitle.Focus();
                return false;
            }

            if(txtNvlAuthor.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Author cannot be blank. This field can be changed in the property settings at anytime.",
                    "Blank Author", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNvlAuthor.Focus();
                return false;
            }

            if(lbGenres.SelectedItems.Count < 1)
            {
                MessageBox.Show("No Genres selected. This field can be changed in the property settings at anytime.",
                    "No Genres", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbGenres.Focus();
                return false;
            }

            if (txtBoxSynopsis.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Synopsis cannot be blank. This field can be changed in the property settings at anytime.",
                    "Blank Synopsis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxSynopsis.Focus();
                return false;
            }

            return true;
        }
    }
}
