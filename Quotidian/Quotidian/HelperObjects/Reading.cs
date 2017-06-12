using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quotidian.HelperObjects
{
    class Reading
    {
        public int readingId { get; set; }
        public int projectId { get; set; }
        public String title { get; set; }
        public String author { get; set; }
        public String text { get; set; }

        public Reading(int id, int pId, String t, String a, String txt)
        {
            readingId = id;
            projectId = pId;
            title = t;
            author = a;
            text = txt;
        }
    }
}
