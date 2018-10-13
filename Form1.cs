using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfTic
{
    public partial class frmNildaTicTacToe : Form
    {
        bool whosTurnIsIt= true;
        int turnCounter = 0;

        public frmNildaTicTacToe()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button buttonForAllBoxes = (Button)sender;
            if (whosTurnIsIt)
            {
                buttonForAllBoxes.Text = "X";
                buttonForAllBoxes.BackColor = Color.HotPink;
            }
            else
            {
                buttonForAllBoxes.Text = "O";
                buttonForAllBoxes.BackColor = Color.Azure;
            }
            whosTurnIsIt = !whosTurnIsIt;
            buttonForAllBoxes.Enabled = false;
            turnCounter++;

            KeepCheckingForWinner ();
        }
        private void KeepCheckingForWinner()
        {
            bool aWinnerIsFound = false;


            if ((A1btnzerozero.Text == A2btnTopCenter.Text) && (A2btnTopCenter.Text == A3btnTopRight.Text) && (!A1btnzerozero.Enabled))
                aWinnerIsFound = true;
            else if ((B1btnMiddleLeft.Text == B2btnCenterMiddle.Text) && (B2btnCenterMiddle.Text == B3btnMiddleRight.Text) && (!B1btnMiddleLeft.Enabled))
                aWinnerIsFound = true;
            else if ((C1btnBottomLeft.Text == C2btnBottomCenter.Text) && (C2btnBottomCenter.Text == C3btnBottomRight.Text) && (!C1btnBottomLeft.Enabled))
                aWinnerIsFound = true;


            else if ((A1btnzerozero.Text == B1btnMiddleLeft.Text) && (B1btnMiddleLeft.Text == C1btnBottomLeft.Text) && (!A1btnzerozero.Enabled))
                aWinnerIsFound = true;
            else if ((A2btnTopCenter.Text == B2btnCenterMiddle.Text) && (B2btnCenterMiddle.Text == C2btnBottomCenter.Text) && (!A2btnTopCenter.Enabled))
                aWinnerIsFound = true;
            else if ((A3btnTopRight.Text == B3btnMiddleRight.Text) && (B3btnMiddleRight.Text == C3btnBottomRight.Text) && (!A3btnTopRight.Enabled))
                aWinnerIsFound = true;


            else if ((A1btnzerozero.Text == B2btnCenterMiddle.Text) && (B2btnCenterMiddle.Text == C3btnBottomRight.Text) && (!A1btnzerozero.Enabled))
                aWinnerIsFound = true;
            else if ((A3btnTopRight.Text == B2btnCenterMiddle.Text) && (B2btnCenterMiddle.Text == C1btnBottomLeft.Text) && (!A3btnTopRight.Enabled))
                aWinnerIsFound = true;


            if (aWinnerIsFound)
            {
                Disable_Button();

                string announceWinner = "";
                if (whosTurnIsIt)
                    announceWinner = "O";
                else
                    announceWinner = "X";

                MessageBox.Show("Nilda Calls "+ announceWinner + " is the Winner!", "Tic Tac Toe");
            }
            else
            {
                if (turnCounter == 9)
                    MessageBox.Show("Nilda Laughed at YOU\n\n You Lose, Even Steven!", "Tic Tac Toe");
            }
        }
        private void Disable_Button()
        {

            foreach (Control objectallBoxesControls in Controls)
            {
                try
                { 
                Button buttonForAllBoxes = (Button)objectallBoxesControls;
                if (buttonForAllBoxes.Text != "New Game" && buttonForAllBoxes.Text != "Exit")
                {

                   buttonForAllBoxes.Enabled = false;
                }
            }
                catch { }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nilda Laughs at you! \n\nWho doesn't know how to play Tic Tac Toe?");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nilda's Tic Tac Toe - Mac 109 - December 2017");
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            whosTurnIsIt = true;
            turnCounter = 0;

            foreach (Control objectallBoxesControls in Controls)
            {
                try
                { 
                Button buttonForAllBoxes = (Button)objectallBoxesControls;
                if (buttonForAllBoxes.Text != "New Game" && buttonForAllBoxes.Text != "Exit")
                {
                    buttonForAllBoxes.Enabled = true;
                    buttonForAllBoxes.Text = "";
                    buttonForAllBoxes.BackColor = System.Drawing.Color.Pink;
                    buttonForAllBoxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    buttonForAllBoxes.ForeColor = System.Drawing.Color.Cyan;
                    buttonForAllBoxes.UseVisualStyleBackColor = false;
                }
                }
                catch { }
            }
        }

        private void frmNildaTicTacToe_Load(object sender, EventArgs e)
        {

        }
    }
}