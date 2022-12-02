//Akash Singh
//1805086
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Table_1805086
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

        private void button1_Click(object sender, EventArgs e)
        {
            string[] arr = new string[4];
            arr[0] = nametxt.Text;
            arr[1] = score1txt.Text;
            arr[2] =score2txt.Text;
            arr[3] = score3txt.Text;
            ListViewItem lst = new ListViewItem(arr);
            listView1.Items.Add(lst);
            nametxt.Text = "";
            score1txt.Text = "";
            score2txt.Text = "";
            score3txt.Text = "";

        }
    }
}
