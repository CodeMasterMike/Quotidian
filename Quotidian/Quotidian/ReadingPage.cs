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
using System.Data.SqlClient;

namespace Quotidian
{
    public partial class ReadingPage : BaseForm
    {
        public ReadingPage(Project p, Reading r)
        {
            InitializeComponent();
            project = p;
            reading = r;//new Reading(-1, -1, -1, "No Title", "First", "M.", "Last", "", "Jan.", 1, 1999, "Publisher");
            readingDoc.Text = reading.text;
            string str = DatabaseInterface.databaseConnectionStr;
            SqlConnection con = new SqlConnection(str);
            con.Open();
            highlights = DatabaseInterface.getHighlights(project.projectId, reading.readingId, con, true);
            for (int i = 0; i < highlights.Count(); i++)
            {
                int start = highlights[i].charCount;
                int length = highlights[i].charNum;
                readingDoc.SelectionStart = start;
                readingDoc.SelectionLength = length;
                if (highlights[i].isQuote == true)
                {
                    readingDoc.SelectionBackColor = Color.Yellow;
                }
                
                else
                {
                    readingDoc.SelectionBackColor = Color.LightSkyBlue;
                }
            }
        }

        public Project project;
        public Reading reading;
        int highlightCount = 0;
        HelperObjects.Highlight highlight1;
        List<Highlight> highlights;

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
            highlight1 = DatabaseInterface.createHighlight((int)reading.readingId, true, readingDoc.SelectionStart, readingDoc.SelectedText.Length);
        }

        public override void addDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadingInfo info = new Quotidian.ReadingInfo(project, reading, false);
            info.Show();
        }

        //this function returns a formatted string [Author, pageNum] to be appended onto quote
        private String getAuthorPage(int charNum)
        {
            String s;

            if (reading.authors.Count() == 1)
            {
                s = "[" + reading.authors.First().last + ", " + (int)(charNum / reading.linesPerPage + 1) + "]";
            }
            else if (reading.authors.Count() > 1)
            {
                s = "[" + reading.authors.First().last + " et al, " + (int)(charNum / reading.linesPerPage + 1) + "]";
            }
            else
            {
                s = "No Authors Found.";
            }
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
            highlight1 = DatabaseInterface.createHighlight((int)reading.readingId, false, readingDoc.SelectionStart, readingDoc.SelectedText.Length);
        }

        private void Test1_Click(object sender, EventArgs e)
        {
            //test inserting project
            Project project1 = DatabaseInterface.createProject("TestProject123");
            Project project2 = DatabaseInterface.createProject("TestProject234");
            Reading reading1 = DatabaseInterface.createReading(1, "Test Reading", "Jim Thorpe", "Jimmy T was a class act. His legend is undeniable.");
            Reading reading2 = DatabaseInterface.createReading(1, "Test Reading 2", "Jim Johnson", "Jimmy J was a class act. His legend is undeniable.");
            Reading reading3 = DatabaseInterface.createReading(2, "Reading Test", "Jimony Cricket", "Jimmy C was a class act. His legend is undeniable.");
            ReadingTag rTag1 = DatabaseInterface.createReadingTag(1, "Science");
            ReadingTag rTag2 = DatabaseInterface.createReadingTag(1, "Biology");
            ReadingTag rTag3 = DatabaseInterface.createReadingTag(2, "Biology");
            Highlight highlight1 = DatabaseInterface.createHighlight(1, true, 1, 10);
            Highlight highlight2 = DatabaseInterface.createHighlight(1, true, 1, 10);
            Highlight highlight3 = DatabaseInterface.createHighlight(2, true, 1, 10);
            HighlightTag hTag1 = DatabaseInterface.createHighlightTag(1, "Science");
            HighlightTag hTag2 = DatabaseInterface.createHighlightTag(1, "Adventure");
            HighlightTag hTag3 = DatabaseInterface.createHighlightTag(2, "Technology");

            Project loadedProj = DatabaseInterface.loadProject(new Project(1, ""));
            Project loadedProj2 = DatabaseInterface.loadProject(new Project(2, ""));

            int tester = -1;
		}

        public void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public override void newReadingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadingInfo newForm = new Quotidian.ReadingInfo(project, new Reading(-1,-1,project.projectId,"", new List<Author>(),"","",0,0,""), true);
            newForm.Show();
        }

        public override void openReadingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectReading selectReading = new SelectReading(project, this);
        }

        public override void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenProject openProject = new OpenProject();
        }
    }
}