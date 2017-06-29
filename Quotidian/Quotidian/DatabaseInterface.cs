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
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show(e.ToString());
                    con.Close();
                    return null;
                }
                con.Close();
                Project newProject = new Project(projectId, projectName);
                return newProject;
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
                    con.Close();
                    return null;
                }
                con.Close();
                return new Reading(readingId, null, projectId, title, new List<Author>(), text, "January", 1, 2000, "Pubby"); //TODO update reading db and this
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
                    con.Close();
                    return null;
                }
                con.Close();
                return new Highlight(highlightId, readingId, isQuote, charNum, charCount);
            }
        }

        public static ReadingTag createReadingTag(int readingId, String tagText)
        {
            ReadingTag tag;
            using (SqlConnection con = new SqlConnection(databaseConnectionStr))
            {
                con.Open();
                //first check database for already existing Tag text
                int? tagId = checkForTag(tagText, con);
                //if none, must create 
                if (tagId == null)
                {
                    tagId = addTagToDB(tagText, con);
                }
                //then simply add an entry to the ReadingTags table to connect the reading to the tag
                addReadingTagLinkToDB(readingId, (int)tagId, con);
                tag = new ReadingTag((int)tagId, readingId, tagText);
                con.Close();
            }
            return tag;
        }

        public static HighlightTag createHighlightTag(int highlightId, String tagText)
        {
            HighlightTag tag;
            using (SqlConnection con = new SqlConnection(databaseConnectionStr))
            {
                con.Open();
                //first check database for already existing Tag text
                int? tagId = checkForTag(tagText, con);
                //if none, must create 
                if (tagId == null)
                {
                    tagId = addTagToDB(tagText, con);
                }
                //then simply add an entry to the ReadingTags table to connect the reading to the tag
                addHighlightTagLinkToDB(highlightId, (int)tagId, con);
                tag = new HighlightTag((int)tagId, highlightId, tagText);
                con.Close();
            }
            return tag;
        }

        private static Boolean addReadingTagLinkToDB(int readingId, int tagId, SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO ReadingTags (ReadingId, TagId) output INSERTED.ReadingTagId VALUES (@ReadingId, @TagId)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@ReadingId", readingId);
            cmd.Parameters.AddWithValue("@TagId", tagId);
            try
            {
                //TODO enforce unique project name
                tagId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
                return false;
            }
            return true;
        }

        private static Boolean addHighlightTagLinkToDB(int highlightId, int tagId, SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO HighlightTags (HighlightId, TagId) output INSERTED.HighlightTagId VALUES (@HighlightId, @TagId)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@HighlightId", highlightId);
            cmd.Parameters.AddWithValue("@TagId", tagId);
            try
            {
                //TODO enforce unique project name
                tagId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
                return false;
            }
            return true;
        }

        //assumes open connection
        //returns null if something went wrong
        private static int? addTagToDB(String tagText, SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Tags (Tag) output INSERTED.TagId VALUES (@Tag)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@Tag", tagText);
            int? tagId = null;
            try
            {
                //TODO enforce unique project name
                tagId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
                return tagId;
            }
            return tagId;
        }
        //assumes open connection
        public static int? checkForTag(String tagText, SqlConnection con)
        {
            SqlCommand read = new SqlCommand("SELECT * " +
                    "FROM Tags " +
                    "WHERE Tag = '" + tagText + "'");
            read.CommandType = CommandType.Text;
            read.Connection = con;
            SqlDataReader reader = read.ExecuteReader();
            int? tagId;
            if (reader.Read())
                tagId = (int)reader["TagId"];
            else
                tagId = null;
            reader.Close();
            return tagId;
        }

        public static List<Project> getProjects()
        {
            List<Project> projects = new List<Project>();

            using (SqlConnection con = new SqlConnection(databaseConnectionStr))
            {
                con.Open();
                SqlCommand read = new SqlCommand("SELECT * FROM Projects");
                read.CommandType = CommandType.Text;
                read.Connection = con;
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
                project.readings = getReadings(project.projectId, con, true);
                //then highlights
                List<Highlight> allHighlights = getHighlights(project.projectId, null, con, true);
                foreach (Reading reading in project.readings)
                {
                    reading.readingTags = getReadingTags((int)reading.readingId, con, true);

                    foreach (Highlight highlight in allHighlights)
                    {
                        if (reading.readingId == highlight.readingId)
                        {
                            highlight.highlightTags = getHighlightTags(highlight.highlightId, con, true);
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

        public static List<Reading> getReadings(int projectId_input, SqlConnection con, Boolean conOpen)
        {
            List<Reading> readings = new List<Reading>();
            //first load readings
            String projectIdStr = projectId_input.ToString();
            SqlCommand read = new SqlCommand("SELECT * " +
                "FROM Readings " +
                "WHERE Readings.ProjectId = " + projectId_input.ToString());
            read.CommandType = CommandType.Text;
            read.Connection = con;

            if (conOpen == false)
            {
                con.Open();
            }

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
                    String style = (String)reader["Style"];
                    DateTime date = (DateTime)reader["Date"];
                    String publisher = (String)reader["Publisher"];
                    String city = (String)reader["City"];
                    int yearPublished = (int)reader["YearPublished"];

                    Reading reading = new Reading(readingId, null, projectId, title, new List<Author>(), text, "January", 1, 2000, "Pubby"); //TODO update reading db and this
                    readings.Add(reading);
                }
            }
            reader.Close();
            if (conOpen == false)
            {
                con.Close();
            }
            return readings;
        }

        public static List<Writing> getWritings(int projectId_input, SqlConnection con, Boolean conOpen)
        {
            List<Writing> writings = new List<Writing>();
            //first load writing
            String projectIdStr = projectId_input.ToString();
            SqlCommand read = new SqlCommand("SELECT * " +
                "FROM Writings " +
                "WHERE Writings.ProjectId = " + projectId_input.ToString());
            read.CommandType = CommandType.Text;

            if (conOpen == false)
            {
                con.Open();
            }

            read.Connection = con;

            SqlDataReader reader = read.ExecuteReader();
            while (reader.Read())
            {
                //int readingId = reader.GetInt32(0);
                //int projectId = reader.GetInt32(1);
                int writingId = (int)reader["WritingId"];
                int projectId = (int)reader["ProjectId"];
                if (projectId == projectId_input)
                {
                    String text = (String)reader["Text"];
                    // Writing writing = new Writing(writingId, null, projectId, title, "", "", author, text, "January", 1, 2000, "Pubby"); //TODO update reading db and this
                    Writing writing = new Writing();
                    writings.Add(writing);
                }
            }
            reader.Close();
            if (conOpen == false)
            {
                con.Close();
            }
            return writings;
        }

        public static List<ReadingTag> getReadingTags(int readingId, SqlConnection con, Boolean conOpen)
        {
            List<ReadingTag> readingTags = new List<ReadingTag>();

            SqlCommand read = new SqlCommand("SELECT Tags.TagId AS TagId, Tags.Tag AS Tag " +
                "FROM Readings " +
                "LEFT JOIN ReadingTags " +
                    "ON Readings.ReadingId = ReadingTags.ReadingId " +
                "LEFT JOIN Tags " +
                    "ON ReadingTags.TagId = Tags.TagId " +
                "WHERE Readings.ReadingId = " + readingId.ToString());
            read.CommandType = CommandType.Text;
            read.Connection = con;

            if (conOpen == false)
            {
                con.Open();
            }

            SqlDataReader reader = read.ExecuteReader();
            while (reader.Read())
            {
                int tagId = reader["TagId"] as int? ?? default(int);
                if(tagId > 0)
                {
                    String tagText = (String)reader["Tag"];
                    readingTags.Add(new ReadingTag((int)tagId, readingId, tagText));
                }
            }

            reader.Close();
            if (conOpen == false)
            {
                con.Close();
            }

            return readingTags;
        }

        public static List<HighlightTag> getHighlightTags(int highlightId, SqlConnection con, Boolean conOpen)
        {
            List<HighlightTag> highlightTags = new List<HighlightTag>();

            SqlCommand read = new SqlCommand("SELECT Tags.TagId AS TagId, Tags.Tag AS Tag " +
                "FROM Highlights " +
                "LEFT JOIN HighlightTags " +
                    "ON Highlights.HighlightId = HighlightTags.HighlightId " +
                "LEFT JOIN Tags " +
                    "ON HighlightTags.TagId = Tags.TagId " +
                "WHERE Highlights.HighlightId = " + highlightId.ToString());
            read.CommandType = CommandType.Text;
            read.Connection = con;

            if (conOpen == false)
            {
                con.Open();
            }

            SqlDataReader reader = read.ExecuteReader();
            while (reader.Read())
            {
                if(reader["TagId"] != DBNull.Value)
                {
                    //int tagId = (int)reader["TagId"] as int? ?? default(int);
                    int tagId = (int)reader["TagId"];
                    String tagText = (String)reader["Tag"];
                    highlightTags.Add(new HighlightTag(tagId, highlightId, tagText));
                }
            }

            reader.Close();
            if (conOpen == false)
            {
                con.Close();
            }

            return highlightTags;
        }

        //if readingId is null, simply returns all readings for this project
        //if not null, only return highlights for specific reading
        public static List<Highlight> getHighlights(int projectId, int? readingId_input, SqlConnection con, Boolean conOpen)
        {
            List<Highlight> highlights = new List<Highlight>();
            SqlCommand read = new SqlCommand("SELECT Highlights.HighlightId AS HighlightId, Readings.ReadingId AS ReadingId, Highlights.IsQuote AS IsQuote, Highlights.CharNum AS CharNum, Highlights.CharCount AS CharCount " +
                "FROM Readings LEFT JOIN Highlights ON Readings.ReadingId = Highlights.ReadingId " +
                "WHERE Readings.ProjectId = " + projectId.ToString());
            read.CommandType = CommandType.Text;

            if (conOpen == false)
            {
                con.Open();
            }

            read.Connection = con;


            SqlDataReader reader = read.ExecuteReader();
            while (reader.Read())
            {
                if (reader["HighlightId"] != DBNull.Value)
                {
                    int highlightId = (int)reader["HighlightId"];
                    int readingId = (int)reader["ReadingId"];
                    Boolean isQuote = (Boolean)reader["IsQuote"];
                    int charNum = (int)reader["CharNum"];
                    int charCount = (int)reader["CharCount"];
                    Highlight highlight = new Highlight(highlightId, readingId, isQuote, charNum, charCount);
                    highlights.Add(highlight);
                }
            }
            reader.Close();
            if (conOpen == false)
            {
                con.Close();
            }

            return highlights;
        }
    }
}
