using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quotidian.HelperObjects
{
    public class HighlightTag
    {
        public int tagId { get; set; }
        public int highlightId { get; set; }
        public int? readingId { get; set; }
        public String tag { get; set; }
        public bool modified { get; set; }

        public HighlightTag(int id, int hId, String t, int? rId = null)
        {
            tagId = id;
            highlightId = hId;
            tag = t;
            modified = false;
            readingId = rId;
        }
    }
}
