using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quotidian.HelperObjects
{
    class Reading
    {
        private readonly int LPP = 60;
        public int readingId { get; set; }
        public int projectId { get; set; }
        public String title { get; set; }
        public String author { get; set; }
        public String text { get; set; }
        public int linesPerPage { get; set; }
        public String style { get; set; }

        public Reading(int id, int pId, String t, String a, String txt)
        {
            readingId = id;
            projectId = pId;
            title = t;
            author = a;
            text = txt;
            linesPerPage = LPP;
            style = "MLA";
        }

        //MLA styling standard is currently 
        //in line: [Author, pageNum]
        //full citation: Last, First M. "Section Title." Book/Anthology. Ed. First M. Last. City: Publisher, Year Published. Page(s). Print.
    }
}
