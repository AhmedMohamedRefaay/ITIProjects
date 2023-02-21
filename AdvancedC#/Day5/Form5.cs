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
    public partial class Form5 : Form
    {
        Rectangle rectangle = new Rectangle(0, 0, 100, 100);
        Graphics graphics;
        bool t = false;

        public Form5()
        {
            graphics.FillRectangle(Brushes.Red, rectangle);
            InitializeComponent();
            
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            graphics = CreateGraphics();


            graphics.FillRectangle(Brushes.Red, rectangle);
        }

        private void Form5_MouseHover(object sender, EventArgs e)
        {
        
            


        }

        private void Form5_MouseLeave(object sender, EventArgs e)
        {
 
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void Form5_MouseMove(object sender, MouseEventArgs e)
        {
            t = false;
            if(t==false)
            if (e.X <= 100 && e.Y <= 100 && e.X >= 0
            && e.Y >= 0)
            {
                 
                graphics.FillRectangle(Brushes.Blue, rectangle);
            }
            else
                t = true;
          

        }
    }
}
