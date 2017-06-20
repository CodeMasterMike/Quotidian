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
        public Form1 callingForm;

        public SelectReading(Project project, Form1 callingForm)
        {
            InitializeComponent();
            selectedProject = project;
            readings = project.readings;
            initializeProjectListBox();
        }

        private void SelectReading_Load(object sender, EventArgs e)
        {

        }

        public void initializeProjectListBox()
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
                callingForm.reading = selectedReading;
                this.Hide();
            }
        }

        private void selectReadingListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
             selectedReading = (Reading)((ComboBox)sender).SelectedItem;
        }
    }
}
