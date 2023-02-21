using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text+= "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text+= "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text+= "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text+= "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text+= "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text+= "/";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text+= "*";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0,textBox1.Text.Length-1);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string res =( textBox1.Text);

            string prev = "";
           string next , rs ;
            int i = 0;
            for (; i < res.Length;)
            {

                if (!checkoperation(res[i]))
                {
                    prev += res[i];
                    i++;
                }
                else
                {

                    char op = res[i];
                    i++; next = "";
                    while (checkoperation(res[i]) == false && i < res.Length)
                    {

                        next += res[i];
                           i++;
                        if (i < res.Length)
                            continue;
                        else
                            break;

                    }

                    rs = (Calc(float.Parse(prev.ToString()), op, float.Parse(next))).ToString();
                            prev = float.Parse(rs).ToString();

                }
            }
            textBox1.Text = prev.ToString();


        }
        
        bool checkoperation(char op)
        {
            if (op == '+' || op == '/' || op == '*' || op == '-')
                return true;
            else
                return false;
        }
        float Calc(float num1,char operation,float num2)
        {
            float res=0;
            switch (operation)
            {
                case '+':
                    res = num1 + num2;
                    break;
                case '-':
                    res = num1 - num2;
                    break;
                case '/':
                    res = num1 / num2;
                    break;
                case '*':
                    res = num1 * num2;
                    break;
            }
            return res;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
    }
}
