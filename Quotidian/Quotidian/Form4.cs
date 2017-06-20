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
    public partial class Form4 : Form
    {
        public Project currentProject;

        public String title { get; set; }
        public String first { get; set; }
        public String middle { get; set; }
        public String last { get; set; }
        public String dateMonth { get; set; }
        public int dateDay { get; set; }
        public int dateYear { get; set; }
        public String publisherName { get; set; }
        private Form3 form;

        public Form4(String docTitle, String firstName, String middleName, String lastName, String month, int day, int year, String publisher, Form3 f)
        {
            currentProject = f.selectedProject;

            title = docTitle;
            first = firstName;
            middle = middleName;
            last = lastName;
            dateMonth = month;
            dateDay = day;
            dateYear = year;
            publisherName = publisher;
            form = f;
            InitializeComponent();
        }

        private void pasteBtn_Click(object sender, EventArgs e)
        {
            readingText.Text = Clipboard.GetText(System.Windows.Forms.TextDataFormat.Text);
        }

        private void citationBtn_Click(object sender, EventArgs e)
        {
            String text = readingText.Text;
            Reading reading1 = new Reading(-1, -1, -1, title, first, middle, last, text, dateMonth, dateDay, dateYear, publisherName);
            currentProject.readings.Add(reading1);
            var newReading = DatabaseInterface.createReading(currentProject.projectId, title, last, text);
            var readingPage = new Form1(currentProject, reading1, form);
            generatedLabel.Text = reading1.createCitation();
            
            readingPage.Show();
        }

        private void generatedLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
