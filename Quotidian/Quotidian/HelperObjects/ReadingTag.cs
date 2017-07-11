using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quotidian.HelperObjects
{
    public class ReadingTag
    {
        public int tagId { get; set; }
        public int readingId { get; set; }
        public String tag { get; set; }
        public bool modified { get; set; }

        public ReadingTag(int id, int rId, String t)
        {
            tagId = id;
            readingId = rId;
            tag = t;
            modified = false;
        }
    }
}
