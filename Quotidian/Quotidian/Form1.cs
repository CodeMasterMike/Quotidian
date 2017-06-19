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
            richTextBox1.SelectionBackColor = Color.Yellow;
            if (String.IsNullOrEmpty(richTextBox2.Text))
            {
                richTextBox2.AppendText(richTextBox1.SelectedText);
            }
            else
            {
                richTextBox2.AppendText(Environment.NewLine);
                richTextBox2.AppendText(richTextBox1.SelectedText);
            }
            highlight1 = new HelperObjects.Highlight(highlightcount, 1, true, richTextBox1.SelectionStart, richTextBox1.SelectedText.Length);
            highlightcount++;
        }


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
            if (String.IsNullOrEmpty(richTextBox3.Text))
            {
                richTextBox3.AppendText(richTextBox1.SelectedText);
            }
            else
            {
                richTextBox3.AppendText(Environment.NewLine);
                richTextBox3.AppendText(richTextBox1.SelectedText);
            }
            highlight1 = new HelperObjects.Highlight(highlightcount, 1, false, richTextBox1.SelectionStart, richTextBox1.SelectedText.Length);
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
    }
}
