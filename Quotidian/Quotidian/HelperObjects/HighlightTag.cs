using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quotidian.HelperObjects
{
    class HighlightTag
    {
        public int highlightTagId { get; set; }
        public int highlightId { get; set; }
        public String tag { get; set; }

        public HighlightTag(int id, int hId, String t)
        {
            highlightTagId = id;
            highlightId = hId;
            tag = t;
        }
    }
}
