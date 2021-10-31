using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace INF164HWAss1
{
    public partial class frmGame : Form
    {
        private int gold;
        private Tamagotchi tamagotchi;
        private GameBar gamebar;

        public frmGame(Tamagotchi tamagotchi, int gold)
        {
            InitializeComponent();
            this.gold = gold;
            this.tamagotchi = tamagotchi;

            gamebar = new GameBar(ref tamagotchi, ref lblGameLevel, ref lblHungerLevel,
                ref lblSleepLevel);
        }
        public int Gold
        {
            get { return gold; }
        }
        public Tamagotchi EditedTamagotchi
        {
            get { return tamagotchi; }
        }

        bool turn = true;
        int turn_count = 0;
        bool Iswinner = false;
        int TamagotchiCount = 0, DrawCount = 0, ComputerCount = 0;
        private void frmGame_Shown(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            time_count = 0;
            timeDisplay = 0;
            gameTimer.Enabled = true;
            Iswinner = false;
            lblSec.Visible = true;
            lblMin.Visible = true;
            lblPlaying.Visible = true;
            lblSec.Text = "0";
            lblMin.Text = "0";
            lblGold.Text = gold.ToString();


            try
            {
                foreach (Button button in this.Controls.OfType<Button>())
                {
                    Button b = (Button)button;
                    b.Enabled = true;
                    b.Text = "";
                    b.Visible = true;
                    b.BackColor = Color.Snow; 
                }
            }
            catch { }
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
                b.BackColor = Color.DodgerBlue;
            }
            else
            {
                b.Text = "O";
                b.BackColor = Color.Tomato;
            }

            turn = !turn;
            b.Enabled = false;
            turn_count++;
            CheckWinner();

            if ((!turn) && (turn_count != 9))
            {
                Computer_Move();
            }
        }

        private void Button_Enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (b.Enabled == true)
            {
                if (turn == true)
                    b.Text = "X";
                else
                    b.Text = "O";
            }
        }

        private void Button_Leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (b.Enabled == true)
            {
                b.Text = "";
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            time_count = 0;
            timeDisplay = 0;
            gameTimer.Enabled = true;
            Iswinner = false;
            lblSec.Visible = true;
            lblMin.Visible = true;
            lblPlaying.Visible = true;
            lblSec.Text = "0";
            lblMin.Text = "0";
            lblGold.Text = gold.ToString();

            try
            {
                foreach (Button button in this.Controls.OfType<Button>())
                {
                    Button b = (Button)button;
                    b.Enabled = true;
                    b.Text = "";
                    b.Visible = true;
                    b.BackColor = Color.Snow;
                }
            }
            catch { }
        }
        int time_count = 0;
        int timeDisplay = 0;
        int gameGold = 0;
        int Min = 0;
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            timeDisplay++;
            time_count++;
            lblSec.Text = timeDisplay.ToString();
            if (timeDisplay == 59)
            {
                lblSec.Text = "0";
                timeDisplay = 0;
                Min++;
                lblMin.Text = Min.ToString();
            }
        }
        private void CheckWinner()
        {
            //Horizontal win
            if ((btnA1.Text == btnA2.Text) && (btnA1.Text == btnA3.Text) && (btnA1.Enabled == false))
                Iswinner = true;
            else if ((btnB1.Text == btnB2.Text) && (btnB1.Text == btnB3.Text) && (btnB1.Enabled == false))
                Iswinner = true;
            else if ((btnC1.Text == btnC2.Text) && (btnC1.Text == btnC3.Text) && (btnC1.Enabled == false))
                Iswinner = true;

            //Vertical win
            else if ((btnA1.Text == btnB1.Text) && (btnA1.Text == btnC1.Text) && (btnA1.Enabled == false))
                Iswinner = true;
            else if ((btnA2.Text == btnB2.Text) && (btnA2.Text == btnC2.Text) && (btnA2.Enabled == false))
                Iswinner = true;
            else if ((btnA3.Text == btnB3.Text) && (btnA3.Text == btnC3.Text) && (btnA3.Enabled == false))
                Iswinner = true;

            // Diagonal win
            else if ((btnA1.Text == btnB2.Text) && (btnA1.Text == btnC3.Text) && (btnA1.Enabled == false))
                Iswinner = true;
            else if ((btnA3.Text == btnB2.Text) && (btnA3.Text == btnC1.Text) && (btnC1.Enabled == false))
                Iswinner = true;

            Random Number = new Random();
            int first, second, third;
            first = Number.Next(20, 30);
            second = Number.Next(10, 20);
            third = Number.Next(5, 10);

            if (Iswinner == true)
            {
                if (time_count <= 20 & turn == false)
                {
                    gameGold = first;
                    gold += gameGold;
                }
                else if (time_count >= 21 & time_count <= 40 & turn == false)
                {
                    gameGold = second;
                    gold += gameGold;
                }
                else if (time_count >= 41 & time_count <= 60 & turn == false)
                {
                    gameGold = third;
                    gold += gameGold;
                }
                else if (time_count > 60 & turn == false)
                {
                    gameGold = 2;
                    gold += gameGold;
                }

                gameTimer.Enabled = false;
                DisableButton();
                string winner = "";
                if (turn == true)
                {
                    winner = "O";
                    gamebar.increaseGameLevel(5);
                    MessageBox.Show(winner + " has won the game!");
                    ComputerCount++;
                    lblLosecount.Text = ComputerCount.ToString();
                }
                else
                {
                    winner = "X";
                    gamebar.increaseGameLevel(20);
                    MessageBox.Show(winner + " has won the game!" + " You won: " + gameGold.ToString() + " gold for winnning the match.");
                    lblGold.Text = gold.ToString();
                    TamagotchiCount++;
                    lblWincount.Text = TamagotchiCount.ToString();
                }

            }
            else
            {
                if (turn_count == 9)
                {
                    gameTimer.Enabled = false;
                    gameGold = 1;
                    gold += gameGold;
                    tamagotchi.increaseGameLevel(10);
                    MessageBox.Show("Draw!" + " You won " + gameGold.ToString() + " gold for drawing the match.");
                    gameTimer.Enabled = false;
                    lblGold.Text = gold.ToString();
                    DrawCount++;
                    lblDrawcount.Text = DrawCount.ToString();
                }
            }
        }
        private void DisableButton()
        {
            try
            {
                foreach (var button in this.Controls.OfType<Button>())
                {
                    Button b = (Button)button;
                    b.Enabled = false;
                }
            }
            catch { }

        }
        private void Computer_Move()
        {
            // 1 get tictactoe
            // 2 block tictactoe
            // 3 go for corner
            // 4 pick open

            Button move = null;

            move = Win_Or_Block("O");
            if (move == null)
            {
                move = Win_Or_Block("X");
                if (move == null)
                {
                    move = Look_Corner();
                    if (move == null)
                    {
                        move = Look_Open();
                    }//end if
                }//end if
            }//end if

            move.PerformClick();

        }
        private Button Win_Or_Block(string mark)
        {

            //HORIZONTAL TESTS
            if ((btnA1.Text == mark) && (btnA2.Text == mark) && (btnA3.Text == ""))
                return btnA3;
            if ((btnA2.Text == mark) && (btnA3.Text == mark) && (btnA1.Text == ""))
                return btnA1;
            if ((btnA1.Text == mark) && (btnA3.Text == mark) && (btnA2.Text == ""))
                return btnA2;

            if ((btnB1.Text == mark) && (btnB2.Text == mark) && (btnB3.Text == ""))
                return btnB3;
            if ((btnB2.Text == mark) && (btnB3.Text == mark) && (btnB1.Text == ""))
                return btnB1;
            if ((btnB1.Text == mark) && (btnB3.Text == mark) && (btnB2.Text == ""))
                return btnB2;

            if ((btnC1.Text == mark) && (btnC2.Text == mark) && (btnC3.Text == ""))
                return btnC3;
            if ((btnC2.Text == mark) && (btnC3.Text == mark) && (btnC1.Text == ""))
                return btnC1;
            if ((btnC1.Text == mark) && (btnC3.Text == mark) && (btnC2.Text == ""))
                return btnC2;

            //VERTICAL TESTS
            if ((btnA1.Text == mark) && (btnB1.Text == mark) && (btnC1.Text == ""))
                return btnC1;
            if ((btnB1.Text == mark) && (btnC1.Text == mark) && (btnA1.Text == ""))
                return btnA1;
            if ((btnA1.Text == mark) && (btnC1.Text == mark) && (btnB1.Text == ""))
                return btnB1;

            if ((btnA2.Text == mark) && (btnB2.Text == mark) && (btnC2.Text == ""))
                return btnC2;
            if ((btnB2.Text == mark) && (btnC2.Text == mark) && (btnA2.Text == ""))
                return btnA2;
            if ((btnA2.Text == mark) && (btnC2.Text == mark) && (btnB2.Text == ""))
                return btnB2;

            if ((btnA3.Text == mark) && (btnB3.Text == mark) && (btnC3.Text == ""))
                return btnC3;
            if ((btnB3.Text == mark) && (btnC3.Text == mark) && (btnA3.Text == ""))
                return btnA3;
            if ((btnA3.Text == mark) && (btnC3.Text == mark) && (btnB3.Text == ""))
                return btnB3;

            //DIAGONAL TESTS
            if ((btnA1.Text == mark) && (btnB2.Text == mark) && (btnC3.Text == ""))
                return btnC3;
            if ((btnB2.Text == mark) && (btnC3.Text == mark) && (btnA1.Text == ""))
                return btnA1;
            if ((btnA1.Text == mark) && (btnC3.Text == mark) && (btnB2.Text == ""))
                return btnB2;

            if ((btnA3.Text == mark) && (btnB2.Text == mark) && (btnC1.Text == ""))
                return btnC1;
            if ((btnB2.Text == mark) && (btnC1.Text == mark) && (btnA3.Text == ""))
                return btnA3;
            if ((btnA3.Text == mark) && (btnC1.Text == mark) && (btnB2.Text == ""))
                return btnB2;

            return null;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gamebar.stopDecrementTimers();
            gameTimer.Stop();
            Close();
        }

        private Button Look_Corner()
        {
            if (btnA1.Text == "O")
            {
                if (btnA3.Text == "")
                    return btnA3;
                if (btnC3.Text == "")
                    return btnC3;
                if (btnC1.Text == "")
                    return btnC1;
            }

            if (btnA3.Text == "O")
            {
                if (btnA1.Text == "")
                    return btnA1;
                if (btnC3.Text == "")
                    return btnC3;
                if (btnC1.Text == "")
                    return btnC1;
            }

            if (btnC3.Text == "O")
            {
                if (btnA1.Text == "")
                    return btnA3;
                if (btnA3.Text == "")
                    return btnA3;
                if (btnC1.Text == "")
                    return btnC1;
            }

            if (btnC1.Text == "O")
            {
                if (btnA1.Text == "")
                    return btnA3;
                if (btnA3.Text == "")
                    return btnA3;
                if (btnC3.Text == "")
                    return btnC3;
            }

            if (btnA1.Text == "")
                return btnA1;
            if (btnA3.Text == "")
                return btnA3;
            if (btnC1.Text == "")
                return btnC1;
            if (btnC3.Text == "")
                return btnC3;

            return null;
        }
        private Button Look_Open()
        {
            Button b = null;
            foreach (Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                        return b;
                }//end if
            }//end if

            return null;
        }
    }
}
