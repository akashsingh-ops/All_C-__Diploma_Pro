//Akash Singh
//1805086_3rd_Year





using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1805086
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)   //Addition btn click
        {
            try
            {
                int input1 = Convert.ToInt32(textBox1.Text);
                int input2 = Convert.ToInt32(textBox2.Text);

                int result = input1 + input2;

                MessageBox.Show("Addition Result =" + result.ToString());
            }
            catch (Exception ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)       //Sub Button Click
        {
            try
            {
                int input1 = Convert.ToInt32(textBox1.Text);
                int input2 = Convert.ToInt32(textBox2.Text);

                int result = input1 - input2;

                MessageBox.Show("Subtraction Result =" + result.ToString());
            }
            catch (Exception ex)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)         //Multiply Button Click
        {
            try
            {
                int input1 = Convert.ToInt32(textBox1.Text);
                int input2 = Convert.ToInt32(textBox2.Text);

                int result = input1 * input2;

                MessageBox.Show("Multiplication Result =" + result.ToString());
            }
            catch (Exception ex)
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)           //Fourth One button Click
        {
            try
            {
                int input1 = Convert.ToInt32(textBox1.Text);
                int input2 = Convert.ToInt32(textBox2.Text);

                int result = input1 / input2;

                MessageBox.Show("Division Result =" + result.ToString());
            }
            catch (Exception ex)
            {

            }
        }
    }
}
