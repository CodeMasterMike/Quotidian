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
using System.IO;
using System.Data.SqlClient;
using ComponentFactory.Krypton.Toolkit;

namespace Quotidian
{
    public partial class OpenProject : BaseForm
    {
        public List<Project> projects;
        public Project selectedProject;
        public Form callingForm;

        public OpenProject(Form caller = null, Project currProj = null)
        {
            InitializeComponent();
            this.Show();
            projects = DatabaseInterface.getProjects();
            callingForm = caller;
            selectedProject = currProj;
            initializeProjectListBox();
        }

        public void initializeProjectListBox()
        {
            selectProjectListBox.DataSource = projects;
            selectProjectListBox.DisplayMember = "name";
            selectProjectListBox.ValueMember = "projectId";
        }

        private void selectProjectListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProject = (Project)((KryptonListBox)sender).SelectedItem;
        }

        private void openProjectButton_Click(object sender, EventArgs e)
        {
            if(selectedProject == null)
            {
                System.Windows.Forms.MessageBox.Show("No Project Selected!");
            }
            else
            {
                selectedProject = DatabaseInterface.loadProject(selectedProject);
                var nextPage = new ProjectSummary(selectedProject, null);
                this.Hide();
                nextPage.Show();
            }
        }

        private void newProjectButton_Click(object sender, EventArgs e)
        {
            selectedProject = DatabaseInterface.createProject(newProjectNameTextBox.Text);
            openNewProjectPage();
        }

        private void openNewProjectPage()
        {
            var nextPage = new ProjectSummary(selectedProject, null);
            this.Hide();    
            nextPage.Show();
        }

        private void Test1_Click(object sender, EventArgs e)
        {
            ////test inserting project
            Project project1 = DatabaseInterface.createProject("TestProject123");
            Project project2 = DatabaseInterface.createProject("TestProject234");
            Reading reading1 = DatabaseInterface.createReading(1, "Test Reading", "Jim Thorpe", "Jimmy T was a class act. His legend is undeniable.", "MLA", new DateTime(1990,1,1), "FunkyPub", "Rochester", 2000);
            Reading reading2 = DatabaseInterface.createReading(1, "Test Reading 2", "Jim Johnson", "Jimmy J was a class act. His legend is undeniable.", "MLA", new DateTime(1990, 1, 1), "FunkyPub", "Rochester", 2000);
            Reading reading3 = DatabaseInterface.createReading(2, "Reading Test", "Jimony Cricket", "Jimmy C was a class act. His legend is undeniable.", "MLA", new DateTime(1990, 1, 1), "FunkyPub", "Rochester", 2000);
            Author author1 = DatabaseInterface.createAuthor(1, "Jim", "Francis", "Thorpe");
            Author author2 = DatabaseInterface.createAuthor(2, "Michael", "Joseph", "McAlpin");
            ReadingTag rTag1 = DatabaseInterface.createReadingTag(1, "Science");
            ReadingTag rTag2 = DatabaseInterface.createReadingTag(1, "Biology");
            ReadingTag rTag3 = DatabaseInterface.createReadingTag(2, "Biology");
            Highlight highlight1 = DatabaseInterface.createHighlight(1, true, 1, 10);
            Highlight highlight2 = DatabaseInterface.createHighlight(1, true, 2, 10);
            Highlight highlight3 = DatabaseInterface.createHighlight(2, true, 1, 10);
            HighlightTag hTag1 = DatabaseInterface.createHighlightTag(1, "Science");
            HighlightTag hTag2 = DatabaseInterface.createHighlightTag(1, "Adventure");
            HighlightTag hTag3 = DatabaseInterface.createHighlightTag(2, "Technology");

            Project loadedProj = DatabaseInterface.loadProject(new Project(1, ""));
            Project loadedProj2 = DatabaseInterface.loadProject(new Project(2, ""));

            string str = DatabaseInterface.databaseConnectionStr;
            using (SqlConnection con = new SqlConnection(str))
            {
                WeightedGraph<ReadingTag> graph;
                List<Vertex<ReadingTag>> vertices = new List<Vertex<ReadingTag>>();
                List<WeightedEdge<ReadingTag>> edges = new List<WeightedEdge<ReadingTag>>();
                DatabaseInterface.getReadingLinks(con,false);
                List<ReadingTag> tags = DatabaseInterface.getReadingTags(null, con, false);
                int numTags = tags.Count();
                List <TagLink> tagLinks= DatabaseInterface.getReadingLinks(con, false);
                //List<List<List<int>>> table = new List<List<List<int>>>();
                List<int>[,] table = new List<int> [numTags,numTags];

                foreach(TagLink l in tagLinks)
                {
                    if(table[l.t1, l.t2] == null)
                    {
                        table[l.t1, l.t2] = new List<int>();
                    }
                    table[l.t1, l.t2].Add(l.rId);
                }

                Dictionary<string, Vertex<ReadingTag>> dick = new Dictionary<string, Vertex<ReadingTag>>();

                foreach(ReadingTag t in tags)
                {
                    Vertex<ReadingTag> v = new Vertex<ReadingTag>(t);
                    dick.Add(t.tagId.ToString(), v);
                    vertices.Add(v);
                }

                for(int i = 0; i < tags.Count(); i++)
                {
                    for(int j = 0; j < tags.Count(); j++)
                    {
                        if(table[i, j] != null && table[i, j].Count() > 0)
                        {
                            WeightedEdge<ReadingTag> edge = new WeightedEdge<ReadingTag>(dick[i.ToString()], dick[j.ToString()], table[i, j].Count());
                            edge.ReadingIds = table[i, j];
                            edges.Add(edge);

                        }
                    }
                }

                graph = new WeightedGraph<ReadingTag>(vertices, edges);


            }

            int tester = -1;

            //String Search Test
            stringTest();
            
        }

        public void stringTest()
        {
            String path = @"..\\..\\warpeace.txt";
            String strToSearch = "";
            StringSearchTest tester = new StringSearchTest();

            if (!File.Exists(path))
            {
                // Create the file.
                using (FileStream fs = File.Create(path))
                {
                    Byte[] info =
                        new UTF8Encoding(true).GetBytes("This is some text in the file.");

                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }
            }

            // Open the stream and read it back.
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    strToSearch += s;
                }
                //Console.WriteLine(strToSearch);
            }

            Console.WriteLine("Done Reading File");

            String pat = "war";

            //algorithmToTest, String, pattern
            Console.WriteLine("Using indexOf: ");
            Console.WriteLine("Elapsed Time: " + tester.Test(1, strToSearch, pat));

            Console.WriteLine("Using BM: ");
            Console.WriteLine("Elapsed Time: " + tester.Test(2, strToSearch, pat));

            Console.WriteLine("Using KMP: ");
            Console.WriteLine("Elapsed Time: " + tester.Test(3, strToSearch, pat));

            Console.WriteLine("Using RK: ");
            Console.WriteLine("Elapsed Time: " + tester.Test(4, strToSearch, pat));
        }

    }
}
