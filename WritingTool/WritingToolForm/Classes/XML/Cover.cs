using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Windows.Forms;


namespace Novelis
{
    public class Cover
    {
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

        public static void NewCover(Project prj)
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
                writer.WriteElementString("Locations", prj.GetLocationFilepath());
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //loop through each node and check the tag name against what we're looking for. 
            foreach (string tag in tags)
            {
                doc.IterateThroughAllNodes(delegate (XmlNode node)
                {
                    //if the tag name is what we're looking for, set our data.
                    if (node.Name.ToLower() == tag)
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
}
