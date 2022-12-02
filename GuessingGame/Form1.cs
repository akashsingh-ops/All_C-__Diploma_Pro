//Akash Singh
//1805086_3rd Year

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        int guessednumber = 0;                         //initial some var
        static int computernumber = 0;
        static string msg;
        static int difference = 0;
        int count = 0;                              // var for count attemp


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)         //on click guess the number
        {  
            count++;
            guessednumber = Convert.ToInt32(textBox1.Text);
            if (computernumber - guessednumber < difference)
            {
                textBox1.BackColor = Color.Blue;

            }
            else
            {
                textBox1.BackColor = Color.Red;
            }
            if (guessednumber > computernumber)                               //hint code
            {

                msg = "Too High";
                textBox1.Focus();
            }
            else if (guessednumber < computernumber)
            {
                msg = "Too Low";
                textBox1.Focus();
            }
            else
            {
               
                label2.Text = count.ToString();
                msg ="YOu attemped at  "+ label2.Text+"  time"+" and Congrats You Win!!!!!!!!!!"; // show the ouput in label form and count the attemp
               
                textBox1.BackColor = Color.Green;
                btnguess.Enabled = false;
           

            }
            label2.Text = msg;


            difference = computernumber = guessednumber;
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            init();    //calling of the init method 
        }
        private void init()                      // method with some code
        {
            var rand = new Random();
            computernumber = rand.Next(1, 20);
            //computernumber = 8;
            btnguess.Enabled = true;
            textBox1.Clear();
            textBox1.BackColor = Color.White;
           label2.Text = "";
            textBox1.Focus();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            init(); // calling the method when you choose new game
        }
    }
}                         // the end
