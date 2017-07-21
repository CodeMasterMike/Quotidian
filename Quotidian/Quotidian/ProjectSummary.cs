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
            //readings = DatabaseInterface.getReadings(projId, con, true);
            readings = p.readings;
            //writings = DatabaseInterface.getWritings(projId, con, true);
            writings = p.writings;
            con.Close();
            callingForm = caller;
            initializeReadingsListBox();
            initializeWritingsListBox();
            citeStyleType.Text = p.style;
            currentProject.style = p.style;
        }

        public void initializeReadingsListBox()
        {
            readingsList.DataSource = readings;
            readingsList.DisplayMember = "title";
            selectedReading = (Reading)readingsList.SelectedItem;
            //readingsList.ValueMember = "";
        }

        public void initializeWritingsListBox()
        {
            writingsList.DataSource = writings;
            writingsList.DisplayMember = "text";
            selectedWriting = (Writing)writingsList.SelectedItem;
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
                //var nextPage = new ReadingPage(currentProject, selectedReading);
                openNewReadingPage(false);
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
                openNewWritingPage(false);
            }
        }

        private void readingsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedReading = (Reading)((ListBox)sender).SelectedItem;
        }

        private void writingsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedWriting = (Writing)((ListBox)sender).SelectedItem;
        }

        private void newReadingBtn_Click(object sender, EventArgs e)
        {
            //selectedReading = DatabaseInterface.createReading(newProjectNameTextBox.Text);
            openNewReadingPage(true);
        }

        private void newWritingBtn_Click(object sender, EventArgs e)
        {
            openNewWritingPage(true);
        }

        private void openNewReadingPage(Boolean isNew)
        {
            //var nextPage = new ProjectSummary();
            if (isNew == true)
            {
                var nextPage = new ReadingInfo(currentProject, null, isNew);
                this.Hide();
                nextPage.Show();
            }
            else
            {
                selectedReading = (Reading)readingsList.SelectedItem;
                var nextPage = new ReadingPage(currentProject, selectedReading);
                this.Hide();
                nextPage.Show();
            }
        }

        private void openNewWritingPage(Boolean isNew)
        {
            if (isNew == true)
            {
                Writing newWriting = new Writing(-1, currentProject.projectId, "Type here!");
                currentProject.writings.Add(newWriting);
                var nextPage = new WritingPage(currentProject, newWriting);
                this.Hide();
                nextPage.Show();
            }
            else
            {
                var nextPage = new WritingPage(currentProject, selectedWriting);
                this.Hide();
                nextPage.Show();
            }
        }

        private void citeStyleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            String style = citeStyleType.Text;
            Console.WriteLine(style);
            currentProject.style = style;
        }
    }

 }

