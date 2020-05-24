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
    public partial class ps5 : Form
    {
        void pasee(int sum)//ฟังก์ชัน
        {
            เงินสุทธิ.Text = sum.ToString();
            double s1;
            //เรียกใช้ pasee(sum);
            if (sum < 150001)//จ่ายภาษี0%
            {

                ภาษีที่ต้องจ่าย.Text = "0";
            }
            if (sum >= 150001 && sum < 300001)//จ่ายภาษี5%
            {

                s1 = ((sum - 150000) * 0.05);
                ภาษีที่ต้องจ่าย.Text = s1.ToString();
            }
            if (sum >= 300001 && sum < 500001)//จ่ายภาษี10%
            {

                s1 = ((sum - 300000) * (0.10)) + 7500;
                ภาษีที่ต้องจ่าย.Text = s1.ToString();
            }
            if (sum >= 500001 && sum < 750001)//จ่ายภาษี15%
            {

                s1 = ((sum - 500000) * (0.15)) + 27500;
                ภาษีที่ต้องจ่าย.Text = s1.ToString();
            }
            if (sum >= 750001 && sum < 1000001)//จ่ายภาษี20%
            {

                s1 = ((sum - 750000) * (0.20)) + 65000;
                ภาษีที่ต้องจ่าย.Text = s1.ToString();
            }
            if (sum >= 1000001 && sum < 2000001)//จ่ายภาษี25%
            {

                s1 = ((sum - 1000000) * (0.25)) + 115000;
                ภาษีที่ต้องจ่าย.Text = s1.ToString();
            }
            if (sum >= 2000001 && sum < 5000001)//จ่ายภาษี30%
            {

                s1 = ((sum - 2000000) * (0.30)) + 365000;
                ภาษีที่ต้องจ่าย.Text = s1.ToString();

            }
            if (sum >= 5000001)//จ่ายภาษี35%
            {
                s1 = (((sum - 5000000) * (0.35)) + 1265000);


                ภาษีที่ต้องจ่าย.Text = s1.ToString();
            }
        }//ฟังก์ชัน
        void love(int เงินจ่าย1, int s3,int ท่องเที่ยว)
        {
            int sum;
            int ช้อปช่วยชาติ = int.Parse(textBox2.Text);
            int ศึกษาและกีฬา = int.Parse(textBox3.Text);
            int OTOP = int.Parse(textBox7.Text);
            if(ช้อปช่วยชาติ<15001&& ช้อปช่วยชาติ>=0)
            {
                if (ศึกษาและกีฬา < 15001 && ศึกษาและกีฬา >= 0)
                {
                    if (OTOP < 15001 && OTOP >= 0)
                    {
                        sum = s3 - เงินจ่าย1 - ท่องเที่ยว - ช้อปช่วยชาติ - ศึกษาและกีฬา - OTOP;
                        pasee(sum);

                    }
                    else if (OTOP > 15000)
                    {
                        OTOP = 15000;
                        sum = s3 - เงินจ่าย1 - ท่องเที่ยว - ช้อปช่วยชาติ - ศึกษาและกีฬา - OTOP;
                        pasee(sum);
                    }
                    
                }
                else if (ศึกษาและกีฬา > 15000)
                {
                    ศึกษาและกีฬา = 15000;
                    if (OTOP < 15001 && OTOP >= 0)
                    {
                        sum = s3 - เงินจ่าย1 - ท่องเที่ยว - ช้อปช่วยชาติ - ศึกษาและกีฬา - OTOP;
                        pasee(sum);
                    }
                    else if (OTOP > 15000)
                    {
                        OTOP = 15000;
                        sum = s3 - เงินจ่าย1 - ท่องเที่ยว - ช้อปช่วยชาติ - ศึกษาและกีฬา - OTOP;
                        pasee(sum);
                    }
                    
                }
                
            }
            else if(ช้อปช่วยชาติ>15000)
            {
                ช้อปช่วยชาติ = 15000;
                if (ศึกษาและกีฬา < 15001 && ศึกษาและกีฬา >= 0)
                {
                    if (OTOP < 15001 && OTOP >= 0)
                    {
                        sum = s3 - เงินจ่าย1 - ท่องเที่ยว - ช้อปช่วยชาติ - ศึกษาและกีฬา - OTOP;
                        pasee(sum);
                    }
                    else if (OTOP > 15000)
                    {
                        OTOP = 15000;
                        sum = s3 - เงินจ่าย1 - ท่องเที่ยว - ช้อปช่วยชาติ - ศึกษาและกีฬา - OTOP;
                        pasee(sum);
                    }
                    
                }
                else if (ศึกษาและกีฬา > 15000)
                {
                    ศึกษาและกีฬา = 15000;
                    if (OTOP < 15001 && OTOP >= 0)
                    {
                        sum = s3 - เงินจ่าย1 - ท่องเที่ยว - ช้อปช่วยชาติ - ศึกษาและกีฬา - OTOP;
                        pasee(sum);

                    }
                    else if (OTOP > 15000)
                    {
                        OTOP = 15000;
                        sum = s3 - เงินจ่าย1 - ท่องเที่ยว - ช้อปช่วยชาติ - ศึกษาและกีฬา - OTOP;
                        pasee(sum);
                    }
                    
                }                
            }
            

        }
        public ps5()
        {
            InitializeComponent();
        }

        private void ps5_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            if(radioButton1.Checked)
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int เงินเดือน = int.Parse(textBox4.Text);
            int โบนัส = int.Parse(textBox5.Text);
            int รายได้อื่น = int.Parse(textBox6.Text);
            int เงินเดือนต่อปี1, เงินได้15เปอ, s3, เงินจ่าย1;
            int ท่องเที่ยว = int.Parse(textBox1.Text);

            เงินเดือนต่อปี1 = เงินเดือน * 12;//เงินเดือนรายปี
            s3 = เงินเดือนต่อปี1 + โบนัส + รายได้อื่น;//เงินรวมตลอดปี
            เงินจ่าย1 = (s3 * 50) / 100;
            เงินได้15เปอ = (s3 * 15) / 100;


            เงินรายปี.Text = เงินเดือนต่อปี1.ToString();
            ค่าใช้จ่าย.Text = เงินจ่าย1.ToString();
            //เงินสุทธิ.Text =

            if (เงินจ่าย1 < 100001 && เงินจ่าย1 >= 0)
            {
                if (radioButton1.Checked)
                {
                    if (ท่องเที่ยว < 15001 && ท่องเที่ยว >= 0)
                    {
                        love(เงินจ่าย1, s3, ท่องเที่ยว);
                    }
                    else if (ท่องเที่ยว > 15000)
                    {
                        ท่องเที่ยว = 15000;
                        love(เงินจ่าย1, s3, ท่องเที่ยว);
                    }
                    

                }
                if (radioButton2.Checked)
                {
                    if (ท่องเที่ยว < 20001 && ท่องเที่ยว >= 0)
                    {
                        love(เงินจ่าย1, s3, ท่องเที่ยว);
                    }
                    else if (ท่องเที่ยว > 20000)
                    {
                        ท่องเที่ยว = 20000;
                        love(เงินจ่าย1, s3, ท่องเที่ยว);
                    }
                   
                }
                if (radioButton3.Checked)
                {
                    if (ท่องเที่ยว < 20001 && ท่องเที่ยว >= 0)
                    {
                        love(เงินจ่าย1, s3, ท่องเที่ยว);
                    }
                    else if (ท่องเที่ยว > 20000)
                    {
                        ท่องเที่ยว = 20000;
                        love(เงินจ่าย1, s3, ท่องเที่ยว);
                    }
                    
                }
                if (radioButton4.Checked)
                {
                    if (ท่องเที่ยว < 20001 && ท่องเที่ยว >= 0)
                    {
                        love(เงินจ่าย1, s3, ท่องเที่ยว);
                    }
                    else if (ท่องเที่ยว > 20000)
                    {
                        ท่องเที่ยว = 20000;
                        love(เงินจ่าย1, s3, ท่องเที่ยว);
                    }
                    
                }
                else
                {
                    คำเตือน.Text = "กรุณาเลือกประเภทเมืองท่องเที่ยว";
                }
            }
            if (เงินจ่าย1 > 100000)
            {
                เงินจ่าย1 = 100000;
                if (radioButton1.Checked)
                {
                    if (ท่องเที่ยว < 15001 && ท่องเที่ยว >= 0)
                    {
                        love(เงินจ่าย1, s3, ท่องเที่ยว);
                    }
                    else if (ท่องเที่ยว > 15000)
                    {
                        ท่องเที่ยว = 15000;
                        love(เงินจ่าย1, s3, ท่องเที่ยว);
                    }
                    

                }
                if (radioButton2.Checked)
                {
                    if (ท่องเที่ยว < 20001 && ท่องเที่ยว >= 0)
                    {
                        love(เงินจ่าย1, s3, ท่องเที่ยว);
                    }
                    else if (ท่องเที่ยว > 20000)
                    {
                        ท่องเที่ยว = 20000;
                        love(เงินจ่าย1, s3, ท่องเที่ยว);
                    }
                    
                }
                if (radioButton3.Checked)
                {
                    if (ท่องเที่ยว < 20001 && ท่องเที่ยว >= 0)
                    {
                        love(เงินจ่าย1, s3, ท่องเที่ยว);
                    }
                    else if (ท่องเที่ยว > 20000)
                    {
                        ท่องเที่ยว = 20000;
                        love(เงินจ่าย1, s3, ท่องเที่ยว);
                    }
                    
                }
                if (radioButton4.Checked)
                {
                    if (ท่องเที่ยว < 20001 && ท่องเที่ยว >= 0)
                    {
                        love(เงินจ่าย1, s3, ท่องเที่ยว);
                    }
                    else if (ท่องเที่ยว > 20000)
                    {
                        ท่องเที่ยว = 20000;
                        love(เงินจ่าย1, s3, ท่องเที่ยว);
                    }
                    
                }
                else
                {
                    คำเตือน.Text = "กรุณาเลือกประเภทเมืองท่องเที่ยว";
                }

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            คำเตือน.Text = "";

            เงินรายปี.Text = "";
            ค่าใช้จ่าย.Text = "";
            เงินสุทธิ.Text = "";
            ภาษีที่ต้องจ่าย.Text = "";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
