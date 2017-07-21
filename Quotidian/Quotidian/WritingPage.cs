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
    public partial class WritingPage : BaseForm
    {
        public WritingPage(Project p, Writing w)
        {
            InitializeComponent();
            project = p;
            writing = w;//new Reading(-1, -1, -1, "No Title", "First", "M.", "Last", "", "Jan.", 1, 1999, "Publisher");
            writingDoc.Text = writing.text;
        }

        public Project project;
        public Writing writing;

        private void searchBtn_Click(object sender, EventArgs e)
        {
            List<int[]> searchResults = StringSearch.searchReadings(project.readings, searchBox.Text);
            //project.readings list items in corresponding index to searchResults indexes
            List<SearchResult> resultsBoxData = new List<SearchResult>();
            for (int i = 0; i<searchResults.Count; i++)
            {
                resultsBoxData.Add(new SearchResult(project.readings.ElementAt(i), searchResults.ElementAt(i), searchBox.Text));
            }

            textSearchResultsListBox.DataSource = resultsBoxData;
            textSearchResultsListBox.DisplayMember = "displayString";
            textSearchResultsListBox.ValueMember = "readingId";
        }

        private void searchResultSelected(object sender, EventArgs e)
        {
            if(textSearchResultsListBox.SelectedItem != null)
            {
                ViewSearchResult searchResult = new ViewSearchResult((SearchResult)textSearchResultsListBox.SelectedItem);
            }
            else
                System.Windows.Forms.MessageBox.Show("Nothing Selected!");
		}	
			
        private void generateBibliography_Click(object sender, EventArgs e)
        {
            BibliographyPage bib = new BibliographyPage(project);
            bib.Show();
        }

        private void viewFoundResultButton_Click(object sender, EventArgs e)
        {
            if (textSearchResultsListBox.SelectedItem != null)
            {
                ViewSearchResult searchResult = new ViewSearchResult((SearchResult)textSearchResultsListBox.SelectedItem);
            }
            else
                System.Windows.Forms.MessageBox.Show("Nothing Selected!");
        }

        public override void saveProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseInterface.updateProject(project);
        }

        private void writingDoc_TextChanged(object sender, EventArgs e)
        {
            writing.modified = true;
        }

        //public override void addDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}
    }

    public class SearchResult
    {
        public Reading reading { get; set; }
        public int readingId { get; set; }
        public int resultCount { get; set; }
        public int[] resultArray { get; set; }
        public String displayString { get; set; }
        public String searchTerm { get; set; }

        public SearchResult(Reading r, int[] rArray, String term)
        {
            reading = r;
            readingId = reading.readingId;
            resultCount = rArray.Length;
            resultArray = rArray;
            displayString = reading.title + ": " + resultCount.ToString() + " results";
            searchTerm = term;
        }
    }
}