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
            reading = new Reading(-1, -1, "Title Unknown", "Author Unknown", "");
        }


        Reading reading;
        int highlightcount = 0;
        HelperObjects.Highlight highlight1;

        private void quoteBtn_Click(object sender, EventArgs e)
        {
            String authorPage = getAuthorPage(richTextBox1.SelectionStart);
            richTextBox1.SelectionBackColor = Color.Yellow;

            if (!String.IsNullOrEmpty(richTextBox2.Text))
            {
                richTextBox2.AppendText(Environment.NewLine);
            }
            richTextBox2.AppendText("\"" + richTextBox1.SelectedText + "\" " + authorPage);
            
            highlight1 = new HelperObjects.Highlight(highlightcount, 1, true, richTextBox1.SelectionStart, richTextBox1.SelectedText.Length);
            highlightcount++;
        }

        //this function returns a formatted string [Author, pageNum] to be appended onto quote
        private String getAuthorPage(int charNum)
        {
            String s = "[" + reading.author + ", " + (int)(charNum / reading.linesPerPage) + "]";
            return s;
        }

        //TODO: This should probably bring up a new reading screen??
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBackColor = Color.White;
        }

        private void textBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBackColor = Color.LightSkyBlue;
            if (!String.IsNullOrEmpty(richTextBox3.Text))
            {
                richTextBox3.AppendText(Environment.NewLine);
            }
            richTextBox3.AppendText(richTextBox1.SelectedText);
            highlight1 = new HelperObjects.Highlight(highlightcount, 1, false, richTextBox1.SelectionStart, richTextBox1.SelectedText.Length);
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

        }
    }
}
