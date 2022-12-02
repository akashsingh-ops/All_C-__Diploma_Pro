//Akash Singh
//1805086_3rd_Year
//Simple Calculator



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)    //on Click CE button
        {
            result.Text="0";

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)    //Value Click code
        {
            Button b = (Button)sender;
            Eua.Text = Eua.Text + "" + b.Text;
            if ((result.Text == "0")||(operation_pressed))
            {
                result.Clear();

            }
         
            result.Text = result.Text + b.Text;
        }

        private void Operator_Click(object sender, EventArgs e)          //Operator value code
        {
            Button b = (Button)sender;
            Eua.Text = Eua.Text + "" + b.Text;
            operation = b.Text;
            value = Double.Parse(result.Text);
            operation_pressed =true;
           // Eua.Text = value + " " + operation;

        }

        private void button05_Click(object sender, EventArgs e)         //operation performed code
        {
            
           
            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;


            }      //switch end

            value = Double.Parse(result.Text);
           
        }

        private void button25_Click(object sender, EventArgs e)
        {
            result.Clear();
            value = 0;
            Eua.Text = " ";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void CEButton(object sender, EventArgs e)
        {
            Eua.Text = "";
            result.Clear();
        }
    }
}
