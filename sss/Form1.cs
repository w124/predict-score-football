using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int win = 5;
            string aa = Convert.ToString(win);
            textBox1.Text = aa;
            
            label2.Text = "แมนฯ ยูไนเต็ด";
            button32.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b = Int16.Parse("7");
            
            textBox2.Text = b.ToString();
            
            label3.Text = "แมนฯ ซิตี้";
            button22.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            int t = 0, s = 0;
            if (t==s)
                label1.Text = "โปรดเลือกทีม";


            try
            {
                t = Int16.Parse(textBox1.Text);
             s = Int16.Parse(textBox2.Text);

            
                if (t > s) label1.Text = "ทีมเหย้าชนะ";
                else
                    label1.Text = "ทีมเหย้าแพ้";
                if (t == s) label1.Text = "เสมอ";
            }
            catch
            {
                MessageBox.Show("โปรดเลือกทีม",
                            "เตือนนนนนนนน!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }
            




        }

        private void button4_Click(object sender, EventArgs e)
        {
            int win = 7;
            string aa = Convert.ToString(win);
            textBox1.Text = aa;

            label2.Text = "เชลซี";
            button41.Enabled = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int b = Int16.Parse("7");

            textBox1.Text = b.ToString();

            label2.Text = "แมนฯ ซิตี้";
            button2.Enabled = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            int win = 8;
            string aa = Convert.ToString(win);
            textBox1.Text = aa;

            label2.Text = "ลิเวอร์พูล";
            button31.Enabled = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int win = 7;
            string aa = Convert.ToString(win);
            textBox1.Text = aa;

            label2.Text = "อาร์เซนอล";
            button30.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int win = 5;
            string aa = Convert.ToString(win);
            textBox1.Text = aa;

            label2.Text = "สเปอร์ส";
            button40.Enabled = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int win = 5;
            string aa = Convert.ToString(win);
            textBox1.Text = aa;

            label2.Text = "เอฟเวอร์ตัน";
            button29.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int win = 4;
            string aa = Convert.ToString(win);
            textBox1.Text = aa;

            label2.Text = "วัตฟอร์ด";
            button39.Enabled = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int win = 4;
            string aa = Convert.ToString(win);
            textBox1.Text = aa;

            label2.Text = "เบิร์นลีย์";
            button28.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int win = 4;
            string aa = Convert.ToString(win);
            textBox1.Text = aa;

            label2.Text = "เซาแธมป์ตัน";
            button38.Enabled = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int win = 3;
            string aa = Convert.ToString(win);
            textBox1.Text = aa;

            label2.Text = "เวสต์บรอมวิช";
            button27.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int win = 3;
            string aa = Convert.ToString(win);
            textBox1.Text = aa;

            label2.Text = "สโต๊ค ซิตี้";
            button37.Enabled = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int win = 3;
            string aa = Convert.ToString(win);
            textBox1.Text = aa;

            label2.Text = "บอร์นมัธ";
            button26.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int win = 2;
            string aa = Convert.ToString(win);
            textBox1.Text = aa;

            label2.Text = "เลสเตอร์ ซิตี้";
            button36.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int win = 3;
            string aa = Convert.ToString(win);
            textBox1.Text = aa;

            label2.Text = "คริสตัล พาเลซ";
            button35.Enabled = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int win = 3;
            string aa = Convert.ToString(win);
            textBox1.Text = aa;

            label2.Text = "เวสต์แฮม";
            button24.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int win = 3;
            string aa = Convert.ToString(win);
            textBox1.Text = aa;

            label2.Text = "ฮัลล์ ซิตี้";
            button34.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int win = 1;
            string aa = Convert.ToString(win);
            textBox1.Text = aa;

            label2.Text = "สวอนซี";
            button23.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int win = 1;
            string aa = Convert.ToString(win);
            textBox1.Text = aa;

            label2.Text = "ซันเดอร์แลนด์";
            button33.Enabled = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int win = 3;
            string aa = Convert.ToString(win);
            textBox1.Text = aa;

            label2.Text = "มิดเดิ้ลสโบรช์";
            button25.Enabled = false;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            int win = 8 ;
            string aa = Convert.ToString(win);
            textBox2.Text = aa;

            label3.Text = "ลิเวอร์พูล";
            button21.Enabled = false;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            int win = 7;
            string aa = Convert.ToString(win);
            textBox2.Text = aa;

            label3.Text = "เชลซี";
            button4.Enabled = false;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            int win = 7;
            string aa = Convert.ToString(win);
            textBox2.Text = aa;

            label3.Text = "อาร์เซนอล";
            button20.Enabled = false;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            int win = 5;
            string aa = Convert.ToString(win);
            textBox2.Text = aa;

            label3.Text = "สเปอร์ส";
            button5.Enabled = false;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            int win = 5;
            string aa = Convert.ToString(win);
            textBox2.Text = aa;

            label3.Text = "เอฟเวอร์ตัน";
            button19.Enabled = false;

        }

        private void button39_Click(object sender, EventArgs e)
        {
            int win = 4;
            string aa = Convert.ToString(win);
            textBox2.Text = aa;

            label3.Text = "วัตฟอร์ด";
            button6.Enabled = false;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            int win = 4;
            string aa = Convert.ToString(win);
            textBox2.Text = aa;

            label3.Text = "เบิร์นลีย์";
            button18.Enabled = false;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            int win = 4;
            string aa = Convert.ToString(win);
            textBox2.Text = aa;

            label3.Text = "เซาแธมป์ตัน";
            button7.Enabled = false;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            int win = 3;
            string aa = Convert.ToString(win);
            textBox2.Text = aa;

            label3.Text = "เวสต์บรอมวิช";
            button17.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {
            int win = 3;
            string aa = Convert.ToString(win);
            textBox2.Text = aa;

            label3.Text = "สโต๊ค ซิตี้";
            button8.Enabled = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int win = 3;
            string aa = Convert.ToString(win);
            textBox2.Text = aa;

            label3.Text = "บอร์นมัธ";
            button16.Enabled = false;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            int win = 2;
            string aa = Convert.ToString(win);
            textBox2.Text = aa;

            label3.Text = "เลสเตอร์ ซิตี้";
            
            button9.Enabled = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            int win = 3;
            string aa = Convert.ToString(win);
            textBox2.Text = aa;

            label3.Text = "มิดเดิ้ลสโบรช์";
            button15.Enabled = false;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            int win = 3;
            string aa = Convert.ToString(win);
            textBox2.Text = aa;

            label3.Text = "คริสตัล พาเลซ";
            button10.Enabled = false;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            int win = 3;
            string aa = Convert.ToString(win);
            textBox2.Text = aa;

            label3.Text = "เวสต์แฮม";
            button14.Enabled = false;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            int win = 31;
            string aa = Convert.ToString(win);
            textBox2.Text = aa;

            label3.Text = "ฮัลล์ ซิตี้";
            button11.Enabled = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            int win = 1;
            string aa = Convert.ToString(win);
            textBox2.Text = aa;

            label3.Text = "สวอนซี";
            button13.Enabled = false;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            int win = 1;
            string aa = Convert.ToString(win);
            textBox2.Text = aa;

            label3.Text = "ซันเดอร์แลนด์";
            button12.Enabled = false;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            int win = 5;
            string aa = Convert.ToString(win);
            textBox2.Text = aa;

            label3.Text = "แมนฯ ยูไนเต็ด";
             ManU.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.ResetText();
            label2.ResetText();
            label3.ResetText();
            label2.Text= "ทีมเหย้า";
            label3.Text= "ทีมเยือน";
            button2.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            button25.Enabled = true;
            button26.Enabled = true;
            button27.Enabled = true;
            button28.Enabled = true;
            button29.Enabled = true;
            button30.Enabled = true;
            button31.Enabled = true;
            button32.Enabled = true;
            button33.Enabled = true;
            button34.Enabled = true;
            button35.Enabled = true;
            button36.Enabled = true;
            button37.Enabled = true;
            button38.Enabled = true;
            button39.Enabled = true;
            button40.Enabled = true;
            button41.Enabled = true;
            

        }
    }
}
