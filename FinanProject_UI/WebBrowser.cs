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
    public partial class WebBrowser : Form
    {
        public WebBrowser()
        {
            InitializeComponent();
        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchButt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtURL.Text))
            {
                webBrowser1.Navigate(txtURL.Text);
            }
        }

        private void txtURL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                webBrowser1.Navigate(txtURL.Text);
            }
        }

        private void backButt_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void forwardButt_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void refreshButt_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void WebBrowser_Load(object sender, EventArgs e)
        {

        }
    }
}
