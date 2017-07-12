using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quotidian.HelperObjects
{
    public class TagLink
    {
        public int t1 { get; set; }
        public int t2 { get; set; }
        public int rId { get; set; }

        public TagLink(int tagId1, int tagId2, int readingId)
        {
            t1 = tagId1;
            t2 = tagId2;
            rId = readingId;
        }
    }
}
