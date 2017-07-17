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
            //stringTest();

            graphTest();
            
        }

        public void graphTest()
        {
            Console.WriteLine("Testing Graph:");
            List<Vertex<ReadingTag>> tags = new List<Vertex<ReadingTag>>();
            List<WeightedEdge<ReadingTag>> edges = new List<WeightedEdge<ReadingTag>>();

            Vertex<ReadingTag> v1 = new Vertex<ReadingTag>(new ReadingTag(1, 1, "Science"));
            Vertex<ReadingTag> v2 = new Vertex<ReadingTag>(new ReadingTag(2, 1, "Technology"));
            Vertex<ReadingTag> v3 = new Vertex<ReadingTag>(new ReadingTag(3, 1, "Neuroscience"));
            Vertex<ReadingTag> v4 = new Vertex<ReadingTag>(new ReadingTag(4, 1, "Chemistry"));
            Vertex<ReadingTag> v5 = new Vertex<ReadingTag>(new ReadingTag(5, 1, "Physics"));

            tags.Add(v1);
            tags.Add(v2);
            tags.Add(v3);
            tags.Add(v4);
            tags.Add(v5);

            WeightedEdge<ReadingTag> e1 = new WeightedEdge<ReadingTag>(v1, v2, 5);
            WeightedEdge<ReadingTag> e2 = new WeightedEdge<ReadingTag>(v1, v3, 3);
            WeightedEdge<ReadingTag> e3 = new WeightedEdge<ReadingTag>(v3, v4, 1);
            WeightedEdge<ReadingTag> e4 = new WeightedEdge<ReadingTag>(v2, v4, 5);
            WeightedEdge<ReadingTag> e5 = new WeightedEdge<ReadingTag>(v4, v5, 2);

            edges.Add(e1);
            edges.Add(e2);
            edges.Add(e3);
            edges.Add(e4);
            edges.Add(e5);

            WeightedGraph<ReadingTag> graph = new WeightedGraph<ReadingTag>(tags, edges);
            List<WeightedEdge<ReadingTag>> list = graph.TagFinder(v1, new List<WeightedEdge<ReadingTag>>(), new List<Vertex<ReadingTag>>(), new List<Vertex<ReadingTag>>(), new List<WeightedEdge<ReadingTag>>());
            Console.WriteLine(list.Count());
            Console.WriteLine(list);
            foreach(WeightedEdge<ReadingTag> e in list)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void stringTest()
        {
            String path = @"..\\..\\warpeace.txt";
            String strToSearch = "";
            //StringSearch tester = new StringSearch();

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
            Console.WriteLine("Elapsed Time: " + StringSearch.Test(1, strToSearch, pat));

            Console.WriteLine("Using BM: ");
            Console.WriteLine("Elapsed Time: " + StringSearch.Test(2, strToSearch, pat));

            Console.WriteLine("Using KMP: ");
            Console.WriteLine("Elapsed Time: " + StringSearch.Test(3, strToSearch, pat));

            Console.WriteLine("Using RK: ");
            Console.WriteLine("Elapsed Time: " + StringSearch.Test(4, strToSearch, pat));
        }

    }
}
