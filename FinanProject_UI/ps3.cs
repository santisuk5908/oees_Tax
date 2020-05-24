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
    

    public partial class ps3 : Form
    {
        void pasee(int sum)//ฟังก์ชัน
        {
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
        void op(int เงินจ่าย1)//ฟังก์ชันเงินเดือน+เงินจ่าย
        {
            int เงินเดือน = int.Parse(textBox4.Text);
            int โบนัส = int.Parse(textBox5.Text);
            int รายได้อื่น = int.Parse(textBox6.Text);
            int เงินเดือนต่อปี1, เงินได้15เปอ, s3;


            เงินเดือนต่อปี1 = เงินเดือน * 12;//เงินเดือนรายปี
            s3 = เงินเดือนต่อปี1 + โบนัส + รายได้อื่น;//เงินรวมตลอดปี
            เงินได้15เปอ = (s3 * 15) / 100;

            เงินรายปี.Text = เงินเดือนต่อปี1.ToString();
            ค่าใช้จ่าย.Text = เงินจ่าย1.ToString(); 
        }
        public ps3()
        {
            InitializeComponent();
        }

        private void ps3_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            textBox3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked)
            {
                
                textBox3.Enabled = true;
            }
            else
            {
                textBox3.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox2.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            

           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int เงินเดือน = int.Parse(textBox4.Text);
            int โบนัส = int.Parse(textBox5.Text);
            int รายได้อื่น = int.Parse(textBox6.Text);
            int เงินเดือนต่อปี1, เงินจ่าย1, เงินได้15เปอ, s3, sum2558, sum;

            int ดอกเบี้ยบ้าน = int.Parse(textBox1.Text);
            int บ้าน2558 = int.Parse(textBox3.Text);
            int บ้าน2562 = int.Parse(textBox2.Text);



            เงินเดือนต่อปี1 = เงินเดือน * 12;//เงินเดือนรายปี
            s3 = เงินเดือนต่อปี1 + โบนัส + รายได้อื่น;//เงินรวมตลอดปี
            เงินจ่าย1 = (s3 * 50) / 100;
            เงินได้15เปอ = (s3 * 15) / 100;

            if (เงินจ่าย1 < 100001 && เงินจ่าย1 >= 0)
            {
                op(เงินจ่าย1);
                if (ดอกเบี้ยบ้าน < 100001 && ดอกเบี้ยบ้าน >= 0)
                {
                    if (บ้าน2558 < 3000001 && บ้าน2558 >= 0)
                    {

                        if (บ้าน2562 < 200001 && บ้าน2562 >= 0)//แสดงค่าบ้าน2562
                        {
                            sum = s3 - บ้าน2562 - ดอกเบี้ยบ้าน - เงินจ่าย1;
                            เงินสุทธิ.Text = sum.ToString();
                            sum2558 = (4 * บ้าน2558) / 100;
                            ภาษี2558.Text = sum2558.ToString();
                            pasee(sum);
                        }
                        else if (บ้าน2562 < 5000001 && บ้าน2562 > 200000)//บ้าน2562 = 2แสน
                        {
                            บ้าน2562 = 200000;
                            sum = s3 - บ้าน2562 - ดอกเบี้ยบ้าน - เงินจ่าย1;
                            เงินสุทธิ.Text = sum.ToString();
                            sum2558 = (4 * บ้าน2558) / 100;
                            ภาษี2558.Text = sum2558.ToString();
                            pasee(sum);
                        }
                        else if (บ้าน2562 > 5000001)//บ้าน2562=0
                        {
                            บ้าน2562 = 0;
                            sum = s3 - บ้าน2562 - ดอกเบี้ยบ้าน - เงินจ่าย1;
                            เงินสุทธิ.Text = sum.ToString();
                            sum2558 = (4 * บ้าน2558) / 100;
                            ภาษี2558.Text = sum2558.ToString();
                            pasee(sum);
                        }


                    }
                    else if (บ้าน2558 > 3000000)
                    {
                        บ้าน2558 = 0;
                        if (บ้าน2562 < 200001 && บ้าน2562 >= 0)//แสดงค่าบ้าน2562
                        {
                            sum = s3 - บ้าน2562 - ดอกเบี้ยบ้าน - เงินจ่าย1;
                            เงินสุทธิ.Text = sum.ToString();
                            sum2558 = (4 * บ้าน2558) / 100;
                            ภาษี2558.Text = sum2558.ToString();
                            pasee(sum);
                        }
                        else if (บ้าน2562 < 5000001 && บ้าน2562 > 200000)//บ้าน2562 = 2แสน
                        {
                            sum = s3 - บ้าน2562 - ดอกเบี้ยบ้าน - เงินจ่าย1;
                            เงินสุทธิ.Text = sum.ToString();
                            sum2558 = (4 * บ้าน2558) / 100;
                            ภาษี2558.Text = sum2558.ToString();
                            pasee(sum);
                        }
                        else if (บ้าน2562 > 5000001)//บ้าน2562=0
                        {
                            บ้าน2562 = 0;
                            sum = s3 - บ้าน2562 - ดอกเบี้ยบ้าน - เงินจ่าย1;
                            เงินสุทธิ.Text = sum.ToString();
                            sum2558 = (4 * บ้าน2558) / 100;
                            ภาษี2558.Text = sum2558.ToString();
                            pasee(sum);
                        }
                    }
                }
                if (ดอกเบี้ยบ้าน > 100000)
                {
                    ดอกเบี้ยบ้าน = 100000;
                    if (บ้าน2558 < 3000001 && บ้าน2558 >= 0)
                    {

                        if (บ้าน2562 < 200001 && บ้าน2562 >= 0)//แสดงค่าบ้าน2562
                        {
                            sum = s3 - บ้าน2562 - ดอกเบี้ยบ้าน - เงินจ่าย1;
                            เงินสุทธิ.Text = sum.ToString();
                            sum2558 = (4 * บ้าน2558) / 100;
                            ภาษี2558.Text = sum2558.ToString();
                            pasee(sum);
                        }
                        else if (บ้าน2562 < 5000001 && บ้าน2562 > 200000)//บ้าน2562 = 2แสน
                        {
                            บ้าน2562 = 200000;
                            sum = s3 - บ้าน2562 - ดอกเบี้ยบ้าน - เงินจ่าย1;
                            เงินสุทธิ.Text = sum.ToString();
                            sum2558 = (4 * บ้าน2558) / 100;
                            ภาษี2558.Text = sum2558.ToString();
                            pasee(sum);
                        }
                        else if (บ้าน2562 > 5000001)//บ้าน2562=0
                        {
                            บ้าน2562 = 0;
                            sum = s3 - บ้าน2562 - ดอกเบี้ยบ้าน - เงินจ่าย1;
                            เงินสุทธิ.Text = sum.ToString();
                            sum2558 = (4 * บ้าน2558) / 100;
                            ภาษี2558.Text = sum2558.ToString();
                            pasee(sum);
                        }


                    }
                    else if (บ้าน2558 > 3000000)
                    {
                        บ้าน2558 = 0;
                        if (บ้าน2562 < 200001 && บ้าน2562 >= 0)//แสดงค่าบ้าน2562
                        {
                            sum = s3 - บ้าน2562 - ดอกเบี้ยบ้าน - เงินจ่าย1;
                            เงินสุทธิ.Text = sum.ToString();
                            sum2558 = (4 * บ้าน2558) / 100;
                            ภาษี2558.Text = sum2558.ToString();
                            pasee(sum);
                        }
                        else if (บ้าน2562 < 5000001 && บ้าน2562 > 200000)//บ้าน2562 = 2แสน
                        {
                            sum = s3 - บ้าน2562 - ดอกเบี้ยบ้าน - เงินจ่าย1;
                            เงินสุทธิ.Text = sum.ToString();
                            sum2558 = (4 * บ้าน2558) / 100;
                            ภาษี2558.Text = sum2558.ToString();
                            pasee(sum);
                        }
                        else if (บ้าน2562 > 5000001)//บ้าน2562=0
                        {
                            บ้าน2562 = 0;
                            sum = s3 - บ้าน2562 - ดอกเบี้ยบ้าน - เงินจ่าย1;
                            เงินสุทธิ.Text = sum.ToString();
                            sum2558 = (4 * บ้าน2558) / 100;
                            ภาษี2558.Text = sum2558.ToString();
                            pasee(sum);
                        }
                    }
                }
            }
            if (เงินจ่าย1 > 100000)
            {
                เงินจ่าย1 = 100000;
                op(เงินจ่าย1);
                if (ดอกเบี้ยบ้าน < 100001 && ดอกเบี้ยบ้าน >= 0)
                {
                    if (บ้าน2558 < 3000001 && บ้าน2558 >= 0)
                    {
                        sum2558 = (4 * บ้าน2558) / 100;
                        if (บ้าน2562 < 200001 && บ้าน2562 >= 0)//แสดงค่าบ้าน2562
                        {
                            sum = s3 - บ้าน2562 - ดอกเบี้ยบ้าน - เงินจ่าย1;
                            เงินสุทธิ.Text = sum.ToString();
                            sum2558 = (4 * บ้าน2558) / 100;
                            ภาษี2558.Text = sum2558.ToString();
                            pasee(sum);
                        }
                        else if (บ้าน2562 < 5000001 && บ้าน2562 > 200000)//บ้าน2562 = 2แสน
                        {
                            บ้าน2562 = 200000;
                            sum = s3 - บ้าน2562 - ดอกเบี้ยบ้าน - เงินจ่าย1;
                            เงินสุทธิ.Text = sum.ToString();
                            sum2558 = (4 * บ้าน2558) / 100;
                            ภาษี2558.Text = sum2558.ToString();
                            pasee(sum);
                        }
                        else if (บ้าน2562 > 5000001)//บ้าน2562=0
                        {
                            บ้าน2562 = 0;
                            sum = s3 - บ้าน2562 - ดอกเบี้ยบ้าน - เงินจ่าย1;
                            เงินสุทธิ.Text = sum.ToString();
                            sum2558 = (4 * บ้าน2558) / 100;
                            ภาษี2558.Text = sum2558.ToString();
                            pasee(sum);
                        }


                    }
                    else if (บ้าน2558 > 3000000)
                    {
                        บ้าน2558 = 0;
                        if (บ้าน2562 < 200001 && บ้าน2562 >= 0)//แสดงค่าบ้าน2562
                        {
                            sum = s3 - บ้าน2562 - ดอกเบี้ยบ้าน - เงินจ่าย1;
                            เงินสุทธิ.Text = sum.ToString();
                            sum2558 = (4 * บ้าน2558) / 100;
                            ภาษี2558.Text = sum2558.ToString();
                            pasee(sum);
                        }
                        else if (บ้าน2562 < 5000001 && บ้าน2562 > 200000)//บ้าน2562 = 2แสน
                        {
                            sum = s3 - บ้าน2562 - ดอกเบี้ยบ้าน - เงินจ่าย1;
                            เงินสุทธิ.Text = sum.ToString();
                            sum2558 = (4 * บ้าน2558) / 100;
                            ภาษี2558.Text = sum2558.ToString();
                            pasee(sum);
                        }
                        else if (บ้าน2562 > 5000001)//บ้าน2562=0
                        {
                            บ้าน2562 = 0;
                            sum = s3 - บ้าน2562 - ดอกเบี้ยบ้าน - เงินจ่าย1;
                            เงินสุทธิ.Text = sum.ToString();
                            sum2558 = (4 * บ้าน2558) / 100;
                            ภาษี2558.Text = sum2558.ToString();
                            pasee(sum);
                        }
                    }
                }
                if (ดอกเบี้ยบ้าน > 100000)
                {
                    ดอกเบี้ยบ้าน = 100000;
                    if (บ้าน2558 < 3000001 && บ้าน2558 >= 0)
                    {
                        sum2558 = (4 * บ้าน2558) / 100;
                        if (บ้าน2562 < 200001 && บ้าน2562 >= 0)//แสดงค่าบ้าน2562
                        {
                            sum = s3 - บ้าน2562 - ดอกเบี้ยบ้าน - เงินจ่าย1;
                            เงินสุทธิ.Text = sum.ToString();
                            sum2558 = (4 * บ้าน2558) / 100;
                            ภาษี2558.Text = sum2558.ToString();
                            pasee(sum);
                        }
                        else if (บ้าน2562 < 5000001 && บ้าน2562 > 200000)//บ้าน2562 = 2แสน
                        {
                            บ้าน2562 = 200000;
                            sum = s3 - บ้าน2562 - ดอกเบี้ยบ้าน - เงินจ่าย1;
                            เงินสุทธิ.Text = sum.ToString();
                            sum2558 = (4 * บ้าน2558) / 100;
                            ภาษี2558.Text = sum2558.ToString();
                            pasee(sum);
                        }
                        else if (บ้าน2562 > 5000001)//บ้าน2562=0
                        {
                            บ้าน2562 = 0;
                            sum = s3 - บ้าน2562 - ดอกเบี้ยบ้าน - เงินจ่าย1;
                            เงินสุทธิ.Text = sum.ToString();
                            sum2558 = (4 * บ้าน2558) / 100;
                            ภาษี2558.Text = sum2558.ToString();
                            pasee(sum);
                        }


                    }
                    else if (บ้าน2558 > 3000000)
                    {
                        บ้าน2558 = 0;
                        if (บ้าน2562 < 200001 && บ้าน2562 >= 0)//แสดงค่าบ้าน2562
                        {
                            sum = s3 - บ้าน2562 - ดอกเบี้ยบ้าน - เงินจ่าย1;
                            เงินสุทธิ.Text = sum.ToString();
                            sum2558 = (4 * บ้าน2558) / 100;
                            ภาษี2558.Text = sum2558.ToString();
                            pasee(sum);
                        }
                        else if (บ้าน2562 < 5000001 && บ้าน2562 > 200000)//บ้าน2562 = 2แสน
                        {
                            sum = s3 - บ้าน2562 - ดอกเบี้ยบ้าน - เงินจ่าย1;
                            เงินสุทธิ.Text = sum.ToString();
                            sum2558 = (4 * บ้าน2558) / 100;
                            ภาษี2558.Text = sum2558.ToString();
                            pasee(sum);
                        }
                        else if (บ้าน2562 > 5000001)//บ้าน2562=0
                        {
                            บ้าน2562 = 0;
                            sum = s3 - บ้าน2562 - ดอกเบี้ยบ้าน - เงินจ่าย1;
                            เงินสุทธิ.Text = sum.ToString();
                            sum2558 = (4 * บ้าน2558) / 100;
                            ภาษี2558.Text = sum2558.ToString();
                            pasee(sum);
                        }
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";

            เงินรายปี.Text = "";
            ค่าใช้จ่าย.Text = "";
            เงินสุทธิ.Text = "";
            ภาษีที่ต้องจ่าย.Text = "";
            ภาษี2558.Text = "";

            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
