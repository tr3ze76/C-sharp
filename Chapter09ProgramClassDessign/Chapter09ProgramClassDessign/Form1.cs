using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter09ProgramClassDessign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        
private void Button1_Click(object sender, EventArgs e)
        {
            bool flag;
            int year;
            int leap;
            clsDates myDate = new clsDates();

            flag = int.TryParse(txtYear.Text, out year);
            if (flag == false)
            {
                MessageBox.Show("bigit characters only in YYYY format.", "input Error");
                txtYear.Focus();
                return;
            }
            leap = myDate.GetLeapYear(year);
            lblLeapYearResult.Text = year.ToString() + "is" + ((leap == 1) ? "" : "not") + "a leap year";lblEasterResult.Text = myDate.getEaster(year);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
