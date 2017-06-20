using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Quotidian.HelperObjects;

namespace Quotidian
{
    public partial class ReadingInfo : Form
    {
        public Project selectedProject;

        public ReadingInfo(Project p)
        {
            selectedProject = p;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void docTitleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            String docTitle = docTitleBox.Text;
            String authorFirst = firstBox.Text;
            String authorMiddle = middleBox.Text;
            String authorLast = lastBox.Text;
            String publisher = publisherBox.Text;
            DateTime datePublished = new DateTime();
            try
            {
                datePublished = Convert.ToDateTime(dateBox.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            String tags = tagsBox.Text;
            String month = datePublished.ToString("MMMM");
            int day = datePublished.Day;
            int year = datePublished.Year;
            var nextPage = new ReadingTextPage(docTitle, authorFirst, authorMiddle, authorLast, month, day, year, publisher, this);
            this.Hide();
            nextPage.Show();
           // Regex dateRegex = new Regex();



        }

        [STAThread]
        static void Main()
        {
            Application.Run(new OpenProject());
        }
    }
}
