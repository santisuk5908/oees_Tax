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
    public partial class paseeAll : Form
    {
        void hue(int เงินจ่าย1)
        {
            int เงินเดือน = int.Parse(textBox4.Text);
            int โบนัส = int.Parse(textBox5.Text);
            int รายได้อื่น = int.Parse(textBox6.Text);
            int มีบุตร61 = int.Parse(numericUpDown1.Text);
            int มีบุตร = int.Parse(textBox1.Text);
            int ค่าฝากครรภ์ = int.Parse(textBox2.Text);
            int อุปการะ = int.Parse(textBox3.Text);
            int เงินเดือนต่อปี1, เงินสุทธิ1, ภาษี;
            int s1, s2, s3, s4, s5, s6, sum;


            เงินเดือนต่อปี1 = เงินเดือน * 12;//เงินเดือนรายปี
            s3 = เงินเดือนต่อปี1 + โบนัส + รายได้อื่น;//เงินรวมตลอดปี
            เงินจ่าย1 = (s3 * 50) / 100;
            s2 = 30000;
            if (radioButton1.Checked)
            {
                sum = s3 - เงินจ่าย1 - (อุปการะ * 60000) - s2 - 60000;
                เงินรายปี.Text = s3.ToString();
                ค่าใช้จ่าย.Text = เงินจ่าย1.ToString();
                เงินสุทธิ.Text = sum.ToString();


            }//พ่อแม่รวม 1 คน
            if (radioButton2.Checked)
            {
                sum = s3 - เงินจ่าย1 - (อุปการะ * 60000) - (s2 * 2) - 60000;
                เงินรายปี.Text = s3.ToString();
                ค่าใช้จ่าย.Text = เงินจ่าย1.ToString();
                เงินสุทธิ.Text = sum.ToString();
                //แสดงภาษีที่ต้องจ่ายโดยคำนวณจากเงินสุทธิ

                if (radioButton3.Checked)//พ่อแม่รวม 3 คน
                {
                    sum = s3 - เงินจ่าย1 - (อุปการะ * 60000) - (มีบุตร * 30000) - (มีบุตร61 * 60000) - (ค่าฝากครรภ์) - (s2 * 3) - 60000;
                    เงินรายปี.Text = s3.ToString();
                    ค่าใช้จ่าย.Text = เงินจ่าย1.ToString();
                    เงินสุทธิ.Text = sum.ToString();
                    //แสดงภาษีที่ต้องจ่ายโดยคำนวณจากเงินสุทธิ

                    
                }//พ่อแม่รวม 3 คน
                if (radioButton4.Checked)//พ่อแม่รวม 4 คน
                {
                    sum = s3 - เงินจ่าย1 - (อุปการะ * 60000) - (มีบุตร * 30000) - (มีบุตร61 * 60000) - (ค่าฝากครรภ์) - (s2 * 4) - 60000;
                    เงินรายปี.Text = s3.ToString();
                    ค่าใช้จ่าย.Text = เงินจ่าย1.ToString();
                    เงินสุทธิ.Text = sum.ToString();
                    //แสดงภาษีที่ต้องจ่ายโดยคำนวณจากเงินสุทธิ

                    
                }//พ่อแม่รวม 4 คน
            }//พ่อแม่รวม 2 คน
            
            if (radioButton5.Checked)//ไม่มีพ่อแม่
            {
                sum = s3 - เงินจ่าย1 - (อุปการะ * 60000) - 60000;
                เงินรายปี.Text = s3.ToString();
                ค่าใช้จ่าย.Text = เงินจ่าย1.ToString();
                เงินสุทธิ.Text = sum.ToString();
                //แสดงภาษีที่ต้องจ่ายโดยคำนวณจากเงินสุทธิ


            }//ไม่มีพ่อเเม่

        }
        public paseeAll()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int เงินเดือน = int.Parse(textBox4.Text);
            int โบนัส = int.Parse(textBox5.Text);
            int รายได้อื่น = int.Parse(textBox6.Text);
            int มีบุตร61 = int.Parse(numericUpDown1.Text);
            int มีบุตร = int.Parse(textBox1.Text);
            int ค่าฝากครรภ์ = int.Parse(textBox2.Text);
            int อุปการะ = int.Parse(textBox3.Text);
            int เงินเดือนต่อปี1, เงินจ่าย1, เงินสุทธิ1, ภาษี;
            int s1, s2, s3, s4, s5, s6, sum;


            เงินเดือนต่อปี1 = เงินเดือน * 12;//เงินเดือนรายปี
            s3 = เงินเดือนต่อปี1 + โบนัส + รายได้อื่น;//เงินรวมตลอดปี
            เงินจ่าย1 = (s3 * 50) / 100;
            if(เงินจ่าย1<=100000&&เงินจ่าย1>=0)
            {
                string a = comboBox1.SelectedIndex.ToString();
                int พ่อเเม่ = int.Parse(a);
                switch (พ่อเเม่)
                {
                    case 0:
                        hue(เงินจ่าย1);
                        break;

                    case 1:
                        hue(เงินจ่าย1);
                        break;

                    case 2:
                        hue(เงินจ่าย1);
                        break;

                    default:
                        hue(เงินจ่าย1);
                        break;

                }
            }
            if(เงินจ่าย1>100000)
            {
                string a = comboBox1.SelectedIndex.ToString();
                int พ่อเเม่ = int.Parse(a);
                switch (พ่อเเม่)
                {
                    case 0:
                        hue(เงินจ่าย1);
                        break;

                    case 1:
                        hue(เงินจ่าย1);
                        break;

                    case 2:
                        hue(เงินจ่าย1);
                        break;

                    default:
                        hue(เงินจ่าย1);
                        break;

                }
            }




        }

        private void paseeAll_Load(object sender, EventArgs e)
        {

        }
    }
}
