using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.DataSource = typeof(Color).GetProperties()
                 .Where(x => x.PropertyType == typeof(Color))
                  .Select(x => x.GetValue(null)).ToList();

            List<string> fonts = new List<string>();

            fonts.Add("Cambria");

            fonts.Add("Arial");
            fonts.Add("Times New Roman");
            fonts.Add("Arial");

            fonts.Add("Arial Black");
            comboBox2.DataSource = fonts;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor =(Color)comboBox1.SelectedItem;
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Font fnt = new Font(comboBox2.SelectedItem.ToString(), 9);
            textBox1.Font = fnt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
