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
            reading = r;
            reading.style = p.getStyle();
            readingDoc.Text = reading.text;
            highlights = reading.highlights;
            for (int i = 0; i < highlights.Count(); i++)
            {
                int start = highlights[i].charNum;
                int length = highlights[i].charCount;
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
            selectReadingTagsListBox(); //initialize this ListBox
        }

        public Project project;
        public Reading reading;
        int highlightCount = 0;
        HelperObjects.Highlight highlight1;
        List<Highlight> highlights;
        private Highlight selectedHighlight;

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
            highlight1 = new Highlight(-1,(int)reading.readingId, true, readingDoc.SelectionStart, readingDoc.SelectedText.Length);
            reading.highlights.Add(highlight1);
            reading.modified = true;
        }

        public override void addDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadingInfo info = new Quotidian.ReadingInfo(project, reading, false);
            info.Show();
            this.Hide();
        }

        public override void saveProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseInterface.updateProject(project);
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

        private void readingTextBox_Click(object sender, EventArgs e)
        {
            readingDoc.SelectionBackColor = Color.White;

            //need to loop through the highlight tags to display the proper selection, and if no highlight selected just display readingTags
            //TODO if multiple highlights overlap, way to cycle between these
            bool found = false;
            foreach (Highlight highlight in reading.highlights)
            {
                if (readingDoc.SelectionLength == 0 && readingDoc.SelectionStart >= highlight.charNum && readingDoc.SelectionStart <= highlight.charNum + highlight.charCount)
                {
                    selectedHighlight = highlight;
                    tagsListBox.DataSource = highlight.highlightTags;
                    tagsListBox.DisplayMember = "tag";
                    tagsListBox.ValueMember = "tagId";
                    tagsListBox.Refresh();
                    found = true;
                    tagListLabel.Text = "Highlight Tags:";
                    break;
                }
            }
            if (!found)
                selectReadingTagsListBox();
        }

        private void textBtn_Click(object sender, EventArgs e)
        {
            readingDoc.SelectionBackColor = Color.LightSkyBlue;
            if (!String.IsNullOrEmpty(richTextBox3.Text))
            {
                richTextBox3.AppendText(Environment.NewLine);
            }
            richTextBox3.AppendText(readingDoc.SelectedText);
            highlight1 = new Highlight(-1, (int)reading.readingId, false, readingDoc.SelectionStart, readingDoc.SelectedText.Length);
            reading.highlights.Add(highlight1);
        }

        public void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public override void newReadingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadingInfo newForm = new Quotidian.ReadingInfo(project, new Reading(-1,project.projectId,"", new List<Author>(),"","",0,0,"","","MLA"), true);
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

        public override void viewProjectSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProjectSummary projectSummary = new ProjectSummary(project, this);
        }


        public void selectReadingTagsListBox()
        {
            tagsListBox.DataSource = reading.readingTags;
            tagsListBox.DisplayMember = "tag";
            tagsListBox.ValueMember = "tagId";
            tagsListBox.Refresh();
            tagListLabel.Text = "Reading Tags:";
            selectedHighlight = null;
        }

        public void selectHighlightTagsListBox()
        {
        }

        //private void addTagButton_Click(object sender, EventArgs e)
        //{
            
        //}

        private void addTagButton_Click_1(object sender, EventArgs e)
        {
            if (newTagTextBox.Text.Equals(""))
                System.Windows.Forms.MessageBox.Show("No text entered!");
            else if (selectedHighlight == null)
            {
                reading.readingTags.Add(new ReadingTag(-1, reading.readingId, newTagTextBox.Text));
                newTagTextBox.Text = "";
                readingTextBox_Click(null, null);
            }
            else
            {
                selectedHighlight.highlightTags.Add(new HighlightTag(-1, selectedHighlight.highlightId, newTagTextBox.Text, reading.readingId));
                newTagTextBox.Text = "";
                readingTextBox_Click(null, null);
            }
            reading.modified = true;
        }

        private void tagsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}