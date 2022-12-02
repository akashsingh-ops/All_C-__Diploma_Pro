using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate_Age
{
    public partial class btnCal : Form
    {
        public btnCal()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            DateTime dateOfBirth = DateTime.Parse(dtpDOB.Text);
            int noOfDays = 0, noOfMonth = 0, noOfYear = 0;
            DateTime currentDate = DateTime.Now;
            noOfDays = currentDate.Day - dateOfBirth.Day;
            noOfMonth = currentDate.Month-dateOfBirth.Month;
            noOfYear = currentDate.Year - dateOfBirth.Year;
            //currentDate = 04 - 09 - 2020;
            //DOB=21-09-2020;
            if (noOfDays < 0)
            {
                noOfDays += DateTime.DaysInMonth(currentDate.Year, currentDate.Month);
                noOfMonth--;
            }
            if (noOfMonth < 0)
            {
                noOfMonth += 12;
                noOfYear--;


            }
            MessageBox.Show("The Age is: " +  noOfYear  + " Year " +  noOfMonth  + " Month " +  noOfDays  + " Days ");

        }
    }
}
