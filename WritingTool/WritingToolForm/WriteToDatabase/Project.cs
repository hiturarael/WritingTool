using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WritingToolForm
{
    public class Project
    {
        #region Properties
        private string prjFilepath = "C:\\Novellis\\";
        private string chapterFilepath = "";
        private string artifactFilepath = "";
        private string characterFilepath = "";
        private string creatureFilepath = "";
        private string locationFilepath = "";
        private string raceFilepath = "";

        public Novel novel;

        #endregion

        #region Get/Set
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

        public static void SaveProject(Project prj, bool isNewProject)
        {
            if(isNewProject)
            {
                NewDirectory(prj);
                NewProperty(prj);
            }
        }

        static void NewDirectory(Project prj)
        {
            try
            {
                bool saveIsComplete = false;
                int prjNum = 0;
                string newFilepath;
                if (Directory.Exists(prj.GetFilepath() + prj.novel.GetTitle()))
                {
                    //message box that project with the name exists
                    //confirm if the user wants to save
                    //if so add a (#) and check again.
                    while (!saveIsComplete)
                    {
                        newFilepath = prj.GetFilepath() + prj.novel.GetTitle() + "(" + prjNum + ")";

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

        static void NewProperty(Project prj)
        {
            string file = prj.GetFilepath() + "\\" + prj.novel.GetTitle() + ".xml";
            string title = prj.novel.GetTitle();
            string author = prj.novel.GetAuthor();

            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true
            };

            using (XmlWriter writer = XmlWriter.Create(file, settings))
            {

                writer.WriteStartDocument();

                #region Cover Page
                writer.WriteStartElement("cover");
                writer.WriteElementString("Title", title);
                writer.WriteElementString("Author", author);

                writer.WriteEndElement();
                #endregion

                //#region Genres
                //writer.WriteStartElement("genres");

                //foreach(string genre in prj.novel.GetGenres())
                //{
                //    writer.WriteStartElement("genre");
                //    writer.WriteString(genre);
                //    writer.WriteEndElement();
                //}

                //writer.WriteEndElement();
                //#endregion

                //#region Synopsis
                //writer.WriteStartElement("synopsi");

                //writer.WriteStartElement("synopsis");
                //writer.WriteString(prj.novel.GetSynopsis());
                //writer.WriteEndElement();

                //writer.WriteEndElement();
                //#endregion

                writer.WriteEndDocument();
            }
            

            
        }
    }
}
