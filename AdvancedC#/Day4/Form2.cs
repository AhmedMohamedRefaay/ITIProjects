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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string mail = textBox2.Text;
            int count = 0;
            if (name.Length < 5)
            {
                count++;
                label3.Text = "name must contain at least 5 char";
                label3.ForeColor = Color.Red;
            }
            else
                label3.Text = "";
            if (!mail.Contains('@'))
            {
                count++;
                label4.Text = "Email must contain @";
                label4.ForeColor = Color.Red;
            }
            else
                label4.Text = "";
            if (!radioButton1.Checked && !radioButton2.Checked )
            {
                count++;
                label9.Text = "must check gender";
                label9.ForeColor = Color.Red;
            }
            else
                label9.Text = "";

            if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked)
            {
                count++;
                label7.Text = "choose at least one hoppy";
                label7.ForeColor = Color.Red;
            }
            else
            label7.Text = "";

            if (count == 0)
            {
                label8.Text = "Your Registeration is valid";
                label8.ForeColor = Color.Green;
        } }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
