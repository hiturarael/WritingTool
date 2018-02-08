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

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblVrsnNum.Text = Application.ProductVersion;

            WriteProjectLoadDisplay();
        }

        private void BtnNewPrj_Click(object sender, EventArgs e)
        {
            Project newProject = new Project();

            NewForms.ProjectForm newForm = new NewForms.ProjectForm(newProject, true);

            newForm.ShowDialog();

            WriteProjectLoadDisplay();

            ProjectMenu.ProjectMenu menu = new ProjectMenu.ProjectMenu(newProject);
            menu.ShowDialog();

            WriteProjectLoadDisplay();
        }

        private void WriteProjectLoadDisplay()
        {
            string filepath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Novelis";
            List<string> loadContents = new List<string>();

            if (Directory.Exists(filepath))
            {
                foreach (string directory in Directory.GetDirectories(filepath))
                { loadContents.Add(directory.Replace(filepath + "\\", "")); }

                listBoxPrjs.DataSource = loadContents;
            }
        }

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

            ProjectMenu.ProjectMenu menu = new ProjectMenu.ProjectMenu(prj);
            menu.ShowDialog();
        }

        private void BtnDelProj_Click(object sender, EventArgs e)
        {
            string projectName;
            projectName = listBoxPrjs.SelectedItem.ToString();

            Project.DeleteProject(projectName);
        }
    }
}
