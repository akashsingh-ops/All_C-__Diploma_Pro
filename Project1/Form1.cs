﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtFirst.Text);
            int num2 = Convert.ToInt32(txtSecond.Text);
            int result = num1 + num2;
            lblResult.Text = result.ToString();
        }
    }
}
