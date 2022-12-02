//Akash Singh
//RollNo: 1805086
//Calculator RC1

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorRC1  
{
    public partial class Form1 : Form
    {
        //declaration of variable
        Double resultvalue = 0;
        String operationperformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)      //Button click method excecute when click on Operand
        {  
            
            if ((textBox_result.Text == "0")||(isOperationPerformed))
                textBox_result.Clear();
            isOperationPerformed = false;
            Button button=(Button)sender;
            //code for label text Showing operation 
            labelCurrentoperation.Text = labelCurrentoperation.Text + "" + button.Text; 

            if(button.Text==".")   //if statement for  vlidation of . (dot)
            {
                if (!textBox_result.Text.Contains("."))
                    textBox_result.Text = textBox_result.Text + button.Text;

            }else
            textBox_result.Text = textBox_result.Text+button.Text;

        }

        private void operator_click(object sender, EventArgs e)      //Button click method excecute when click on Operator
        { 
            Button button=(Button)sender;
            labelCurrentoperation.Text = labelCurrentoperation.Text + "" + button.Text;
            if (resultvalue != 0)
            {
                button15.PerformClick();
                operationperformed = button.Text;
               // labelCurrentoperation.Text = resultvalue + " " + operationperformed;
                isOperationPerformed = true;
            }
            else
            {
                operationperformed = button.Text;
                resultvalue = Double.Parse(textBox_result.Text);
               // labelCurrentoperation.Text = resultvalue  + " " + operationperformed;
                isOperationPerformed = true;
            }
        
        }

        private void button5_Click(object sender, EventArgs e)   //click when CE button , it clear the textBox
        {
            textBox_result.Text = "0";
            labelCurrentoperation.Text=" ";
            
        }

        private void button10_Click(object sender, EventArgs e)   //click when C button , it clear the textBox
        {
            textBox_result.Text = "0";
            resultvalue = 0;
            labelCurrentoperation.Text = " ";
        }

        private void buttonEqual(object sender, EventArgs e)    //excecute when user click on Equal Button
        {
            switch (operationperformed)          //Switch case of operation performed
            {
                case "+":
                    textBox_result.Text = (resultvalue + Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "-":
                    textBox_result.Text = (resultvalue -Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "*":
                    textBox_result.Text = (resultvalue * Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "/":
                    textBox_result.Text = (resultvalue / Double.Parse(textBox_result.Text)).ToString();
                    break;
                default:
                    break;


            }
            resultvalue = Double.Parse(textBox_result.Text);   //resultvalue store the result
          


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
//End the code
