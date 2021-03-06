﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quotidian.HelperObjects
{
    public class Project
    {
        public int projectId { get; set; }
        public String name { get; set; }
        public bool modified { get; set; }
        public String style { get; set; }

        public List<Reading> readings;
        public List<Writing> writings;

        public Project(int id, String n, String s)
        {
            readings = new List<Reading>();
            writings = new List<Writing>();

            projectId = id;
            name = n;
            modified = false;
            style = s;
        }

        public String getStyle()
        {
            return style;
        }
    }
}
