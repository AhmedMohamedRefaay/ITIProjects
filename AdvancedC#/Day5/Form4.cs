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
    public partial class Form4 : Form
    {
        bool t = true;
        List<Rectangle> rectangles = new List<Rectangle>();
        Rectangle rectangle;
        public Form4()
        {
            InitializeComponent();
            t = false;
           
        }







        private void Form4_MouseMove_1(object sender, MouseEventArgs e)
        {
           
            if (t == false)
            {
                Graphics graphics = CreateGraphics();

                rectangle = new Rectangle(e.X, e.Y, 20, 20);
                graphics.FillRectangle(Brushes.Red, rectangle);
                rectangles.Add(rectangle);
            }
        }

        private void Form4_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            foreach (var item in rectangles)
            {
                graphics.FillRectangle(Brushes.Red, item);

            }
        }

        private void Form4_MouseClick(object sender, MouseEventArgs e)
        {
            
                t = true;
                Graphics graphics = CreateGraphics();

                rectangle = new Rectangle(e.X, e.Y, 20, 20);
                graphics.FillRectangle(Brushes.White, rectangle);
                rectangles.Add(rectangle);
           

        }

        

        private void Form4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
 
            t = false;
        }
    }
}
