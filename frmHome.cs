using System;
using System.Windows.Forms;
using System.Drawing;
using INF164HWAss1.ExceptionHandling;

namespace INF164HWAss1
{
    public partial class frmHome : Form
    {
        private int gold;
        private Tamagotchi tamagotchi;
        private GameBar gameBar;
        private bool sleepStatus;

        private void displayGold()
        {
            lblGold.Text = $"Gold: {gold}";
        }

        private bool isGameOver()
        {
            return tamagotchi.GameLevel == 0 && tamagotchi.HungerLevel == 0
                && tamagotchi.SleepLevel == 0;
        }

        private bool isSleeping()
        {
            return sleepStatus;
        }

        public frmHome()
        {
            InitializeComponent();

            gold = 100;
            tamagotchi = new Tamagotchi();
            gameBar = new GameBar(ref tamagotchi, ref lblGameLevel, ref lblHungerLevel,
                ref lblSleepLevel);

            pbxTamagotchiState.Image = imlTamagochiStates.Images[0];
            tmrUpdateTamagotchiImage.Start();
            tmrGameOver.Start();

            displayGold();
        }

        public int Gold
        {
            get { return gold; }
            set { gold = value; }
        }

        public Tamagotchi HomeTamagotchi
        {
            get { return tamagotchi; }
            set { tamagotchi = value; }
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            if(tamagotchi.canPlayGame())
            {
                Hide();
                gameBar.stopDecrementTimers();
                tmrUpdateTamagotchiImage.Stop();
                tmrGameOver.Stop();

                frmGame gameForm = new frmGame(tamagotchi, gold);
                gameForm.ShowDialog();

                if (gameForm.GameOver)
                    Close();
                else
                {
                    gold = gameForm.Gold;
                    tamagotchi = gameForm.EditedTamagotchi;

                    gameBar.displayGameBar();
                    displayGold();
                    Show();

                    gameBar.startDecrementTimers();
                    tmrUpdateTamagotchiImage.Start();
                    tmrGameOver.Start();
                }
            }
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            if (tamagotchi.canEat())
            {
                Hide();
                gameBar.stopDecrementTimers();
                tmrUpdateTamagotchiImage.Stop();
                tmrGameOver.Stop();

                frmFridge kitchenForm = new frmFridge(tamagotchi,gold);
                kitchenForm.ShowDialog();

                gold = kitchenForm.Gold;
                tamagotchi = kitchenForm.EditedTamagotchi;

                if (kitchenForm.GameOver)
                    Close();
                else
                {
                    gameBar.displayGameBar();
                    displayGold();
                    Show();

                    gameBar.startDecrementTimers();
                    tmrUpdateTamagotchiImage.Start();
                    tmrGameOver.Start();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tmrUpdateTamagotchiImage_Tick(object sender, EventArgs e)
        {
            int happinessLevel = tamagotchi.getHappinessLevel(); 

            if ((happinessLevel >= 90) && (happinessLevel <= 100))
                pbxTamagotchiState.Image = imlTamagochiStates.Images[0];
            else if ((happinessLevel >= 80) && (happinessLevel <= 89))
                pbxTamagotchiState.Image = imlTamagochiStates.Images[1];
            else if ((happinessLevel >= 70) && (happinessLevel <= 79))
                pbxTamagotchiState.Image = imlTamagochiStates.Images[2];
            else if ((happinessLevel >= 60) && (happinessLevel <= 69))
                pbxTamagotchiState.Image = imlTamagochiStates.Images[3];
            else if ((happinessLevel >= 50) && (happinessLevel <= 59))
                pbxTamagotchiState.Image = imlTamagochiStates.Images[4];
            else if ((happinessLevel >= 40) && (happinessLevel <= 49))
                pbxTamagotchiState.Image = imlTamagochiStates.Images[5];
            else if ((happinessLevel >= 25) && (happinessLevel <= 39))
                pbxTamagotchiState.Image = imlTamagochiStates.Images[6];
            else
                pbxTamagotchiState.Image = imlTamagochiStates.Images[7];
        }

        private void tmrGameOver_Tick(object sender, EventArgs e)
        {
            if (isGameOver())
            {
                tmrGameOver.Stop();
                tmrUpdateTamagotchiImage.Stop();

                pbxTamagotchiState.Image = Image.FromFile(@"..\..\images\dead.jpg");

                MessageBox.Show("Tamagotchi has died", "Game Over",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void btnSleep_Click(object sender, EventArgs e)
        {
            if (tamagotchi.canSleep())
            {
                if (!isSleeping())
                {
                    sleepStatus = true;
                    gameBar.stopDecrementTimers();
                    tmrUpdateTamagotchiImage.Stop();
                    tmrGameOver.Stop();

                    pbxTamagotchiState.Image = Image.FromFile(@"..\..\images\sleep.jpg");
                    tmrIncreaseSleep.Start();

                    btnSleep.Text = "Wake him up";
                    btnSleep.Width = 100;
                }
                else
                {
                    tmrIncreaseSleep.Stop();

                    DialogResult stopSleeping;
                    stopSleeping = MessageBox.Show("Are you sure you want to wake up the tamagotchi?",
                        "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (stopSleeping == DialogResult.Yes)
                    {
                        sleepStatus = false;
                        gameBar.startDecrementTimers();
                        tmrUpdateTamagotchiImage.Start();
                        tmrGameOver.Start();

                        MessageBox.Show("Tamagotchi is awake", "Notification", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnSleep.Text = "Sleep";
                        btnSleep.Width = 64;
                    }
                    else
                    {
                        MessageBox.Show("Tamagotchi is still sleeping", "Notification", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tmrIncreaseSleep.Start();
                    }

                }
            }
        }

        private void tmrIncreaseSleep_Tick(object sender, EventArgs e)
        {
            try
            {
                gameBar.incrementSleepLevel();
            }

            catch (AboveMaxSleepLevel)
            {
                tmrIncreaseSleep.Stop();
                DialogResult stopSleeping;

                stopSleeping = MessageBox.Show("Tamagotchi sleep Levels are full. Do you want him to stop sleeping?",
                    "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (stopSleeping == DialogResult.Yes)
                {
                    gameBar.startDecrementTimers();
                    tmrUpdateTamagotchiImage.Start();
                    tmrGameOver.Start();

                    MessageBox.Show("Tamagotchi is awake", "Notification", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSleep.Text = "Sleep";
                    btnSleep.Width = 64;
                }
                else
                {
                    MessageBox.Show("Tamagotchi is still sleeping", "Notification", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tmrIncreaseSleep.Stop();
                }
            }
        }
    }
}
