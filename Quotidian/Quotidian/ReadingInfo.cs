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
        public List<Author> auths = new List<Author>();

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
                selectedReading = new Reading(-1, p.projectId, "Title", new List<Author>(), "", "", -1,9999, "", "", "MLA");
            }

        }

        private void updateTextBoxes(Reading r)
        {
            docTitleBox.Text = r.title;
            publisherBox.Text = r.publisherName;
            dateBox.Text = r.getDateString();
            foreach(Author a in r.authors)
            {
                authorList.Items.Add(new ListViewItem(a.first + " " + a.middle + " " + a.last));
            }
            List<ReadingTag> readingTags = r.getReadingTags();
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
            List<ReadingTag> tags = parseTags();
            String month = datePublished.ToString("MMMM");
            int day = datePublished.Day;
            int year = datePublished.Year;
            var nextPage = new ReadingTextPage(docTitle, selectedReading, this);
            this.Hide();
            nextPage.Show();
            // Regex dateRegex = new Regex();
            selectedReading.title = docTitle;
            selectedReading.publisherName = publisher;
            selectedReading.dateDay = datePublished.Day;
            selectedReading.dateMonth = month;
            selectedReading.dateYear = datePublished.Year;
            selectedReading.authors = auths;
            selectedReading.readingTags = tags;
            selectedReading.style = "MLA";
            selectedReading.city = "";
        }

        private List<ReadingTag> parseTags()
        {
            String[] tags = tagsBox.Text.Split(',');
            List<ReadingTag> readingTags = new List<ReadingTag>();
            for (int i = 0; i < tags.Length; i++)
            {
                readingTags.Add(new ReadingTag(-1, -1, tags[i]));
            }
            return readingTags;
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
            Author newAuthor = new Author(-1,-1, f, m, l);
            auths.Add(newAuthor);
            authorList.Items.Add(new ListViewItem(f + " " + m + " " + l));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
                authorList.Items.RemoveAt(authorList.Items.Count - 1);
                //selectedReading.authors.RemoveAt(selectedReading.authors.Count() - 1);
                auths.Remove(auths.Last());
        }

        private void firstBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
