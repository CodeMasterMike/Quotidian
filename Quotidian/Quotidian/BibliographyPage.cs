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
    public partial class BibliographyPage : Form
    {
        Project selectedProj;

        public BibliographyPage(Project p)
        {
            selectedProj = p;
            InitializeComponent();
            generateBib();
        }

        private void BibliographyPage_Load(object sender, EventArgs e)
        {

        }

        private void generateBib()
        {
            String text = "";

            foreach(Reading r in selectedProj.readings)
            {
                text += r.createCitation(selectedProj.style);
                text += "</br>";
            }

            generatedBib.DocumentText = text;
        }

        private void generatedBib_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
