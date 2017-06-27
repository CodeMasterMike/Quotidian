using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Quotidian.HelperObjects;

namespace Quotidian
{
    public partial class ReadingInfo : Form
    {
        public Project selectedProject;
        public Reading selectedReading;

        public ReadingInfo(Project p, Reading r, bool isNew)
        {
            selectedProject = p;
            if (isNew == false)
            {
                selectedReading = r;
                InitializeComponent();
                nxtButton.Visible = false;
                updateTextBoxes(r);
            }
            else
            {
                InitializeComponent();
                citationBtn.Visible = false;
            }

        }

        private void updateTextBoxes(Reading r)
        {
            docTitleBox.Text = r.title;
            firstBox.Text = r.first;
            middleBox.Text = r.middle;
            lastBox.Text = r.last;
            publisherBox.Text = r.publisherName;
            dateBox.Text = r.getDateString();
            //TODO tagsBox.Text = 
        }

        private void docTitleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nxtButton_Click(object sender, EventArgs e)
        {
            String docTitle = docTitleBox.Text;
            String authorFirst = firstBox.Text;
            String authorMiddle = middleBox.Text;
            String authorLast = lastBox.Text;
            String publisher = publisherBox.Text;
            DateTime datePublished = new DateTime();
            try
            {
                datePublished = Convert.ToDateTime(dateBox.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            String tags = tagsBox.Text;
            String month = datePublished.ToString("MMMM");
            int day = datePublished.Day;
            int year = datePublished.Year;
            //var nextPage = new ReadingTextPage(docTitle, authorFirst, authorMiddle, authorLast, month, day, year, publisher, this);
            this.Hide();
            //nextPage.Show();
            // Regex dateRegex = new Regex();
            selectedReading.title = docTitle;
            selectedReading.first = authorFirst;
            selectedReading.middle = authorMiddle;
            selectedReading.last = authorLast;
            selectedReading.publisherName = publisher;
            selectedReading.dateDay = datePublished.Day;
            selectedReading.dateMonth = month;
            selectedReading.dateYear = datePublished.Year;
        }

        [STAThread]
        static void Main()
        {
            Application.Run(new OpenProject());
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String f = firstBox.Text;
            String m = middleBox.Text;
            String l = lastBox.Text;
            authorList.Items.Add(new ListViewItem(f + " " + m + " " + l));
        }
    }
}
