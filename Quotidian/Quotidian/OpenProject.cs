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

        public OpenProject()
        {
            InitializeComponent();
            projects = DatabaseInterface.getProjects();
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
            selectedProject = (Project)((ComboBox)sender).SelectedItem;
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
            }
        }

        private void newProjectButton_Click(object sender, EventArgs e)
        {
            DatabaseInterface.createProject(newProjectNameTextBox.Text);
            openNextPage();
        }

        public void openNextPage()
        {
            var nextPage = new Form1(new Reading(-1,-1,-1,"No Reading Selected","","","","No Reading Selected","",-1,-1,""), null);
            this.Hide();
            nextPage.Show();
        }
    }
}
