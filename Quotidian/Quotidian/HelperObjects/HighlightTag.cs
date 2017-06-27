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
        public String tag { get; set; }

        public HighlightTag(int id, int hId, String t)
        {
            tagId = id;
            highlightId = hId;
            tag = t;
        }
    }
}
