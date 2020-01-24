using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter08ProgramLettersVersion
{
    public partial class Form1 : Form
    {


        private const int MAXLETTERS = 26;
        private const int MAXCHARS = MAXLETTERS - 1;
        private const int LETTERA = 65;
       


        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            char oneLetter;
            int index;
            int i;
            int length;
            int[] count = new int[MAXLETTERS];
            string input;
           // string buff;


            length = txtInput.Text.Length;
            if (length == 0)
            {
                MessageBox.Show("you need to enter some text.", "Missing Input");
                txtInput.Focus();
                return;
            }
            input = txtInput.Text;
            input = input.ToUpper();
            for (i = 0; i < input.Length; i++)
            {
                oneLetter = input[i];
                index = oneLetter - LETTERA;
                if (index < 0 || index > MAXCHARS)
                    continue;
                count[index]++;
            }
            ListViewItem which;
            for (i = 0; i < MAXLETTERS; i++)
            {
                oneLetter = (char)(i + LETTERA);
                which = new ListViewItem(oneLetter.ToString());
                which.SubItems.Add(count[i].ToString());
                lsvOutput.Items.Add(which);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtInput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}