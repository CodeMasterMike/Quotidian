using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quotidian.HelperObjects;

namespace Quotidian
{
    public partial class OpenProject : Form
    {
        public List<Project> projects;
        public Project selectedProject;
        public Form callingForm;

        public OpenProject(Form caller = null, Project currProj = null)
        {
            InitializeComponent();
            this.Show();
            projects = DatabaseInterface.getProjects();
            callingForm = caller;
            selectedProject = currProj;
            initializeProjectListBox();
        }

        public void initializeProjectListBox()
        {
            selectProjectListBox.DataSource = projects;
            selectProjectListBox.DisplayMember = "name";
            selectProjectListBox.ValueMember = "projectId";
        }

        private void selectProjectListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProject = (Project)((ListBox)sender).SelectedItem;
        }

        private void openProjectButton_Click(object sender, EventArgs e)
        {
            if(selectedProject == null)
            {
                System.Windows.Forms.MessageBox.Show("No Project Selected!");
            }
            else
            {
                selectedProject = DatabaseInterface.loadProject(selectedProject);
                var nextPage = new ReadingPage(selectedProject, new Reading(-1, -1, -1, "No Reading Selected", "", "", "", "No Reading Selected", "", -1, -1, ""), null);
            }
        }

        private void newProjectButton_Click(object sender, EventArgs e)
        {
            selectedProject = DatabaseInterface.createProject(newProjectNameTextBox.Text);
            openNextPage();
        }

        public void openNextPage()
        {
            var nextPage = new ReadingPage(selectedProject, new Reading(-1,-1,-1,"No Reading Selected","","","","No Reading Selected","",-1,-1,""), new ReadingInfo(selectedProject));
            this.Hide();
            nextPage.Show();
        }
    }
}
