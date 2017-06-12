using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quotidian.HelperObjects
{
    class Highlight
    {
        public int highlightId { get; set; }
        public int readingId { get; set; }
        public Boolean isQuote { get; set; }
        public int charNum { get; set; }
        public int charCount { get; set; }

        public Highlight(int id, int rId, Boolean isQ, int cNum, int cCount)
        {
            highlightId = id;
            readingId = rId;
            isQuote = isQ;
            charNum = cNum;
            charCount = cCount;
        }
    }
}
