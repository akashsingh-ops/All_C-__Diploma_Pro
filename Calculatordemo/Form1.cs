using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatordemo
{
    public partial class Form1 : Form
    {
        String Operation = "";
        Double resultvalue = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Operation = button.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Clear();
            }
            Button button = (Button)sender;
            result.Text = result.Text + button.Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }
    }
}
