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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            reading = new Reading(-1, -1, -1, "No Title", "First", "M.", "Last", "", "Jan.", 1, 1999, "Publisher");
        }


        Reading reading;
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

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //should allow user to populate information for the readig
        //this info will be used to automatically create the reference for the user
        private void addDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //reading = new Reading(1, 1, "The Art of the Peel", "Gabriel Wells", "");
        }
    }
}