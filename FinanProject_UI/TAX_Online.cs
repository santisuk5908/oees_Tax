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
    public partial class TAX_Online : Form
    {
        public TAX_Online()
        {
            InitializeComponent();
        }

        private void searchButt_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtURL.Text))
            {
                webBrowser2.Navigate(txtURL.Text);
            }
        }

        private void txtURL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                webBrowser2.Navigate(txtURL.Text);
            }
        }

        private void refreshButt_Click(object sender, EventArgs e)
        {
            webBrowser2.Refresh();
        }

        private void backButt_Click(object sender, EventArgs e)
        {
            webBrowser2.GoBack();
        }

        private void forwardButt_Click(object sender, EventArgs e)
        {
            webBrowser2.GoForward();
        }
    }
}
