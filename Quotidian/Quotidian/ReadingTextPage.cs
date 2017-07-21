using System;
using System.Globalization;
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
    public partial class ReadingTextPage : Form
    {
        public Project currentProject;
        public Reading currentReading;

        public String title { get; set; }
        public String first { get; set; }
        public String middle { get; set; }
        public String last { get; set; }
        public String dateMonth { get; set; }
        public int dateDay { get; set; }
        public int dateYear { get; set; }
        public String publisherName { get; set; }
        private ReadingInfo form;

        public ReadingTextPage(String docTitle, Reading r, ReadingInfo f)
        {
            currentProject = f.selectedProject;
            currentReading = r;
            InitializeComponent();
        }

        private void pasteBtn_Click(object sender, EventArgs e)
        {
            readingText.Text = Clipboard.GetText(System.Windows.Forms.TextDataFormat.Text);
        }

        //TODO combine this and open button
        // private void citationBtn_Click(object sender, EventArgs e)
        // {
            // String text = readingText.Text;
            // //reading1 = new Reading(-1, -1, -1, title, new List<Author>(), text, dateMonth, dateDay, dateYear, publisherName);
            // reading1.text = text;
            // currentProject.readings.Add(reading1);
            // int dateMonth = DateTime.ParseExact(reading1.dateMonth, "MMMM", CultureInfo.CurrentCulture).Month;
            // var newReading = DatabaseInterface.createReading(currentProject.projectId, reading1.title, "Last needs changed", reading1.text, reading1.style, new DateTime(reading1.dateYear,dateMonth,reading1.dateDay), reading1.publisherName, reading1.city, reading1.yearPublished);
            // List<ReadingTag> readingTags = reading1.getReadingTags();
            // for (int i=0; i < readingTags.Count; i++)
            // {
                // DatabaseInterface.createReadingTag(newReading.readingId, readingTags[i].tag);
            // }
            // reading1 = newReading;
            // generatedLabel.Text = currentReading.createCitation();
        // }

        private void generatedLabel_Click(object sender, EventArgs e)
        {

        }

        private void ReadingTextPage_Load(object sender, EventArgs e)
        {

        }

        private void openButton_Click(object sender, EventArgs e)
        {
            currentReading.text = readingText.Text;
            if (currentReading.readingId < 0)
            {
                currentProject.readings.Add(currentReading);
            }
            var readingPage = new ReadingPage(currentProject, currentReading);
            DatabaseInterface.updateProject(currentProject);
            this.Hide();
            readingPage.Show();
        }
    }
}
