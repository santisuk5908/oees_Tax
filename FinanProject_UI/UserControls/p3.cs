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
    public partial class p3 : UserControl
    {
        public p3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ps2 f_open = new ps2();
            f_open.ShowDialog();
        }
    }
}
