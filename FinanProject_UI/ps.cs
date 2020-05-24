using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanProject_UI
{
    public partial class ps : Form
    {
        public ps()
        {
            InitializeComponent();
        }

        private void searchButt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtURL.Text))
            {
                webBrowser3.Navigate(txtURL.Text);
            }
        }

        private void txtURL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                webBrowser3.Navigate(txtURL.Text);
            }
        }

        private void refreshButt_Click(object sender, EventArgs e)
        {
            webBrowser3.Refresh();
        }

        private void forwardButt_Click(object sender, EventArgs e)
        {
            webBrowser3.GoForward();
        }

        private void backButt_Click(object sender, EventArgs e)
        {
            webBrowser3.GoBack();
        }

        private void ps_Load(object sender, EventArgs e)
        {

        }
    }
}
