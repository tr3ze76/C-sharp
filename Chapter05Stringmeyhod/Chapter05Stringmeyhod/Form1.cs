using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter05Stringmeyhod
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

        private void Button1_Click(object sender, EventArgs e)
        {
            bool flag;
            int index;
            int start;
            int howMany;
            string temp;

            lblLastIndexOf.Text = "";
            txtLength.Text = txtInput.Text.Length.ToString();
            txtToUpper.Text = txtInput.Text.ToUpper();
            txtToLower.Text = txtInput.Text.ToLower();

            index = txtInput.Text.IndexOf(txtSearchChar.Text, 0);
            lblLastIndexOf.Text = "txtInput.Text.IndexOf(\"" + txtLastChar.Text + "\") = ";
            txtSearchIndex.Text = index.ToString();

            index = txtInput.Text.LastIndexOf(txtLastChar.Text);
            lblLastIndexOf.Text = "txtInput.Text.LastIndexOf (\"" + txtLastChar.Text + "\") = ";
            txtLastIndexOf.Text = index.ToString();

            flag = int.TryParse(txtStartIndex.Text, out start);
            if (flag == false)
            {
                MessageBox.Show("Improper numeric input. Re-enter.");
                txtStartIndex.Focus();
                return;
            }
            flag = int.TryParse(txtEndIndex.Text, out howMany);
            if (flag == false)
            {
                MessageBox.Show("Improper numeric input. Re-enter.");
                txtEndIndex.Focus();
                return;
            }

            lblSubstring.Text = "txtIput.Text.Substring(" + start.ToString() + ", " + howMany.ToString() + ") =";
            txtSubStringResult.Text = txtInput.Text.Substring(start, howMany);

            temp = txtInput.Text;
            index = temp.IndexOf(txtRemove.Text);
            if (index > 0)
            {
                txtRemoveResult.Text = temp.Remove(index, txtRemove.Text.Length);
            }
            temp = txtInput.Text;
            txtReplaceResult.Text = temp.Replace(txtReplaceChars.Text, txtReplaceWith.Text);


         }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
