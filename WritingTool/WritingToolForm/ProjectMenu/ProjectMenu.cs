using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novelis.ProjectMenu
{    
    public partial class ProjectMenu : Form
    {
        public Project project;

        public ProjectMenu(Project prj)
        {
            InitializeComponent();

            project = prj;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnManageChar_Click(object sender, EventArgs e)
        {
            CharacterManagement.CharacterForm charForm = new CharacterManagement.CharacterForm();
            charForm.ShowDialog();
        }

        private void BtnManageRace_Click(object sender, EventArgs e)
        {
            RaceManagement.RaceManagement raceForm = new RaceManagement.RaceManagement();
            raceForm.ShowDialog();
        }

        private void BtnManageWorld_Click(object sender, EventArgs e)
        {
            LocationManagement.LocationManagement locationForm = new LocationManagement.LocationManagement();
            locationForm.ShowDialog();
        }

        private void BtnManageCreatures_Click(object sender, EventArgs e)
        {
            CreatureManagement.CreatureManagement creatureForm = new CreatureManagement.CreatureManagement();
            creatureForm.ShowDialog();
        }

        private void BtnManageArtifacts_Click(object sender, EventArgs e)
        {
            ArtifactManagement.ArtifactManagement artifactForm = new ArtifactManagement.ArtifactManagement();
            artifactForm.ShowDialog();
        }

        private void BtnPrjStatus_Click(object sender, EventArgs e)
        {
            ProjectStats.ProjectStats statForm = new ProjectStats.ProjectStats(project);
            statForm.ShowDialog();
        }

        private void BtnManageChptr_Click(object sender, EventArgs e)
        {
            ChapterManagement.ChapterForm chapterForm = new ChapterManagement.ChapterForm(project);
            chapterForm.ShowDialog();
        }
    }
}
