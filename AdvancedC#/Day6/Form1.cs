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
    public partial class Form1 : Form
    {
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
              form2 = new Form2();
           

            form2.evnt += App;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            form2.Show();
            

         
        }
        private void App(object sender,EventArgs eventArgs)
        {

            Font SmallFont = new Font(form2.FontName, form2.FontSize);
            textBox1.Font = SmallFont;
            textBox1.ForeColor = form2.color;
        }
    }
}
