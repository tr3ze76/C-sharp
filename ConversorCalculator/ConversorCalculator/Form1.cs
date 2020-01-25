using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorCalculator
{
    public partial class Form1 : Form
    {
        float input1;
        float input2;        
        float result;
        char oper;
        bool Length;
        bool point = false;
        bool Calculator;
        double kilometers;
        double miles;
        double kilograms;
        double pounds;
        bool mode = true;



        public Form1()
        {
            InitializeComponent();
        }

      
        private void Btn1_Click(object sender, EventArgs e)
        {
            if (mode == true)
            {
                if (txtResult.Text == "0")
                    txtResult.Clear();

                if (panelCalculator.Visible == true)
                {
                    txtResult.Text = txtResult.Text + "1";
                }



            }
            else
            {
                txtConvertFrom.Text = txtConvertFrom.Text + "1";
            }


        }
        private void Btn2_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();

            if (panelCalculator.Visible == true)
            {
                txtResult.Text = txtResult.Text + "2";
            }
        }
        
        private void Btn3_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();

            if (panelCalculator.Visible == true)
            {
                txtResult.Text = txtResult.Text + "3";
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();

            if (panelCalculator.Visible == true)
            {
                txtResult.Text = txtResult.Text + "4";
            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();

            if (panelCalculator.Visible == true)
            {
                txtResult.Text = txtResult.Text + "5";
            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();

            if (panelCalculator.Visible == true)
            {
                txtResult.Text = txtResult.Text + "6";
            }
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();

            if (panelCalculator.Visible == true)
            {
                txtResult.Text = txtResult.Text + "7";
            }
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();

            if (panelCalculator.Visible == true)
            {
                txtResult.Text = txtResult.Text + "8";
            }
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();

            if (panelCalculator.Visible == true)
            {
                txtResult.Text = txtResult.Text + "9";
            }
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
           
            if (panelCalculator.Visible == true)
            {
                txtResult.Text = txtResult.Text + "0";
            }
        }

        private void BtnDecimal_Click(object sender, EventArgs e)
        {
            if (point == false)
            if (panelCalculator.Visible == true)
            {
                txtResult.Text = txtResult.Text + ".";
            }
            point = true;
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtResult.Text, out input2))
                {

                switch (oper)
                {
                    case '+':

                        result = input1 + input2;
                        txtResult.Text = result.ToString();
                        break;
                    case '-':

                        result = input1 - input2;
                        txtResult.Text = result.ToString();
                        break;
                    case '*':

                        result = input1 * input2;
                        txtResult.Text = result.ToString();
                        break;

                    case '/':
                        result = input1 / input2;
                        txtResult.Text = result.ToString();
                        break;

                }
                

            }
        }             

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtResult.Text, out input1))
                {
                txtResult.Clear();
                            }
            oper = '+';
            point = false;          

             
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();            

        }
        private void BtnSubstract_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtResult.Text, out input1))
            {
                txtResult.Clear();
            }
            oper = '-';
            point = false;

        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtResult.Text, out input1))
            {
                txtResult.Clear();
            }
            oper = '*';
            point = false;
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtResult.Text, out input1)) ;
            {
                txtResult.Clear();

            }
            oper = '/';
            point = false;
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panelCalculator.Visible = true;
            panelConverter.Visible = false;
            mode = true;
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length == 1)
                txtResult.Text = "";
            else
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
        }          

        
        private void RdConverter_CheckedChanged(object sender, EventArgs e)
        {
            panelConverter.Visible = true;
            panelCalculator.Visible = false;
            mode = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtConvertFrom.Clear();
            txtConvertTo.Clear();
            txtConvertFrom.Clear();
            txtConvertTo.Clear();
        }       

        
        private void BtnConvert_Click(object sender, EventArgs e)
        {
            if (RKmToMl.Checked)
            {
                double i = Convert.ToDouble(txtConvertFrom.Text);
                txtConvertTo.Text = Convert.ToString(i * 0.621371);
                return;
            }
            if (MlToKm.Checked)
            {
                double i = Convert.ToDouble(txtConvertFrom.Text);
                txtConvertTo.Text = Convert.ToString(i / 0.621371);
                return;
            }
            if (KgToLbs.Checked)
            {
                double i = Convert.ToDouble(txtConvertFrom.Text);
                txtConvertTo.Text = Convert.ToString(i * 2.20462);
            }
            else
            {
                double i = Convert.ToDouble(txtConvertFrom.Text);
                txtConvertTo.Text = Convert.ToString(i / 2.20462);
            }

            
            if (RKmToMl.Checked == true)
            {
                
            }
            
            if(MlToKm.Checked == true)
            {
               
            }
            if (KgToLbs.Checked == true)
            {
               
            }
            if(LbsToKg.Checked == true)
            {
                
            }
        }

        
    }
}
