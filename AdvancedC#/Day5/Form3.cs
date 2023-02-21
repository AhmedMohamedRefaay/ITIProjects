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
    public partial class Form3 : Form
    {
        List<string> list { set; get; }
        List<string> lab1 = new List<string>();
        List<string> lab2 = new List<string>();
        List<string> lab3 = new List<string>();

        
        public Form3()
        {
            
            InitializeComponent();
            list = new List<string>();
            list.Add("Lab1");
            list.Add("Lab2");
            list.Add("Lab3");
           
            comboBox1.DataSource = list;
            comboBox1.SelectedIndex = 0;
         
        }



        private void button1_Click(object sender, EventArgs e)
        {

            string combx = comboBox1.SelectedIndex.ToString();
            if (checkedListBox1.CheckedItems.Count != 0)
            {

                for (int x = checkedListBox1.CheckedItems.Count - 1; x >= 0; x--)
                {
                    string str = checkedListBox1.CheckedItems[x].ToString();

                    if (comboBox1.SelectedItem.ToString() == "Lab1")
                    {
                        lab1.Add(str);
                        checkedListBox2.Items.Add(str);

                    }

                    else if (comboBox1.SelectedItem.ToString() == "Lab2")
                    {
                        lab2.Add(str);
                        checkedListBox2.Items.Add(str);

                    }

                    else if (comboBox1.SelectedItem.ToString() == "Lab3")
                    {
                        lab3.Add(str);
                        checkedListBox2.Items.Add(str);

                    }
                }

                
                for (int x = checkedListBox1.Items.Count - 1; x >= 0; x--)
            {

               if (checkedListBox1.GetItemChecked(x))

                    checkedListBox1.Items.Remove(checkedListBox1.Items[x]);


            }

            } 

        }




        private void button2_Click(object sender, EventArgs e)
        {
           


            for (int x = checkedListBox1.Items.Count - 1; x >= 0; x--)
            {
                string str = checkedListBox1.Items[x].ToString();

                if (comboBox1.SelectedItem.ToString() == "Lab1")
                {
                    lab1.Add(str);
                    checkedListBox2.Items.Add(str);

                }

                else if (comboBox1.SelectedItem.ToString() == "Lab2")
                {
                    lab2.Add(str);
                    checkedListBox2.Items.Add(str);

                }

                else if (comboBox1.SelectedItem.ToString() == "Lab3")
                {
                    lab3.Add(str);
                    checkedListBox2.Items.Add(str);

                }
            }


            for (int x = checkedListBox1.Items.Count - 1; x >= 0; x--)
            {



                checkedListBox1.Items.Remove(checkedListBox1.Items[x]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkedListBox2.CheckedItems.Count != 0)
            {

                for (int x = checkedListBox2.CheckedItems.Count - 1; x >= 0; x--)
                {
                    string str = checkedListBox2.CheckedItems[x].ToString();

                    if (comboBox1.SelectedItem.ToString() == "Lab1")
                    {
                        lab1.Remove(str);
                        checkedListBox1.Items.Add(str);

                    }

                    else if (comboBox1.SelectedItem.ToString() == "Lab2")
                    {
                        lab2.Remove(str);
                        checkedListBox1.Items.Add(str);

                    }

                    else if (comboBox1.SelectedItem.ToString() == "Lab3")
                    {
                        lab3.Remove(str);
                        checkedListBox1.Items.Add(str);

                    }
                }


                for (int x = checkedListBox2.Items.Count - 1; x >= 0; x--)
                {

                    if (checkedListBox2.GetItemChecked(x))

                        checkedListBox2.Items.Remove(checkedListBox2.Items[x]);


                }

            }

        } 
        private void button4_Click(object sender, EventArgs e)
        {

            string combx = comboBox1.SelectedIndex.ToString();


            for (int x = checkedListBox2.Items.Count - 1; x >= 0; x--)
            {
                string str = checkedListBox2.Items[x].ToString();

                if (comboBox1.SelectedItem.ToString() == "Lab1")
                {
                    lab1.Remove(str);
                    checkedListBox1.Items.Add(str);

                }

                else if (comboBox1.SelectedItem.ToString() == "Lab2")
                {
                    lab2.Remove(str);
                    checkedListBox1.Items.Add(str);

                }

                else if (comboBox1.SelectedItem.ToString() == "Lab3")
                {
                    lab3.Remove(str);
                    checkedListBox1.Items.Add(str);

                }
            }


            for (int x = checkedListBox2.Items.Count - 1; x >= 0; x--)
            {



                checkedListBox2.Items.Remove(checkedListBox2.Items[x]);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MessageBox.Show(comboBox1.SelectedItem.ToString());
            checkedListBox2.Items.Clear();

            if (comboBox1.SelectedItem.ToString() == "Lab1")
            {
                for (int i=0;i<lab1.Count;i++)
                {
                    if (comboBox1.SelectedItem.ToString() == "Lab1")
                    {
                        if (lab1 != null)
                            checkedListBox2.Items.Add(lab1[i]);

                    }
                }
            }
           else if (comboBox1.SelectedItem.ToString() == "Lab2")
            {
                for (int i = 0; i < lab2.Count; i++)
                {
                    
                        if (lab2 != null)
                            checkedListBox2.Items.Add(lab2[i]);

                    
                }
            }

          else  if (comboBox1.SelectedItem.ToString() == "Lab3")
            {
                for (int i = 0; i < lab3.Count; i++)
                {
                    
                        if (lab3 != null)
                            checkedListBox2.Items.Add(lab3[i]);

                    
                }
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            
            

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
