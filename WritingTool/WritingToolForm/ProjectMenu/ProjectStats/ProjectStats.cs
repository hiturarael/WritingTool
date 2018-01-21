using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WritingToolForm.ProjectMenu.ProjectStats
{
    public partial class ProjectStats : Form
    {
        public Project project;

        public ProjectStats(Project prj)
        {
            InitializeComponent();
            project = prj;
        }

        private void ProjectStats_Load(object sender, EventArgs e)
        {
            int genreCount = project.novel.GetGenres().Count();
            int curGenre = 0;
            string genres = "";

            foreach(string genre in project.novel.GetGenres())
            {
                genres += genre;

                if(curGenre < genreCount)
                { genres += ", "; }
            }

            lblAuthor.Text = project.novel.GetAuthor();
            lblTitle.Text = project.novel.GetTitle();
            lblGenres.Text = genres;
            rtbSynopsis.Text = project.novel.GetSynopsis();
        }

        private void BtnEditCover_Click(object sender, EventArgs e)
        {
            NewForms.ProjectForm form = new NewForms.ProjectForm(project);

            form.ShowDialog();
        }
    }
}
