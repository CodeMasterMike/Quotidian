using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quotidian.HelperObjects
{
    class Project
    {
        public int projectId { get; set; }
        public String name { get; set; }

        public Project(int id, String n)
        {
            projectId = id;
            name = n;
        }
    }
}
