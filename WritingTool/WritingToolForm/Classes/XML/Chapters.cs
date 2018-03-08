using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
using System.Linq;

namespace Novelis
{
    public class Chapters
    {
        #region Chapter List XML
        public static void SaveChapter(RichTextBox textBox, Project prj, string filepath)
        {
            string fileName = "prj_chp_";
            int fileNum = 0;
            bool saveComplete = false;

            //save a temp of the file.
            TextEditor.Save(textBox, filepath, "_temp_",".chp");

            //check if index exists, if not make it
            if(!Directory.Exists(filepath + "\\index.xml"))
            {
                NewChapterDirectory(prj);
            }

            while (!saveComplete)
            {
                //get the file number
                if (!Directory.Exists(filepath + fileName + fileNum))
                {

                }
                //add to index

                //save the rtf

                TextEditor.Save(textBox, filepath, fileName, ".chp");
            }
        }

        public static void EditChapterDirectory(Project prj, string filename)
        {
            string file = prj.GetChapterFilepath() + "\\index.xml";

            XDocument index = XDocument.Load(file);

            XElement root = index.Element("Chapters Collection");

            IEnumerable<XElement> rows = root.Descendants("Chapter");

            foreach (XElement row in rows)
            {
                if (row.Descendants("FileName").ToString() == filename)
                {

                }
            }
        }

        public static void NewChapterDirectory(Project prj)
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
                writer.WriteStartElement("Chapters Collection");

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        #endregion

    }
}
