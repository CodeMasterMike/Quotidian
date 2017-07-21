using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quotidian.HelperObjects
{
    public class Writing
    {
        public int writingId { get; set; }
        public int projectId { get; set; }
        public String text { get; set; }
        public bool modified { get; set; }

        public Writing(int id, int pId, String txt)
        {
            writingId = id;
            projectId = pId;
            text = txt;
        }
    }
}
