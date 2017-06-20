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
    public partial class SelectReading : Form
    {
        public Project selectedProject;
        public List<Reading> readings;
        public Reading selectedReading;
        public ReadingPage callingForm;

        public SelectReading(Project project, ReadingPage caller)
        {
            InitializeComponent();
            this.Show();
            selectedProject = project;
            selectedReading = caller.reading;
            readings = project.readings;
            callingForm = caller;
            initializeReadingListBox();
        }

        private void SelectReading_Load(object sender, EventArgs e)
        {

        }

        public void initializeReadingListBox()
        {
            selectReadingListBox.DataSource = readings;
            selectReadingListBox.DisplayMember = "title";
            selectReadingListBox.ValueMember = "readingId";
        }

        private void openReadingButton_Click(object sender, EventArgs e)
        {
            if (selectedProject == null)
            {
                System.Windows.Forms.MessageBox.Show("No Reading Selected!");
            }
            else
            {
                this.Hide();
                var readingPage = new ReadingPage(selectedProject, selectedReading, callingForm.citationForm);
                readingPage.Show();
            }
        }

        private void selectReadingListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
             selectedReading = (Reading)((ListBox)sender).SelectedItem;
        }

        private void SelectReading_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Hide();
            var readingPage = new ReadingPage(selectedProject, selectedReading, callingForm.citationForm);
            readingPage.Show();
        }
    }
}
