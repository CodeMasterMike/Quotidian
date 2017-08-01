using Quotidian.HelperObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            beginningTag.DataSource = DatabaseInterface.getTags(p.projectId);
        }

        public Project project;
        public Writing writing;

        private void searchBtn_Click(object sender, EventArgs e)
        {
            List<int[]> searchResults = StringSearch.searchReadings(project.readings, searchBox.Text);
            //project.readings list items in corresponding index to searchResults indexes
            List<SearchResult> resultsBoxData = new List<SearchResult>();
            List<HighlightResult> highlightBoxData = new List<HighlightResult>();
            for (int i = 0; i < searchResults.Count; i++)
            {
                resultsBoxData.Add(new SearchResult(project.readings.ElementAt(i), searchResults.ElementAt(i), searchBox.Text));
                List<int[]> highlightResults1 = StringSearch.searchHighlights(project.readings.ElementAt(i), searchBox.Text); //in same order as r.highlights (correspond)
                List<String> highlightsText = StringSearch.getHighlightsText(); //works since searchHighlights() was just called which updates the current highlightsText object in StringSearch
                for (int j = 0; j < highlightResults1.Count; j++)
                {
                    if (highlightResults1.ElementAt(j).Count() != 0 && searchResults.ElementAt(i).Count() != 0)
                    {
                        highlightBoxData.Add(new HighlightResult(project.readings.ElementAt(i), highlightsText.ElementAt(j), highlightResults1.ElementAt(j), searchBox.Text, project.readings.ElementAt(i).highlights.ElementAt(j)));
                    }
                }
            }

            textSearchResultsListBox.DataSource = resultsBoxData;
            textSearchResultsListBox.DisplayMember = "displayString";
            textSearchResultsListBox.ValueMember = "readingId";

            highlightResults.DataSource = highlightBoxData;
            highlightResults.DisplayMember = "displayString";
            highlightResults.ValueMember = "readingId";
        }

        private void searchResultSelected(object sender, EventArgs e)
        {
            if (textSearchResultsListBox.SelectedItem != null)
            {
                ViewSearchResult searchResult = new ViewSearchResult((SearchResult)textSearchResultsListBox.SelectedItem);
            }
            else
                System.Windows.Forms.MessageBox.Show("Nothing Selected!");
        }

        private void insertHighlightButton_Click(object sender, EventArgs e)
        {
            if (highlightResults.SelectedItem != null)
            {
                HighlightResult result1 = highlightResults.SelectedItem as HighlightResult;
                String insertStr = "\"" + result1.highlight + "\"";
                //insertStr = result1.reading.
                //TODO: need way of getting start character num to send to these functions
                if (project.style == "MLA")
                {
                    //insertStr += result1.reading.getMLAInline(result1.);
                }
                else if (project.style == "Chicago")
                {
                    //insertStr += result1.reading.getChicagoInline(result1.);
                }
                writingDoc.AppendText(insertStr);
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
            writing.text = writingDoc.Text;
            DatabaseInterface.updateProject(project);
        }

        public override void viewProjectSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProjectSummary projectSummary = new ProjectSummary(project, this);
        }

        private void writingDoc_TextChanged(object sender, EventArgs e)
        {
            writing.modified = true;
        }

        //public override void addDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        private List<ReadingTag> getAllTags(SqlConnection con, int projectId)
        {
            return null;
        }

        private WeightedGraph<ReadingTag> createTagGraph(int startTagId)
        {
            string str = DatabaseInterface.databaseConnectionStr;
            WeightedGraph<ReadingTag> graph;

            using (SqlConnection con = new SqlConnection(str))
            {
                Vertex<ReadingTag> startTag = null;
                List<Vertex<ReadingTag>> vertices = new List<Vertex<ReadingTag>>();
                List<WeightedEdge<ReadingTag>> edges = new List<WeightedEdge<ReadingTag>>();
                DatabaseInterface.getReadingLinks(con, false);
                List<ReadingTag> tags = DatabaseInterface.getReadingTags(null, con, false);
                int numTags = tags.Count();
                List<TagLink> tagLinks = DatabaseInterface.getReadingLinks(con, false);
                //List<List<List<int>>> table = new List<List<List<int>>>();
                List<int>[,] table = new List<int>[numTags, numTags];

                foreach (TagLink l in tagLinks)
                {
                    if (table[l.t1, l.t2] == null)
                    {
                        table[l.t1, l.t2] = new List<int>();
                    }
                    table[l.t1, l.t2].Add(l.rId);
                }

                Dictionary<string, Vertex<ReadingTag>> dick = new Dictionary<string, Vertex<ReadingTag>>();

                foreach (ReadingTag t in tags)
                {
                    Vertex<ReadingTag> v = new Vertex<ReadingTag>(t);
                    if(!dick.ContainsKey(t.tagId.ToString()))
                    {
                        dick.Add(t.tagId.ToString(), v);
                        vertices.Add(v);
                    }
                }

                for (int i = 0; i < tags.Count(); i++)
                {
                    for (int j = 0; j < tags.Count(); j++)
                    {
                        if (table[i, j] != null && table[i, j].Count() > 0)
                        {
                            //TODO: might have error here with readingIds array
                            WeightedEdge<ReadingTag> edge = new WeightedEdge<ReadingTag>(dick[i.ToString()], dick[j.ToString()], table[i, j].Count());
                            WeightedEdge<ReadingTag> edge2 = new WeightedEdge<ReadingTag>(dick[j.ToString()], dick[i.ToString()], table[i, j].Count());
                            edge.ReadingIds = table[i, j];
                            edge2.ReadingIds = table[i, j];
                            edges.Add(edge2);
                            edges.Add(edge);
                            dick[i.ToString()].AddEdge(edge);
                            dick[j.ToString()].AddEdge(edge2);
                        }
                    }
                }

                foreach(Vertex<ReadingTag> v in vertices)
                {
                    if(v.tagId == startTagId)
                    {
                        startTag = v;
                    }
                }

                graph = new WeightedGraph<ReadingTag>(vertices, edges);
                if(startTag != null)
                {
                    List<WeightedEdge<ReadingTag>> list = graph.TagFinder(startTag, new List<WeightedEdge<ReadingTag>>(), new List<Vertex<ReadingTag>>(), new List<Vertex<ReadingTag>>(), new List<WeightedEdge<ReadingTag>>());
                    Console.WriteLine(list.Count());
                    Console.WriteLine(list);
                    List<Reading> suggestedReadings = new List<Reading>();
                    foreach (WeightedEdge<ReadingTag> e in list)
                    {
                        Console.WriteLine(e.ToString());
                        foreach (int id in e.ReadingIds)
                        {
                            Reading r = DatabaseInterface.getReadings(project.projectId, con, false, id).First();
                            if (r != null && suggestedReadings.Find(x => x.readingId == id) == null)
                            {
                                suggestedReadings.Add(r);
                            }
                        }
                    }
                    suggestedReadingsList.DataSource = suggestedReadings;
                    suggestedReadingsList.DisplayMember = "title";
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Start tag not found");
                }
            }
            return graph;
        }

        private void startTagSearch_Click(object sender, EventArgs e)
        {
            ReadingTag startTag = (ReadingTag) beginningTag.SelectedItem;
            createTagGraph(startTag.tagId);
        }
    }

    public class SearchResult
    {
        public Reading reading { get; set; }
        public int readingId { get; set; }
        public int resultCount { get; set; }
        public int[] resultArray { get; set; }
        public String displayString { get; set; }
        public String searchTerm { get; set; }
        public List<HighlightResult> hResults { get; set; }

        public SearchResult(Reading r, int[] rArray, String term)
        {
            reading = r;
            readingId = reading.readingId;
            resultCount = rArray.Length;
            resultArray = rArray;
            displayString = reading.title + ": " + resultCount.ToString() + " results";
            searchTerm = term;
            hResults = new List<HighlightResult>();
        }
    }

    public class HighlightResult
    {
        public Reading reading { get; set; }
        public Highlight selectedHighlight { get; set; }
        public int readingId { get; set; }
        public int resultCount { get; set; }
        public int[] resultArray { get; set; }
        public String displayString { get; set; }
        public String searchTerm { get; set; }
        public String highlight { get; set; }
        public String authors { get; set; }

        public HighlightResult(Reading r, String text, int[] rArray, String term, Highlight h)
        {
            reading = r;
            readingId = reading.readingId;
            resultCount = rArray.Length;
            resultArray = rArray;
            highlight = text;
            displayString = "'" + highlight + "'; " + reading.title; 
            searchTerm = term;
            selectedHighlight = h;
            String str = "";
            foreach(Author a in r.authors)
            {
                str = a.last + ", ";
            }
            authors = str.Substring(0, str.Length - 2); //gets rid of ending space and comma
        }
    }
}