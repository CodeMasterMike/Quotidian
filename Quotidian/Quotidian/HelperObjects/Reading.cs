using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quotidian.HelperObjects
{
    public class Reading
    {
        public int readingId { get; set; }
        //public int? highlightId { get; set; }
        private readonly int LPP = 60;
        private readonly int width = 100;
        public int projectId { get; set; }
        public int linesPerPage { get; set; }
        public String style { get; set; }
        public String title { get; set; }
        public List<Author> authors { get; set; }
        //public String first { get; set; }
        //public String middle { get; set; }
        //public String last { get; set; }
        public String text { get; set; }
        public String dateMonth { get; set; }
        public int dateDay { get; set; }
        public int dateYear { get; set; }
        public String publisherName { get; set; }
        
        public String sectionTitle { get; set; }
        public List<String> editors { get; set; }
        public String city { get; set; }
        public int yearPublished { get; set; }

        public List<Highlight> highlights { get; set; }
        public List<ReadingTag> readingTags { get; set; }

        public bool modified { get; set; }
        public bool deleted { get; set; }

        public Reading(int rId, int pId, String t, List<Author> auths, String txt, String month, int day, int year, String publisher, String city, String s)
        {
            readingId = rId;
            projectId = pId;
            title = t;
            authors = auths;
            text = txt;
            dateMonth = month;
            dateDay = day;
            dateYear = year;
            publisherName = publisher;
            linesPerPage = LPP;
            style = s;
            modified = false;
            deleted = false;

            highlights = new List<Highlight>();		
            readingTags = new List<ReadingTag>();
            editors = new List<String>();
        }

        public String createCitation(String s)
        {
            String c = "";

            if (s.Contains("MLA"))
            {
                c = getMLACitation();
            }
            else if (s.Contains("Chicago"))
            {
                c = getChicagoCitation();
            }
            else
            {
                c = "No Style Found";
            }

            return c;
        }

        public List<ReadingTag> getReadingTags()
        {
            return readingTags;
        }

        private String getAuthors()
        {
            String c = "";
            if (authors.Count() > 1)
            {
                c += authors.ElementAt(0).formatName(false);
                for (int i = 1; i < authors.Count() - 1; i++)
                {
                    c += ", " + authors.ElementAt(i).toString();
                }
                c += ", and " + authors.Last().toString() + ". ";
            }
            else if (authors.Count() == 1)
            {
                c += authors.ElementAt(0).formatName(false);
            }
            else
            {
                c = "No Authors Found";
            }
            c += " ";
            return c;
        }

        private String getMLACitation()
        {
            String c = "";
            c += getAuthors();
            if(sectionTitle != null)
            {
                c += "\"" + sectionTitle + ".\"";
            }
            c += "<em>" + title + "</em>.";
            if(editors.Count() > 0)
            {
                c += "Ed. ";
                foreach(String e in editors)
                {
                    c += e;
                }
            }
            c += " " + publisherName + ", " + dateYear + ".";
            c += "Print.";
            return c;
        }

        public String getChicagoCitation()
        {
            String c = "";
            c += getAuthors();
            if (sectionTitle != null)
            {
                c += "\"" + sectionTitle + ",\" ";
            }
            c += "<em>" + title + "</em>, ";

            c += "(" + publisherName + ", " + dateYear + ")";

            return c;

        }

        //MLA styling standard is currently 
        //in line: [Author, pageNum]
        //full citation: Last, First M. "Section Title." Book/Anthology. Ed. First M. Last. City: Publisher, Year Published. Page(s). Print.
        //this function returns a formatted string [Author, pageNum] to be appended onto quote
        public String getMLAInline(int charNum)
        {
            String s;

            if (authors.Count() == 1)
            {
                s = "[" + authors.First().last + ", " + (int)(charNum / (linesPerPage*width) + 1) + "]";
            }
            else if (authors.Count() > 1)
            {
                s = "[" + authors.First().last + " et al, " + (int)(charNum / (linesPerPage * width) + 1) + "]";
            }
            else
            {
                s = "No Authors Found.";
            }
            return s;
        }

        public String getChicagoInline(int charNum)
        {
            String s;

            s = "[" + readingId + "]";

            return s;
        }

        public String getDateString()
        {
            String dayStr = dateDay.ToString();
            if (dayStr.Length == 1)
                dayStr = "0" + dayStr;
            String monthStr = dateMonth;
            monthStr = Convert.ToDateTime(monthStr + " 01, 1900").Month.ToString();
            if (monthStr.Length == 1)
                monthStr = "0" + monthStr;
            String yearStr = dateYear.ToString();

            return monthStr + "/" + dayStr + "/" + yearStr;
        }
    }
}
