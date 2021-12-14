using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResChicken
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Employee employee = new Employee();
        private void button1_Click(object sender, EventArgs e)
        {
            string item = (radioButton1.Checked) ? "chicken" : "egg";
            int quantity;
            textBox2.Text = "";
            try
            {
                quantity = Convert.ToInt32(textBox1.Text);
                label2.Text = "Egg Quality: " + employee.Incpect(employee.NewRequest(quantity, item));
            }
            catch (Exception ex)
            {
                textBox2.Text = ex.Message;
                label2.Text = "Egg Quality: ";
            }
        }

       
        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = "";
            try
            {
                label2.Text = "Egg Quality: " + employee.Incpect(employee.CopyRequest());
            }
            catch (Exception ex)
            {
                textBox2.Text = ex.Message;
                label2.Text = "Egg Quality: ";
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = "";
            try
            {
                textBox2.Text = employee.PreparedFood();
            }
            catch (Exception ex)
            {
                textBox2.Text = ex.Message;
            }

        }
    }
}

