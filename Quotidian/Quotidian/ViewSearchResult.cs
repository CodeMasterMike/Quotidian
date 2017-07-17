using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quotidian.HelperObjects;

namespace Quotidian
{
    public partial class ViewSearchResult : Form
    {
        public SearchResult searchResult { get; set; }

        public ViewSearchResult(SearchResult sr)
        {
            InitializeComponent();
            this.Show();
            searchResult = sr;
            readingTextBox.Text = searchResult.reading.text;

            foreach(int index in searchResult.resultArray)
            {
                readingTextBox.SelectionStart = index;
                readingTextBox.SelectionLength = searchResult.searchTerm.Length;
                readingTextBox.SelectionBackColor = Color.Yellow;
            }
        }

        private void ViewSearchResult_Load(object sender, EventArgs e)
        {

        }
    }
}
