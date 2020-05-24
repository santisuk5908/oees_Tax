using FinanProject_UI.UserControls;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void p11_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(p61);
            bunifuTransition1.ShowSync(p11);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(p11);
            bunifuTransition1.ShowSync(p21);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(p21);
            bunifuTransition1.ShowSync(p31);
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(p31);
            bunifuTransition1.ShowSync(p41);
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(p41);
            bunifuTransition1.ShowSync(p51);
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(p51);
            bunifuTransition1.ShowSync(p61);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebBrowser f_open = new WebBrowser();
            f_open.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TAX_Online f_open = new TAX_Online();
            f_open.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
