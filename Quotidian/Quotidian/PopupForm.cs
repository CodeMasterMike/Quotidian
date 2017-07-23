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
    public partial class PopupForm : BaseForm
    {
        public PopupForm(String message)
        {
            InitializeComponent();
            messageLabel.Text = message;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
