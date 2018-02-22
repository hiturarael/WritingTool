using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novelis.NewForms
{
    public partial class ProjectForm : Form
    {
        private Project project;
        private bool isNewProject = true;

        #region ProjectForm()
        /// <summary>
        /// Initializes the form
        /// </summary>
        public ProjectForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes the form  and creates a new project to take in the properties of an existing project.
        /// </summary>
        /// <param name="prj"></param>
        /// <param name="isNewPrj"></param>
        public ProjectForm(Project prj, bool isNewPrj)
        {
            //initializes the form
            InitializeComponent();

            //set the class project variable to the passed in project.
            project = prj;

            //set the class boolean variable to true/false to indicate that it is a new or existing project
            isNewProject = isNewPrj;

            #region Fill Form Data
            //if the variable is not blank then set the textbox to the proper text.
            if (prj.novel.GetTitle() != "")
            { txtNvlTitle.Text = prj.novel.GetTitle(); }

            //if the variable is not blank then set the textbox to the proper text.
            if (prj.novel.GetAuthor() != "")
            { txtNvlAuthor.Text = prj.novel.GetAuthor(); }

            //loop through each genre index and set the indicated ones as selected if the list is not empty
            if(prj.novel.GetGenres().Count() > 0)
            {
                foreach (int index in prj.novel.GetGenreIndexes())
                {
                    lbGenres.SetSelected(index, true);
                }
            }

            //if the variable is not blank then set the textbox to the proper text.
            if (prj.novel.GetSynopsis() != "")
            { txtBoxSynopsis.Text = prj.novel.GetSynopsis(); }
            #endregion

        }
        #endregion

        #region Clicks
        /// <summary>
        /// Perform the actions of the Save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSaveNvlProp_Click(object sender, EventArgs e)
        {
            //check if the form is valid
            if (IsFormValid())
            {
                //if the form is valid set our data
                SetPrjData(project.novel);

                //perform the save functions
                Project.SaveProject(project, isNewProject);

                //create the menu and display
                ProjectMenu.ProjectMenu menu = new ProjectMenu.ProjectMenu(project);

                menu.ShowDialog();

                //close this open the project menu
                Close();
            }
        }

        /// <summary>
        /// Performs the actions for the Cancel Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancelNvlProp_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        /// <summary>
        /// Set the data of our Novel's cover page.
        /// </summary>
        /// <param name="novel"></param>
        private void SetPrjData(Novel novel)
        {
            //set the data for title, author, and synopsis
            novel.SetTitle(txtNvlTitle.Text);
            novel.SetAuthor(txtNvlAuthor.Text);
            novel.SetSynopsis(txtBoxSynopsis.Text);

            //clear the data for the lists.
            novel.GetGenres().RemoveRange(0, novel.GetGenres().Count());
            novel.GetGenreIndexes().RemoveRange(0, novel.GetGenreIndexes().Count());

            //add the data for each list.
            foreach (object item in lbGenres.SelectedItems)
            {
                novel.SetGenre(item.ToString());
            }

            foreach(object item in lbGenres.SelectedIndices)
            {
                novel.SetGenreIndex(Convert.ToInt16(item));
            }
        }

        /// <summary>
        /// Checks that the form is valid. Requires All fields but Synopsis to be filled in
        /// </summary>
        /// <returns></returns>
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

            //if (txtBoxSynopsis.Text.Replace(" ", "") == "")
            //{
            //    MessageBox.Show("Synopsis cannot be blank. This field can be changed in the property settings at anytime.",
            //        "Blank Synopsis", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtBoxSynopsis.Focus();
            //    return false;
            //}

            return true;
        }
    }
}
