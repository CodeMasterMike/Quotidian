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
using System.Data.SqlClient;

namespace Quotidian
{
    public partial class ProjectSummary : BaseForm
    {
        public List<Reading> readings;
        public List<Writing> writings;
        public Form callingForm;
        public Writing selectedWriting;
        public Reading selectedReading;
        public Project currentProject;
        int projId;

        public ProjectSummary(Project p, Form caller = null)
        {
            InitializeComponent();
            this.Show();
            currentProject = p;
            projId = currentProject.projectId;
            string str = DatabaseInterface.databaseConnectionStr;
            SqlConnection con = new SqlConnection(str);
            con.Open();
            readings = DatabaseInterface.getReadings(projId, con, true);
            writings = DatabaseInterface.getWritings(projId, con, true);
            con.Close();
            callingForm = caller;
            initializeReadingsListBox();
            initializeWritingsListBox();
        }

        public void initializeReadingsListBox()
        {
            readingsList.DataSource = readings;
            readingsList.DisplayMember = "title";
            //readingsList.ValueMember = "";
        }

        public void initializeWritingsListBox()
        {
            writingsList.DataSource = writings;
            writingsList.DisplayMember = "ProjectId";
        }


        private void openReadingBtn_Click(object sender, EventArgs e)
        {
            if (selectedReading == null)
            {
                System.Windows.Forms.MessageBox.Show("No Reading Selected!");
            }
            else
            {
                //selectedReading = DatabaseInterface.loadReading(selectedReading);
                var nextPage = new ReadingPage(currentProject, selectedReading);
            }
        }

        private void openWritingBtn_Click(object sender, EventArgs e)
        {
            if (selectedWriting == null)
            {
                System.Windows.Forms.MessageBox.Show("No Writing Selected!");
            }
            else
            {
                var nextPage = new WritingPage(currentProject, selectedWriting);
            }
        }

        private void readingsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedWriting = (Writing)((ListBox)sender).SelectedItem;
        }

        private void writingsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedReading = (Reading)((ListBox)sender).SelectedItem;
        }

        private void newReadingBtn_Click(object sender, EventArgs e)
        {
            //selectedReading = DatabaseInterface.createReading(newProjectNameTextBox.Text);
            openNewReadingPage();
        }

        private void newWritingBtn_Click(object sender, EventArgs e)
        {
            openNewWritingPage();
        }

        private void openNewReadingPage()
        {
            //var nextPage = new ProjectSummary();
            var nextPage = new ReadingPage(currentProject, new Reading(-1, -1, -1, "No Reading Selected", "", "", "", "No Reading Selected", "", -1, -1, ""));
            this.Hide();
            nextPage.Show();
        }

        private void openNewWritingPage()
        {
            //var nextPage = new ProjectSummary();
            var nextPage = new WritingPage(currentProject, new Writing());
            this.Hide();
            nextPage.Show();
        }

    }
}
