using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTable_1805086
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string [] arr = new string[4];
            arr[0] = nametxt.Text;
            arr[1] = score1text.Text;
            arr[2] = score2txt.Text;
            arr[3] = score3txt.Text;
            ListViewItem lst = new ListViewItem(arr);
            listView1.Items.Add(lst);
            nametxt.Text = "";
            score1text.Text = "";
            score2txt.Text = "";
            score3txt.Text = "";




        }

        private void score2txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
