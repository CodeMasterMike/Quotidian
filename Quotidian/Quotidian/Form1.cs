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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void quoteBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBackColor = Color.Yellow;
            if (String.IsNullOrEmpty(richTextBox2.Text))
            {
                richTextBox2.AppendText(richTextBox1.SelectedText);
            }
            else
            {
                richTextBox2.AppendText(Environment.NewLine);
                richTextBox2.AppendText(richTextBox1.SelectedText);
            }
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBackColor = Color.White;
        }

        private void textBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBackColor = Color.LightSkyBlue;
            if (String.IsNullOrEmpty(richTextBox3.Text))
            {
                richTextBox3.AppendText(richTextBox1.SelectedText);
            }
            else
            {
                richTextBox3.AppendText(Environment.NewLine);
                richTextBox3.AppendText(richTextBox1.SelectedText);
            }


        }
    }
}
