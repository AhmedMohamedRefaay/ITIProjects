using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day8
{
    public partial class Form1 : Form
    {
        BusinessLayer businessLayer = new BusinessLayer();
        public Form1()
        {
            InitializeComponent(); 
            comboBox1.DataSource = businessLayer.GetDepartments();
            comboBox1.DisplayMember = "Dname";
            comboBox1.ValueMember = "Dnum";

            dataGridView1.DataSource = businessLayer.GetEmplooyees();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
