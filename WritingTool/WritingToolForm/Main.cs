using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WritingToolForm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblVrsnNum.Text = Application.ProductVersion;
        }

        private void BtnNewPrj_Click(object sender, EventArgs e)
        {

            Project newProject = new Project();

            NewForms.ProjectForm newForm = new NewForms.ProjectForm(newProject);

            newForm.ShowDialog();
        }
    }
}
