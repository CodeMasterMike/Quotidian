using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Configuration;
using Quotidian.HelperObjects;
using System.Data;

namespace Quotidian
{
    static class DatabaseInterface
    {
        /*string str = DatabaseInterface.databaseConnectionStr;
        using (SqlConnection con = new SqlConnection(str))
        {
        }*/


        public static string databaseConnectionStr = ConfigurationManager.ConnectionStrings["Quotidian.Properties.Settings.LocalDatabaseConnectionString"].ConnectionString;

        public static void loadProjectFromDB(SqlConnection con)
        {

        }

        //returns null if project name already exists
        public static Project createProject(String projectName)
        {
            using (SqlConnection con = new SqlConnection(databaseConnectionStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Projects (Name) output INSERTED.ProjectId VALUES (@Name)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@Name", projectName);
                int projectId = -1;
                try
                {
                    //TODO enforce unique project name
                    projectId = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch(Exception e)
                {
                    System.Windows.Forms.MessageBox.Show(e.ToString());
                    return null;
                }
                con.Close();
                return new Project(projectId, projectName);
            }
        }

        //TODO update when reading class updated
        public static Reading createReading(int projectId, String title, String author, String text)
        {
            using (SqlConnection con = new SqlConnection(databaseConnectionStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Readings (ProjectId, Title, Author, Text) output INSERTED.ReadingId VALUES (@ProjectId, @Title, @Author, @Text)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@ProjectId", projectId);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Author", author);
                cmd.Parameters.AddWithValue("@Text", text);
                int readingId = -1;
                try
                {
                    readingId = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show(e.ToString());
                    return null;
                }
                con.Close();
                return new Reading(readingId, null, projectId, title, "", "", author, text, "January", 1, 2000, "Pubby"); //TODO update reading db and this
            }
        }

        public static Highlight createHighlight(int readingId, Boolean isQuote, int charNum, int charCount)
        {
            using (SqlConnection con = new SqlConnection(databaseConnectionStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Highlights (ReadingId, IsQuote, CharNum, CharCount) output INSERTED.HighlightId VALUES (@ReadingId, @IsQuote, @CharNum, @CharCount)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@ReadingId", readingId);
                cmd.Parameters.AddWithValue("@IsQuote", isQuote);
                cmd.Parameters.AddWithValue("@CharNum", charNum);
                cmd.Parameters.AddWithValue("@CharCount", charCount);
                int highlightId = -1;
                try
                {
                    highlightId = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show(e.ToString());
                    return null;
                }
                con.Close();
                return new Highlight(highlightId, readingId, isQuote, charNum, charCount); //TODO query for reading just created to get ReadingId
            }
        }

        //must be called directly after last insertion
        /*public static int getLastInsertedId(SqlConnection con)
        {
            SqlCommand read = new SqlCommand("SELECT SCOPE_IDENTITY()");
            read.CommandType = CommandType.Text;
            read.Connection = con;
            SqlDataReader reader = read.ExecuteReader();
            decimal id_dec = (decimal)reader[0];
            int id = Convert.ToInt32(id_dec);
            reader.Close();
            return id;
        }*/

        public static List<Project> getProjects()
        {
            List<Project> projects = new List<Project>();

            using (SqlConnection con = new SqlConnection(databaseConnectionStr))
            {
                con.Open();
                SqlCommand read = new SqlCommand("SELECT * FROM Projects");
                read.CommandType = CommandType.Text;
                read.Connection = con;
                con.Open();
                SqlDataReader reader = read.ExecuteReader();
                while (reader.Read())
                {
                    //int projectId = reader.GetInt32(0);
                    //string name = reader.GetString(1);
                    int projectId = (int)reader["ProjectId"];
                    string name = (String)reader["Name"];
                    Project project = new Project(projectId, name);
                    projects.Add(project);
                }
                reader.Close();
                con.Close();
            }

            return projects;
        }

        public static Project loadProject(Project project)
        {
            //first load readings
            
            using (SqlConnection con = new SqlConnection(databaseConnectionStr))
            {
                con.Open();
                //first get readings
                project.readings = getReadings(project.projectId, con);
                //then highlights
                List<Highlight> allHighlights = getHighlights(project.projectId, null, con);
                foreach(Reading reading in project.readings)
                {
                    foreach(Highlight highlight in allHighlights)
                    {
                        if(reading.readingId == highlight.readingId)
                        {
                            reading.highlights.Add(highlight);
                        }
                    }
                }
                //and now tags TODO

                con.Close();
            }
            //now load writings

            return project;
        }

        public static List<Reading> getReadings(int projectId_input, SqlConnection con)
        {
            List<Reading> readings = new List<Reading>();
            //first load readings
            SqlCommand read = new SqlCommand("SELECT * " +
                "FROM Readings" +
                "WHERE Readings.ProjectId = " + projectId_input.ToString());
            read.CommandType = CommandType.Text;
            read.Connection = con;
            con.Open();
            SqlDataReader reader = read.ExecuteReader();
            while (reader.Read())
            {
                //int readingId = reader.GetInt32(0);
                //int projectId = reader.GetInt32(1);
                int readingId = (int)reader["ReadingId"];
                int projectId = (int)reader["ProjectId"];
                if (projectId == projectId_input)
                {
                    String title = (String)reader["Title"];
                    String author = (String)reader["Author"];
                    String text = (String)reader["Text"];
                    Reading reading = new Reading(readingId, null, projectId, title, "", "", author, text, "January", 1, 2000, "Pubby"); //TODO update reading db and this
                    readings.Add(reading);
                }
            }
            reader.Close();
            con.Close();
            return readings;
        }

        //if readingId is null, simply returns all readings for this project
        //if not null, only return highlights for specific reading
        public static List<Highlight> getHighlights(int projectId, int? readingId_input, SqlConnection con)
        {
            List<Highlight> highlights = new List<Highlight>();
            SqlCommand read = new SqlCommand("SELECT Highlights.HighlightId AS HighlightId, Readings.ReadingId AS ReadingId, Highlights.IsQuote AS IsQuote, Highlights.CharNum AS CharNum, Highlights.CharCount AS CharCount" +
                "FROM Readings LEFT JOIN Highlights" +
                "WHERE Readings.ProjectId = " + projectId.ToString());
            read.CommandType = CommandType.Text;
            read.Connection = con;
            con.Open();
            SqlDataReader reader = read.ExecuteReader();
            while (reader.Read())
            {
                int highlightId = (int)reader["HighlightId"];
                int readingId = (int)reader["ReadingId"];
                Boolean isQuote = (Boolean)reader["IsQuote"];
                int charNum = (int)reader["CharNum"];
                int charCount = (int)reader["CharCount"];
                Highlight highlight = new Highlight(highlightId, readingId, isQuote, charNum, charCount);
                highlights.Add(highlight);
            }
            reader.Close();
            con.Close();

            return highlights;
        }
    }
}
