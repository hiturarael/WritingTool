using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WritingToolForm.WriteToDatabase
{
    class Project
    {
        public static void SaveProject(NewForms.Novel prj, bool isNewProject)
        {
            if(isNewProject)
            {
                NewDirectory(prj);

            }
        }

        static void NewDirectory(NewForms.Novel prj)
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
                    string message = "A project with that name already exists. Do you want to save this project as '" + prj.GetTitle() + "(" + prjNum + ")'?";
                    DialogResult result = MessageBox.Show(message, "Project Exists", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        newFilepath = prj.GetFilepath() + prj.GetTitle() + "(" + prjNum + ")";

                        while (!saveIsComplete)
                        {
                            prjNum++;

                            if (!Directory.Exists(prj.GetFilepath() + prj.GetTitle()))
                            {
                                DirectoryInfo directory = Directory.CreateDirectory(newFilepath);
                                prj.SetFilepath(newFilepath);

                                saveIsComplete = true;
                            }
                        }
                    }
                }
                else
                {
                    newFilepath = prj.GetFilepath() + prj.GetTitle();
                    prj.SetFilepath(newFilepath);
                    DirectoryInfo directory = Directory.CreateDirectory(newFilepath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception Occured", MessageBoxButtons.OK);
            }
        }

        static void NewProperty(NewForms.Novel prj)
        {
            string file = prj.GetFilepath() + "\\" + prj.GetTitle() + ".xml";
            XmlWriter writer = XmlWriter.Create(prj.GetTitle() + ".xml");

            writer.WriteStartDocument();

            #region Cover Page
            writer.WriteStartElement("cover");
            writer.WriteAttributeString("title", prj.GetTitle());
            writer.WriteAttributeString("author", prj.GetAuthor());
            writer.WriteEndElement();
            #endregion

            #region Genres
            writer.WriteStartElement("genres");

            foreach(string genre in prj.GetGenres())
            {
                writer.WriteElementString("genre", genre);
            }

            writer.WriteEndElement();
            #endregion

            #region Synopsis
            writer.WriteStartElement("synopsis");
            writer.WriteAttributeString("synopsis", prj.GetSynopsis());
            writer.WriteEndElement();
            #endregion

            //region chapters

            //region races

            //region artifacts
            
            //region creatures

            //region places

            //region characters
        }
    }
}
