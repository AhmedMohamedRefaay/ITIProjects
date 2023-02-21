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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
          
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Employee> employees = new List<Employee>();
            string name = textBox1.Text;
            long phone =long.Parse( textBox2.Text);
            string date = dateTimePicker1.Value.ToString();
            dataGridView1.ColumnCount = 3;

            dataGridView1.Columns[0].Name = "Name";
            dataGridView1.Columns[1].Name = "phone";
            dataGridView1.Columns[2].Name = "BirthDate";
            employees.Add(new Employee { Name = name, phone = phone, DateBirth = date });
             
            foreach (Employee employee in employees)
                dataGridView1.Rows.Add(employee.Name, employee.phone, employee.DateBirth);

             
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string nm = textBox1.Text;
            string ph = textBox2.Text;
            string tm = dateTimePicker1.Value.ToString();
            dataGridView1.CurrentRow.Cells[0].Value = nm;
            dataGridView1.CurrentRow.Cells[1].Value = ph;

            dataGridView1.CurrentRow.Cells[2].Value = tm;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
