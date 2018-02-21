using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novelis
{
    public partial class Main : Form
    {
        #region Main Form
        /// <summary>
        /// Initializes the main form 
        /// </summary>
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the load action of the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            //write the version number
            lblVrsnNum.Text = Application.ProductVersion;

            //writes the project titles to the select box
            WriteProjectLoadDisplay();
        }

        #endregion

        #region  Clicks
        /// <summary>
        /// Handles functionality for the New Project button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNewPrj_Click(object sender, EventArgs e)
        {
            //instantiate new project
            Project newProject = new Project();

            //create a new form and display
            NewForms.ProjectForm newForm = new NewForms.ProjectForm(newProject, true);
            newForm.ShowDialog();

            //update the project display panel
            WriteProjectLoadDisplay();

            //create the menu and display
            ProjectMenu.ProjectMenu menu = new ProjectMenu.ProjectMenu(newProject);

            Hide();

            menu.ShowDialog();

            Show();
        }

        /// <summary>
        /// Handles functionality for the Load Project button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLoadPrj_Click(object sender, EventArgs e)
        {
            //declare variables
            string projectName;
            string filepath = "";
            Project prj = new Project();

            //get selected project name
            projectName = listBoxPrjs.SelectedItem.ToString();

            //navigate to the filepath
            filepath = Novelis.Filepath + projectName;

            //fill project data
            prj.SetTitle(projectName);
            Project.GetCoverXML(filepath, prj);

            //display the menu
            ProjectMenu.ProjectMenu menu = new ProjectMenu.ProjectMenu(prj);

            Hide();

            menu.ShowDialog();

            Show();
        }

        /// <summary>
        /// Handles functionality for the Delete Project button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelProj_Click(object sender, EventArgs e)
        {
            //get the project name
            string projectName;
            projectName = listBoxPrjs.SelectedItem.ToString();

            //Delete the project
            Project.DeleteProject(projectName);
        }
        #endregion

        #region Functions
        /// <summary>
        /// Writes the Projects to the load list.
        /// </summary>
        private void WriteProjectLoadDisplay()
        {
            //instantiate variables
            string filepath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Novelis";
            List<string> loadContents = new List<string>();

            //go to the directory 
            if (Directory.Exists(filepath))
            {
                //if it exists then loop through each directory and add the project name
                foreach (string directory in Directory.GetDirectories(filepath))
                { loadContents.Add(directory.Replace(filepath + "\\", "")); }

                listBoxPrjs.Enabled = true;
            }

            if(!Directory.Exists(filepath) || loadContents.Count() == 0)
            {
                //directory does not exist or no projects in directory then display no projects and disable the box.
                loadContents.Add("No Projects Available");
                listBoxPrjs.Enabled = false;
            }

            //set the data contents
            listBoxPrjs.DataSource = loadContents;
        }
        #endregion

    }
}
