using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingToolForm
{
    public class Novel
    {
        #region Properties
        private bool isANewProject = true;
        private string title = "";
        private string author = "";
        private List<string> genre = new List<string>();
        private List<int> genreIndexes = new List<int>();
        private string synopsis = "";
        #endregion

        #region Functions

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

        public List<int> GetGenreIndexes() { return genreIndexes; }
        public void SetGenreIndex(int value) { genreIndexes.Add(value); }
        public void SetGenreIndexes(List<int> values) { genreIndexes.AddRange(values); }
        #endregion

        #region Synopsis
        public string GetSynopsis() { return synopsis; }
        public void SetSynopsis(string value) { synopsis = value; }
        #endregion
        #endregion
    }
}
