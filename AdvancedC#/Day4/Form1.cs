using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Day4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double value = double.Parse(textBox1.Text);

            if (radioButton1.Checked)
                textBox2.Text = (value / 1000).ToString();
            if (radioButton2.Checked)
                textBox2.Text = (value * 0.000621).ToString();
            if (radioButton3.Checked)
                textBox2.Text = (value / 0.000621).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
