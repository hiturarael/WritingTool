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
    public partial class Novel : Form
    {
        #region Properties
        private string filepath = "C:\\Novellis\\";
        private bool isANewProject = true;
        private string title = "";
        private string author = "";
        private List<string> genre = new List<string>();
        private string synopsis = "";
        #endregion

        #region Functions
        
        #region Filepath
        public string GetFilepath() { return filepath; }
        public void SetFilepath(string value) { filepath = value; }
        #endregion

        #region New Project
        public bool GetProjectNew() { return isANewProject; }
        public void SetProjectNew(bool value) { isANewProject = value; }
        #endregion

        #region Title
        public string GetTitle() { return title; }
        public void SetTitle(string value) { title = value; }
        #endregion

        #region Author
        public string GetAuthor() { return author; }
        public void SetAuthor(string value) { author = value; }
        #endregion

        #region Genre
        public List<string> GetGenres() { return genre; }
        public void SetGenres(List<string> values) { genre.AddRange(values); }
        public void SetGenre(string value) { genre.Add(value); }
        #endregion

        #region Synopsis
        public string GetSynopsis() { return synopsis; }
        public void SetSynopsis(string value) { synopsis = value; }
        #endregion
        #endregion

        public Novel()
        {
            InitializeComponent();
        }

        private void BtnSaveNvlProp_Click(object sender, EventArgs e)
        {
            Novel newNovel = new Novel();
            SetPrjData(newNovel);

            WriteToDatabase.Project.SaveProject(newNovel, true);            
        }

        private void SetPrjData(Novel novel)
        {
            novel.SetTitle(txtNvlTitle.Text);
            novel.SetAuthor(txtNvlAuthor.Text);
            novel.SetSynopsis(txtBoxSynopsis.Text);

            foreach(object item in lbGenres.SelectedItems)
            {
                genre.Add(item.ToString());
            }
        }
    }
}
