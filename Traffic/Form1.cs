

//Akash Singh
//RollNo=1805086_3rd_Year
//Lab Experiment { TRAFFIC SIGNAL}
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

namespace Traffic
{
    public partial class Form1 : Form
    {
        int count = 10;                        //var count for counting
        int converter;                          // convert to show in TextBox1 field
        
        public Form1()
        {
            InitializeComponent();
            redtoplight.Visible = true;           
            yellowlight.Visible = false;
            greenlight.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)     //Timer code
        {
            if (redtoplight.Visible == true)                     //When Red light is ON
            {
                redtoplight.Visible = false;
                yellowlight.Visible = true;
                greenlight.Visible = false;
                timer2.Stop();
                count = 10;
                timer2.Start();

            }
            else if (yellowlight.Visible == true)              //When Yellow light is ON
            {
                redtoplight.Visible = false;
                yellowlight.Visible = false;
                greenlight.Visible = true;
                timer2.Stop();
                count = 10;
                timer2.Start();

            }
            else if(greenlight.Visible==true){                  //When Green light is ON
                redtoplight.Visible = true;
                yellowlight.Visible = false;
                greenlight.Visible = false;
                timer2.Stop();
                count = 10;
                timer2.Start();

            }
          
           

        }

        private void btnstart_Click(object sender, EventArgs e)    //when click on Start button
        {
         
        }

        private void btnstop_Click(object sender, EventArgs e)    //when click on Stop button
        {
            timer1.Enabled = false;
            timer2.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)         //Time2 will start
        {
            timer1.Enabled = true;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)         //timer2 show in TextBox field 
        {
            count = count - 1;
            converter = count;
            TextBox1.Text = " 00:0"+converter.ToString();                 
        }
    }
}                                                                     //END of program


