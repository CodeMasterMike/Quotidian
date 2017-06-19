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
        }

        int highlightcount = 0;
        HelperObjects.Highlight highlight1;

        private void quoteBtn_Click(object sender, EventArgs e)
        {
            readingDoc.SelectionBackColor = Color.Yellow;
            if (String.IsNullOrEmpty(richTextBox2.Text))
            {
                richTextBox2.AppendText(readingDoc.SelectedText);
            }
            else
            {
                richTextBox2.AppendText(Environment.NewLine);
                richTextBox2.AppendText(readingDoc.SelectedText);
            }
            highlight1 = new HelperObjects.Highlight(highlightcount, 1, true, readingDoc.SelectionStart, readingDoc.SelectedText.Length);
            highlightcount++;
        }


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
            if (String.IsNullOrEmpty(richTextBox3.Text))
            {
                richTextBox3.AppendText(readingDoc.SelectedText);
            }
            else
            {
                richTextBox3.AppendText(Environment.NewLine);
                richTextBox3.AppendText(readingDoc.SelectedText);
            }
            highlight1 = new HelperObjects.Highlight(highlightcount, 1, false, readingDoc.SelectionStart, readingDoc.SelectedText.Length);
            highlightcount++;
        }
    }
}
