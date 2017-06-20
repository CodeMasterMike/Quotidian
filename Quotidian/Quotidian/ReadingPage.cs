using Quotidian.HelperObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quotidian
{
    public partial class ReadingPage : BaseForm
    {
        public ReadingPage(Project p, Reading r, ReadingInfo f)
        {
            InitializeComponent();
            project = p;
            reading = r;//new Reading(-1, -1, -1, "No Title", "First", "M.", "Last", "", "Jan.", 1, 1999, "Publisher");
            readingDoc.Text = reading.text;
            citationForm = f;
        }

        public Project project;
        public Reading reading;
        public ReadingInfo citationForm;
        int highlightcount = 0;
        HelperObjects.Highlight highlight1;

        private void quoteBtn_Click(object sender, EventArgs e)
        {
            String authorPage = getAuthorPage(readingDoc.SelectionStart);
            readingDoc.SelectionBackColor = Color.Yellow;
            int numLines = readingDoc.Lines.Count();

            if (!String.IsNullOrEmpty(richTextBox2.Text))
            {
                richTextBox2.AppendText(Environment.NewLine);
            }
            richTextBox2.AppendText("\"" + readingDoc.SelectedText + "\" " + authorPage);
            
            highlight1 = new HelperObjects.Highlight(highlightcount, 1, true, readingDoc.SelectionStart, readingDoc.SelectedText.Length);
            highlightcount++;
        }

        public override void addDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("In the reading form");
        }

        //this function returns a formatted string [Author, pageNum] to be appended onto quote
        private String getAuthorPage(int charNum)
        {
            String s = "[" + reading.last + ", " + (int)(charNum / reading.linesPerPage + 1) + "]";
            return s;
        }

        //TODO: This should probably bring up a new reading screen??
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            readingDoc.SelectionBackColor = Color.White;
        }

        private void textBtn_Click(object sender, EventArgs e)
        {
            readingDoc.SelectionBackColor = Color.LightSkyBlue;
            if (!String.IsNullOrEmpty(richTextBox3.Text))
            {
                richTextBox3.AppendText(Environment.NewLine);
            }
            richTextBox3.AppendText(readingDoc.SelectedText);
            highlight1 = new HelperObjects.Highlight(highlightcount, 1, false, readingDoc.SelectionStart, readingDoc.SelectedText.Length);
            highlightcount++;
        }

        private void Test1_Click(object sender, EventArgs e)
        {
            //test inserting project
            Project project1 = DatabaseInterface.createProject("TestProject123");
            Reading reading1 = DatabaseInterface.createReading(1, "Test Reading", "Jim Thorpe", "Jimmy T was a class act. His legend is undeniable.");
            Highlight highlight1 = DatabaseInterface.createHighlight(1, true, 1, 10);

            int tester = -1;
		}	
			
        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newReadingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadingInfo newForm = new Quotidian.ReadingInfo(project);
            newForm.Show();
        }

        private void openReadingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectReading selectReading = new SelectReading(project, this);
        }

        private void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenProject openProject = new OpenProject();
        }
    }
}