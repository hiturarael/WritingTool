﻿using System;
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
        private string prjTitle = "";
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
            if (isNewProject)
            {
                prj.SetTitle(prj.novel.GetTitle());
                NewDirectory(prj);
                NewProperty(prj);
            } else
            {
                UpdateProperty(prj);
            }
        }

        private static void NewDirectory(Project prj)
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

        private static void NewProperty(Project prj)
        {
            string file = prj.GetFilepath() + "\\Cover.xml";

            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true
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
                    writer.WriteElementString("genreid", prj.novel.GetGenres()[x]);
                    writer.WriteElementString("genretype", prj.novel.GetGenreIndexes()[x].ToString());
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

        private static void UpdateProperty(Project prj)
        {
            string file = prj.GetFilepath() + "\\" + prj.GetTitle() + ".xml";

            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true
            };

            XmlDocument doc = new XmlDocument();
            XmlNodeList nodes;

            //load the file
            doc.Load(file);

            //get the node list
            nodes = doc.GetElementsByTagName("Project");

            //go through each node to find the necessary nodes
            foreach(XmlNode node in nodes)
            {
                XmlNodeList childNodes = node.ChildNodes;

                foreach (XmlNode child in childNodes)
                {
                    if(child.Name == "cover")
                    {
                        
                    }
                }
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
            XmlNodeList nodes;

            //load the file
            try
            {
                doc.Load(file);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //get the node list
            nodes = doc.GetElementsByTagName("Project");

            //go through each node to find the necessary nodes
            foreach (XmlNode node in nodes)
            {
                foreach (XmlNode child in node.ChildNodes)
                {
                    if(child.HasChildNodes)
                    {
                        foreach(XmlNode _child in child)
                        {
                            if (_child.HasChildNodes)
                            {
                                foreach (XmlNode __child in child)
                                {
                                    SetCover(__child.InnerText, prj);
                                }
                            } else
                            {
                                SetCover(_child.InnerText, prj);
                            }
                        }
                    } else
                    {
                        SetCover(child.InnerText, prj);
                    }
                }
            }
        }

        private static void SetCover(string nodeText, Project prj)
        {
            switch (nodeText)
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

        public static void IterateThroughAllNodes(XmlDocument doc, Action<XmlNode> elementVisitor)
        {
            if(doc != null && elementVisitor != null)
            {
                foreach(XmlNode node in doc.ChildNodes)
                {
                    doIterateNode(node, elementVisitor);
                }
            }
        }

        private static void doIterateNode(XmlNode node, Action<XmlNode>elementVisitor)
        {
            elementVisitor(node);

            foreach(XmlNode childNode in node.ChildNodes)
            {
                doIterateNode(childNode, elementVisitor);
            }
        }
    }
}
