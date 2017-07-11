using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quotidian.HelperObjects
{
    public class Author
    {
        public int authorId { get; set; }
        public int readingId { get; set; }
        public String first { get; set; }
        public String middle { get; set; }
        public String last { get; set; }
        public bool modified { get; set; }

        public Author(int id, int rId, String f, String m, String l)
        {
            authorId = id;
            readingId = rId;
            first = f;
            middle = m;
            last = l;
            modified = false;
        }

        //This function doesnt account for a missing first or last name
        //Can be expanded in the future to do so
        public String formatName()
        {
            String name = "";
            if (middle == null)
            {
                name += last + ", " + first + ".";
            }
            else
            {
                name += last + ", " + first + " " + middle + ".";
            }
            return name;
        }

        public String toString()
        {
            return first + " " + middle + " " + last;
        }
    }
}
