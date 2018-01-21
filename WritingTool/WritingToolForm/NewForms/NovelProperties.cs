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

        public ProjectForm()
        {
            InitializeComponent();
        }

        public ProjectForm(Project prj)
        {
            InitializeComponent();
            project = prj;
        }

        private void BtnSaveNvlProp_Click(object sender, EventArgs e)
        {
            SetPrjData(project.novel);

            Project.SaveProject(project, true);
            
            //close this open the project menu
            Close();
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
        }
    }
}
