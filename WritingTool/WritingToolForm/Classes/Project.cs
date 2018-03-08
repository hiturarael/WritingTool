using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
using System.Linq;

namespace Novelis
{
    public class Project
    {
        #region Properties
        private string prjTitle = "";
        private string prjFilepath = Novelis.Filepath;
        private string chapterFilepath = "";
        private string artifactFilepath = "";
        private string characterFilepath = "";
        private string creatureFilepath = "";
        private string locationFilepath = "";
        private string raceFilepath = "";
        
        public Novel novel;        
        #endregion

        #region Get/Set
        #region Project Title
        public string GetTitle() { return prjTitle; }
        public void SetTitle(string value) { prjTitle = value; }
        #endregion

        #region Novel Filepath
        public string GetFilepath() { return prjFilepath; }
        public void SetFilepath(string value) { prjFilepath = value; }
        #endregion

        #region chapter filepath
        public string GetChapterFilepath() { return chapterFilepath; }
        public void SetChapterFilepath(string value) { chapterFilepath = value; }
        #endregion

        #region artifact filepath
        public string GetArtifactFilepath() { return artifactFilepath; }
        public void SetArtifactFilepath(string value) { artifactFilepath = value; }
        #endregion

        #region character filepath
        public string GetCharacterFilepath() { return characterFilepath; }
        public void SetCharacterFilepath(string value) { characterFilepath = value; }
        #endregion

        #region character filepath
        public string GetCreatureFilepath() { return creatureFilepath; }
        public void SetCreatureFilepath(string value) { creatureFilepath = value; }
        #endregion

        #region location filepath
        public string GetLocationFilepath() { return locationFilepath; }
        public void SetLocationFilepath(string value) { locationFilepath = value; }
        #endregion

        #region location filepath
        public string GetRaceFilepath() { return raceFilepath; }
        public void SetRaceFilepath(string value) { raceFilepath = value; }
        #endregion

        #endregion

        public Project()
        {
            novel = new Novel();
        }

        #region save/delete project and new directory
        public static void SaveProject(Project prj, bool isNewProject)
        {
            if(!isNewProject)
            {
                string filepath = prj.GetFilepath() + prj.GetTitle() + "\\Cover.xml";

                File.Delete(filepath);
            } else
            {
                prj.SetTitle(prj.novel.GetTitle());
                NewDirectory(prj);
            }

            Cover.NewCover(prj);
        }

        public static void DeleteProject(string projectName)
        {
            string filepath = Novelis.Filepath + projectName;
            string message = "You will not be able to recover a project after deleting. Do you REALLY want to delete this project?";
            DialogResult result = MessageBox.Show(message, "Delete Project", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string[] files = Directory.GetFiles(filepath);
                string[] directories = Directory.GetDirectories(filepath);

                foreach(string file in files)
                {
                    File.SetAttributes(file, FileAttributes.Normal);
                    File.Delete(file);
                }

                foreach(string directory in directories)
                {
                    Directory.Delete(directory);
                }

                Directory.Delete(filepath);
            }
        }

        private static void NewDirectory(Project prj)
        {
            try
            {
                bool saveIsComplete = false;
                int prjNum = 0;
                string newFilepath;
                if (Directory.Exists(prj.GetFilepath() + prj.GetTitle()))
                {
                    //message box that project with the name exists
                    //confirm if the user wants to save
                    //if so add a (#) and check again.
                    while (!saveIsComplete)
                    {
                        newFilepath = prj.GetFilepath() + prj.GetTitle() + "(" + prjNum + ")";

                        if (!Directory.Exists(newFilepath))
                        {
                            string message = "A project with that name already exists. Do you want to save this project as '" + prj.novel.GetTitle() + "(" + prjNum + ")'?";
                            DialogResult result = MessageBox.Show(message, "Project Exists", MessageBoxButtons.YesNo);

                            if (result == DialogResult.Yes)
                            {

                                Directory.CreateDirectory(newFilepath);
                                Directory.CreateDirectory(newFilepath + "\\Artifacts");
                                Directory.CreateDirectory(newFilepath + "\\Chapters");
                                Directory.CreateDirectory(newFilepath + "\\Creatures");
                                Directory.CreateDirectory(newFilepath + "\\Characters");
                                Directory.CreateDirectory(newFilepath + "\\Locations");
                                Directory.CreateDirectory(newFilepath + "\\Races");

                                prj.SetFilepath(newFilepath);
                                prj.SetArtifactFilepath(newFilepath + "\\Artifacts");
                                prj.SetChapterFilepath(newFilepath + "\\Chapters");
                                prj.SetCreatureFilepath(newFilepath + "\\Creatures");
                                prj.SetCharacterFilepath(newFilepath + "\\Characters");
                                prj.SetLocationFilepath(newFilepath + "\\Locations");
                                prj.SetRaceFilepath(newFilepath + "\\Races");

                                saveIsComplete = true;
                            } else
                            {
                                break;
                            }
                        }
                        prjNum++;
                    }
                }
                else
                {
                    newFilepath = prj.GetFilepath() + prj.novel.GetTitle();
                    prj.SetFilepath(newFilepath);
                    prj.SetArtifactFilepath(newFilepath + "\\Artifacts");
                    prj.SetChapterFilepath(newFilepath + "\\Chapters");
                    prj.SetCreatureFilepath(newFilepath + "\\Creatures");
                    prj.SetCharacterFilepath(newFilepath + "\\Characters");
                    prj.SetLocationFilepath(newFilepath + "\\Locations");
                    prj.SetRaceFilepath(newFilepath + "\\Races");

                    Directory.CreateDirectory(newFilepath);
                    Directory.CreateDirectory(newFilepath + "\\Artifacts");
                    Directory.CreateDirectory(newFilepath + "\\Chapters");
                    Directory.CreateDirectory(newFilepath + "\\Creatures");
                    Directory.CreateDirectory(newFilepath + "\\Characters");
                    Directory.CreateDirectory(newFilepath + "\\Locations");
                    Directory.CreateDirectory(newFilepath + "\\Races");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception Occured", MessageBoxButtons.OK);
            }
        }
        #endregion
    }
}
