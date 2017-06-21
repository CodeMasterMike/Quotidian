using Quotidian.HelperObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quotidian
{
    public partial class WritingPage : BaseForm
    {
        public WritingPage(Project p, Writing w)
        {
            InitializeComponent();
            project = p;
            writing = w;//new Reading(-1, -1, -1, "No Title", "First", "M.", "Last", "", "Jan.", 1, 1999, "Publisher");
            writingDoc.Text = writing.text;
        }

        public Project project;
        public Writing writing;

        //public override void addDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}
    }
}