using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanProject_UI.UserControls
{
    public partial class p4 : UserControl
    {
        public p4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ps3 f_open = new ps3();
            f_open.ShowDialog();
        }
    }
}
