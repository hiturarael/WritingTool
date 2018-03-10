using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novelis
{
    public partial class Settings : Form
    {
        private Project project = new Project()
        

        public Settings(Project prj)
        {
            project = prj;
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }

        private void GetINISettings()
        {

        }

        private void SetDefault()
        {
            if(Novelis.CheckFilepathExists(project.GetFilepath()+"//settings.ini"))
            {

            }
        }
    }
}
