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
                SqlCommand cmd = new SqlCommand("INSERT INTO Projects (Name) VALUES (@Name)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@Name", projectName);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch(Exception e)
                {
                    return null;
                }
                return new Project(-1, projectName); //TODO query for project just created to get ProjectId
            }
        }

        public static List<Project> getProjects()
        {
            List<Project> projects = new List<Project>();

            using (SqlConnection con = new SqlConnection(databaseConnectionStr))
            {
                SqlCommand read = new SqlCommand("SELECT * FROM Projects");
                read.CommandType = CommandType.Text;
                read.Connection = con;
                con.Open();
                SqlDataReader reader = read.ExecuteReader();
                while (reader.Read())
                {
                    int projectId = reader.GetInt32(0);
                    string name = reader.GetString(1);
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
                SqlCommand read = new SqlCommand("SELECT * FROM Readings");
                read.CommandType = CommandType.Text;
                read.Connection = con;
                con.Open();
                SqlDataReader reader = read.ExecuteReader();
                while (reader.Read())
                {
                    int readingId = reader.GetInt32(0);
                    int projectId = reader.GetInt32(1);
                    if(projectId == project.projectId)
                    {
                        String title = reader.GetString(2);
                        String author = reader.GetString(3);
                        String text = reader.GetString(4);
                        Reading reading = new Reading(readingId, projectId, title, author, text);
                        project.readings.Add(reading);
                    }
                }
                reader.Close();
                con.Close();
            }
            //now load writings

            return project;
        }
    }
}
