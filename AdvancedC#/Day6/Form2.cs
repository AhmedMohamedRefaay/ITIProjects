using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day6
{
    public partial class Form2 : Form
    {
        public event EventHandler evnt;

        public Color Colorc;
        public string FontName
        {
            
            get
            {
                return comboBox1.SelectedItem.ToString();
            }
        }
        public int FontSize {  
            get 
            
            {
                return (int)numericUpDown1.Value;
            } 
        }

        public Color color {
            get
            {
                if (radioButton1.Checked)
                    return Color.Red;
                else if (radioButton2.Checked)
                    return Color.Blue;
                else if (radioButton3.Checked)
                {
                   return Colorc;
                }

                return Color.Black;
            }
                
            }
        public Form2()
        {
            InitializeComponent();
            List<string> fonts = new List<string>();

        fonts.Add("Cambria");

            fonts.Add("Arial");
            fonts.Add("Times New Roman");
            fonts.Add("Arial");

            fonts.Add("Arial Black");
            comboBox1.DataSource = fonts;
        }
        

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (evnt != null)
                evnt.Invoke(sender,null);
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                Colorc = dialog.Color;
        }
    }
}
