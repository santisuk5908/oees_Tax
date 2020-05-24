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
    public partial class ps4 : Form
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
        void op1(int เงินจ่าย1,int บริจาดให้พรรค)
        {
            int บริจาคสถาณพยาบาลรัฐ = int.Parse(textBox2.Text);
            int บริจาคทั่วไป = int.Parse(textBox3.Text);
            int บริจาคอุทกภัย = int.Parse(textBox7.Text);
            int บริจาคกีฬา = int.Parse(textBox8.Text);
            int บริจาคสาธารณะ = int.Parse(textBox9.Text);
            int บริจาคการศึกษา = int.Parse(textBox10.Text);
            int sum;

            int เงินเดือน = int.Parse(textBox4.Text);
            int โบนัส = int.Parse(textBox5.Text);
            int รายได้อื่น = int.Parse(textBox6.Text);
            int เงินเดือนต่อปี1, เงินได้15เปอ, s3;


            เงินเดือนต่อปี1 = เงินเดือน * 12;//เงินเดือนรายปี
            s3 = เงินเดือนต่อปี1 + โบนัส + รายได้อื่น;//เงินรวมตลอดปี
            เงินได้15เปอ = (s3 * 15) / 100;

            
            if(บริจาคสถาณพยาบาลรัฐ>=0)
            {
                if(บริจาคทั่วไป >=0)
                {
                    if(บริจาคอุทกภัย>=0)
                    {
                        if(บริจาคกีฬา>=0)
                        {
                            if (บริจาคสาธารณะ >= 0)
                            {
                                if (บริจาคการศึกษา >= 0)
                                {
                                    sum = s3 - เงินจ่าย1 - (บริจาคสถาณพยาบาลรัฐ * 2) - (บริจาคทั่วไป) - (บริจาคอุทกภัย) - (บริจาคกีฬา * 2) - (บริจาคสาธารณะ * 2) - (บริจาคการศึกษา * 2)-บริจาดให้พรรค;
                                    เงินสุทธิ.Text = sum.ToString();
                                    pasee(sum);
                                }
                                else
                                {
                                    
                                    เงินรายปี.Text = "7!";
                                    ค่าใช้จ่าย.Text = "!";
                                    เงินสุทธิ.Text = "!";
                                    ภาษีที่ต้องจ่าย.Text = "!";
                                }
                            }
                            else
                            {
                                
                                เงินรายปี.Text = "6!";
                                ค่าใช้จ่าย.Text = "!";
                                เงินสุทธิ.Text = "!";
                                ภาษีที่ต้องจ่าย.Text = "!";
                            }
                        }
                        else
                        {

                           
                            เงินรายปี.Text = "5!";
                            ค่าใช้จ่าย.Text = "!";
                            เงินสุทธิ.Text = "!";
                            ภาษีที่ต้องจ่าย.Text = "!";
                        }
                    }
                    else
                    {
                        
                        เงินรายปี.Text = "4!";
                        ค่าใช้จ่าย.Text = "!";
                        เงินสุทธิ.Text = "!";
                        ภาษีที่ต้องจ่าย.Text = "!";
                    }
                }
                else
                {
                    
                    เงินรายปี.Text = "3!";
                    ค่าใช้จ่าย.Text = "!";
                    เงินสุทธิ.Text = "!";
                    ภาษีที่ต้องจ่าย.Text = "!";
                }
            }
            else
            {
                
                เงินรายปี.Text = "2!";
                ค่าใช้จ่าย.Text = "!";
                เงินสุทธิ.Text = "!";
                ภาษีที่ต้องจ่าย.Text = "!";
            }

        }
        void op(int เงินจ่าย1,int บริจาดให้พรรค)//ฟังก์ชันเงินเดือน+เงินจ่าย
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
            op1(เงินจ่าย1,บริจาดให้พรรค);
        }
        public ps4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int เงินเดือน = int.Parse(textBox4.Text);
            int โบนัส = int.Parse(textBox5.Text);
            int รายได้อื่น = int.Parse(textBox6.Text);
            int เงินเดือนต่อปี1, เงินจ่าย1, เงินได้15เปอ, s3, sum;
            int บริจาดให้พรรค = int.Parse(textBox1.Text);

            เงินเดือนต่อปี1 = เงินเดือน * 12;//เงินเดือนรายปี
            s3 = เงินเดือนต่อปี1 + โบนัส + รายได้อื่น;//เงินรวมตลอดปี
            เงินจ่าย1 = (s3 * 50) / 100;
            เงินได้15เปอ = (s3 * 15) / 100;
            
            if (เงินจ่าย1 < 100001 && เงินจ่าย1 >= 0)
            {
                
                if(บริจาดให้พรรค<100001&&บริจาดให้พรรค>=0)
                {
                    op(เงินจ่าย1, บริจาดให้พรรค);
                }
                else if(บริจาดให้พรรค>100000)
                {
                    บริจาดให้พรรค = 100000;
                    op(เงินจ่าย1, บริจาดให้พรรค);
                }
            }
            if (เงินจ่าย1 > 100000)
            {
                เงินจ่าย1 = 100000;
                
                if (บริจาดให้พรรค < 100001 && บริจาดให้พรรค >= 0)
                {
                    op(เงินจ่าย1, บริจาดให้พรรค);
                }
                else if (บริจาดให้พรรค > 100000)
                {
                    บริจาดให้พรรค = 100000;
                    op(เงินจ่าย1, บริจาดให้พรรค);
                }
            }
            


        }

        private void ps4_Load(object sender, EventArgs e)
        {

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
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";

            

            เงินรายปี.Text = "";
            ค่าใช้จ่าย.Text = "";
            เงินสุทธิ.Text = "";
            ภาษีที่ต้องจ่าย.Text = "";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
