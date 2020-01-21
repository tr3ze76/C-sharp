using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter07ProgramTableOfSquares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
     
        private void Clear_Click(object sender, EventArgs e)
        {
            txtStart.Clear();
            txtEnd.Clear();
            lstOutput.Items.Clear();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            bool flag;
            int i;
            int j;
            int start;
            int end;
            int square;
            int nextOddInteger;
            string buff;

            flag = int.TryParse(txtStart.Text, out start);
            if (flag == false)
            {
                MessageBox.Show("Numeric data only", "Input Error");
                txtEnd.Focus();
                return;
            }

            flag = int.TryParse(txtEnd.Text, out end);
            if (flag == false)
            {
                MessageBox.Show("Numeric data only", "Input Error");
                txtStart.Focus();
                return;
            }


            square = 0;
               
                for (i = start; i <= end; i++)
                {
                    {
                        buff = string.Format("{0,5}{1,20}", i, i * i);
                        lstOutput.Items.Add(buff);
                    }
                }
                

                for (i = start; i <= end; i++)
                {
                    nextOddInteger = 1;
                    square = 0;
                    
                    for (j = 0; j < i; j++)
                    {
                        square += nextOddInteger;
                        nextOddInteger += 2;
                    }
                }

                buff = string.Format("{0,5}{1,20}", i, square);
                lstOutput.Items.Add(buff);

            
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
