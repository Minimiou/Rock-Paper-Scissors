using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors
{
    public partial class MainForm : Form
    {
        Random choice = new Random();
        int opponentchoice;
        int round;
        int playerchoice;
        int player = 0;
        int opponent = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void radRock_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.rock;
            playerchoice = 1;
        }

        private void radPaper_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.paper;
            playerchoice = 2;
        }

        private void radScissors_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.scissors;
            playerchoice = 3;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //1 is rock, 2 is paper, 3 is scissors.
            round = 1;
            opponentchoice = choice.Next(1, 4);
            
            if (round == 1)
            {


                
            }

            if (opponentchoice == 1)
            {
                imgOpponent.Image = Properties.Resources.rock;
            }
            else if (opponentchoice == 2)
            {
                imgOpponent.Image = Properties.Resources.paper;
            }
            else if (opponentchoice == 3)
            {
                imgOpponent.Image = Properties.Resources.scissors;
            }
            //Rock
            if (opponentchoice == 1 && playerchoice == 1)
            {
                lblRoundPop.Text = "Draw!";
            }
            else if (opponentchoice == 1 && playerchoice == 2)
            {
                lblRoundPop.Text = "Next round!";
                player += 1;
            }
            else if (opponentchoice == 1 && playerchoice == 3)
            {
                lblRoundPop.Text = "Next round!";
                opponent += 1;
            }
            //Paper
            if (opponentchoice == 2 && playerchoice == 1)
            {
                lblRoundPop.Text = "Next round!";
                opponent += 1;
            }
            else if (opponentchoice == 2 && playerchoice == 2)
            {
                lblRoundPop.Text = "Draw!";
            }
            else if (opponentchoice == 2 && playerchoice == 3)
            {
                lblRoundPop.Text = "Next round!";
                player += 1;
            }
            //Scissors
            if (opponentchoice == 3 && playerchoice == 1)
            {
                lblRoundPop.Text = "Next round!";
                player += 1;
            }
            else if (opponentchoice == 3 && playerchoice == 2)
            {
                lblRoundPop.Text = "Next round!";
                opponent += 1;
            }
            else if (opponentchoice == 3 && playerchoice == 3)
            {
                lblRoundPop.Text = "Draw!";
            }

            if (opponent == 0 && player == 3)
            {
                lblRoundPop.Text = "You win";
                btnSubmit.Enabled = false;
            }
            else if (opponent == 1 && player == 2)
            {
                lblRoundPop.Text = "You win";
                btnSubmit.Enabled = false;
            }
            else if (opponent == 3 && player == 0)
            {
                lblRoundPop.Text = "You loose";
                btnSubmit.Enabled = false;
            }
            else if (opponent == 2 && player == 1)
            {
                lblRoundPop.Text = "You loose";
                btnSubmit.Enabled = false;
            }
            lblScoreNum.Text = $"{player} / {opponent}";
        }
    }
}
