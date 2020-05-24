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
    public partial class p1 : UserControl
    {
        public p1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ps f_open = new ps();
            f_open.ShowDialog();

            
        }
    }
}
