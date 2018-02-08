using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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

        public static readonly IList<string> tags = new List<string>()
        {
            "title",
            "author",
            "genreid",
            "genretype",
            "synopsis",
            "artifacts",
            "chapters",
            "characters",
            "locations"
        };
        
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

            NewCover(prj);
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

        private static void NewCover(Project prj)
        {
            string file = prj.GetFilepath() + prj.GetTitle() + "\\Cover.xml";

            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                OmitXmlDeclaration = true
            };

            using (XmlWriter writer = XmlWriter.Create(file, settings))
            {

                writer.WriteStartDocument();
                writer.WriteStartElement("Project");

                #region Cover Page
                writer.WriteStartElement("cover");
                writer.WriteElementString("Title", prj.novel.GetTitle());
                writer.WriteElementString("Author", prj.novel.GetAuthor());
                writer.WriteEndElement();
                #endregion

                #region Genres
                writer.WriteStartElement("genres");

                for (int x = 0; x < prj.novel.GetGenres().Count(); x++)
                {
                    writer.WriteStartElement("genre");
                    writer.WriteElementString("genreid", prj.novel.GetGenreIndexes()[x].ToString());
                    writer.WriteElementString("genretype", prj.novel.GetGenres()[x]);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();

                #endregion

                #region Synopsis
                writer.WriteStartElement("synopsi");

                writer.WriteStartElement("synopsis");
                writer.WriteString(prj.novel.GetSynopsis());
                writer.WriteEndElement();

                writer.WriteEndElement();
                #endregion

                #region filepaths
                writer.WriteStartElement("Filepaths");
                writer.WriteElementString("Artifacts", prj.GetArtifactFilepath());
                writer.WriteElementString("Chapters", prj.GetChapterFilepath());
                writer.WriteElementString("Characters", prj.GetCharacterFilepath());
                writer.WriteElementString("Creatures", prj.GetCreatureFilepath());
                writer.WriteElementString("Locations", prj.GetCreatureFilepath());
                writer.WriteEndElement();
                #endregion

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        public static void GetCoverXML(string filepath, Project prj)
        {
            //instantiate
            string file = filepath + "\\Cover.xml";
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true
            };

            XmlDocument doc = new XmlDocument();

            //load the file
            try
            {
                doc.Load(file);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //loop through each node and check the tag name against what we're looking for. 
            foreach (string tag in tags)
            {
                doc.IterateThroughAllNodes(delegate (XmlNode node)
                {
                    //if the tag name is what we're looking for, set our data.
                    if(node.Name.ToLower() == tag)
                    {
                        SetCover(tag, node.InnerText, prj);
                    }
                });
            }
        }

        private static void SetCover(string node, string nodeText, Project prj)
        {
            switch (node)
            {
                case "title":
                    prj.novel.SetTitle(nodeText);
                    break;
                case "author":
                    prj.novel.SetAuthor(nodeText);
                    break;
                case "synopsis":
                    prj.novel.SetSynopsis(nodeText);
                    break;
                case "genrename":
                case "genretype":
                    prj.novel.SetGenre(nodeText);
                    break;
                case "genreid":
                    prj.novel.SetGenreIndex(Convert.ToInt32(nodeText));
                    break;
                case "artifacts":
                    prj.SetArtifactFilepath(nodeText);
                    break;
                case "chapters":
                    prj.SetChapterFilepath(nodeText);
                    break;
                case "characters":
                    prj.SetCharacterFilepath(nodeText);
                    break;
                case "creatures":
                    prj.SetCreatureFilepath(nodeText);
                    break;
                case "locations":
                    prj.SetLocationFilepath(nodeText);
                    break;
            }

        }

    }

    public static class XmlDocumentExtensions
    {
        public static void IterateThroughAllNodes(this XmlDocument doc, Action<XmlNode> elementVisitor)
        {
            if (doc != null && elementVisitor != null)
            {
                foreach (XmlNode node in doc.ChildNodes)
                {
                    DoIterateNode(node, elementVisitor);
                }
            }
        }

        private static void DoIterateNode(XmlNode node, Action<XmlNode> elementVisitor)
        {
            elementVisitor(node);

            foreach (XmlNode childNode in node.ChildNodes)
            {
                DoIterateNode(childNode, elementVisitor);
            }
        }

    }
}
