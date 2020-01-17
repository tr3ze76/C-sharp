using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROCKPAPERSCISSORS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int pick;
        public string Rules(int player1, int CPU)
        {
            if (player1 == 1 && CPU == 2)
            {
                return "CPU WINS CPU CHOOSE PAPER PLAYER1 CHOOSE ROCK";
            }

            if (CPU == 1 && player1 == 2)
            {
                return "PLAYER1 WINS PLAYER1 CHOOSE PAPER CPU CHOOSE ROCK";
            }
            if (player1 == 2 && CPU == 3)
            {
                return "CPU WINS CPU CHOOSE SCISSORS PLAYER1 CHOOSE PAPER";
            }
            if (player1 == 3 && CPU == 2)
            {
                return "PLAYER1 WINS PLAYER1 CHOOSE SCISSORS CPU CHOOSE PAPER";
            }
            if (player1 == 1 && CPU == 3)
            {
                return "PLAYER1 WINS PLAYER1 CHOOSE ROCK CPU CHOOSE SCISSORS";
            }
            if (player1 == 3 && CPU == 1)
            {
                return "CPU WINS CPU CHOOSE ROCK PLAYER1 CHOOSE SCISSORS";
            }
            else
            {
                return "EVEN";
            }
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

            string inputPLAYER1, inputCPU;
            int randomInt;



            

        }

        private void BtnP1Rock_Click(object sender, EventArgs e)
        {
            labelPLAYER1.Text = "Player1 shows rock";
            pick = 1;
        }

        private void Btnp2PAPER_Click(object sender, EventArgs e)
        {
            labelPLAYER1.Text = "Player1 shows paper";
            pick = 2;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            labelPLAYER1.Text = "Player1 shows scissors";
            pick = 3;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(pick.ToString());
            Random CPU = new Random();
            int CPUPick = CPU.Next(1, 4);
            
            if (CPUPick == 1)
            {
                txtCPUResult.Text = "ROCK";
            }
            else if (CPUPick == 2)
            {
                txtCPUResult.Text = "PAPER";
            }
            else
            {
                txtCPUResult.Text = "SCISSORS";
            }

            string result = Rules(pick, CPUPick);
            txtresults.Text = result.ToString();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
           
        }
    }
}
