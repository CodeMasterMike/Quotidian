using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quotidian.HelperObjects
{
    public class Reading
    {
        public int? readingId { get; set; }
        //public int? highlightId { get; set; }
        private readonly int LPP = 60;
        public int projectId { get; set; }
        public int linesPerPage { get; set; }
        public String style { get; set; }
        public String title { get; set; }
        public String first { get; set; }
        public String middle { get; set; }
        public String last { get; set; }
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

        public Reading(int? rId, int? hId, int pId, String t, String firstName, String middleName, String lastName, String txt, String month, int day, int year, String publisher)
        {
            readingId = rId;
            //highlightId = hId;
            projectId = pId;
            title = t;
            first = firstName;
            middle = middleName;
            last = lastName;
            text = txt;
            dateMonth = month;
            dateDay = day;
            dateYear = year;
            publisherName = publisher;
            linesPerPage = LPP;
            style = "MLA";
			
			highlights = new List<Highlight>();
            editors = new List<String>();
        }

        public String createCitation()
        {
            String c = "";

            switch(style) {
                case "MLA":
                    c = getMLACitation();
                    break;
                default:
                    c = "No citation style found";
                    break;
            }

            return c;
        }

        private String getMLACitation()
        {
            String c = "";
            c += formatName();
            if(sectionTitle != null)
            {
                c += "\"" + sectionTitle + ".\"";
            }
            c += title + ".";
            if(editors.Count() > 0)
            {
                c += "Ed. ";
                foreach(String e in editors)
                {
                    c += e;
                }
            }
            if(city != null)
            {
                c += city + ": ";
            }
            c += publisherName + ", " + yearPublished + ".";
            c += "Print.";
            return c;
        }

        //This function doesnt account for a missing first or last name
        //Can be expanded in the future to do so
        private String formatName()
        {
            String name = "";
            if(middle == null)
            {
                name += last + ", " + first + ".";
            }
            else
            {
                name += last + ", " + first + " " + middle + ".";
            }
            return name;
        }

        //MLA styling standard is currently 
        //in line: [Author, pageNum]
        //full citation: Last, First M. "Section Title." Book/Anthology. Ed. First M. Last. City: Publisher, Year Published. Page(s). Print.
    }
}
