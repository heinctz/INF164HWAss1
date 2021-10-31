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

        private void displayGold()
        {
            lblGold.Text = $"Gold: {gold}";
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
            Hide();
            gameBar.stopDecrementTimers();
            tmrUpdateTamagotchiImage.Stop();
            tmrGameOver.Stop();

            frmGame Gameform = new frmGame(tamagotchi, gold);
            Gameform.ShowDialog();

            gold = Gameform.Gold;
            tamagotchi = Gameform.EditedTamagotchi;

            gameBar.startDecrementTimers();
            tmrUpdateTamagotchiImage.Start();
            tmrGameOver.Start();

            gameBar.displayGameBar();
            displayGold();
            Show();
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            Hide();
            gameBar.stopDecrementTimers();
            tmrUpdateTamagotchiImage.Stop();
            tmrGameOver.Stop();

            frmKitchen myKitchen = new frmKitchen(tamagotchi,gold);
            myKitchen.ShowDialog();

            gold = myKitchen.Gold;
            tamagotchi = myKitchen.EditedTamagotchi;

            gameBar.displayGameBar();
            displayGold();
            Show();
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
            if ((tamagotchi.GameLevel == 0) && (tamagotchi.HungerLevel == 0) && (tamagotchi.SleepLevel == 0))
            {
                tmrGameOver.Stop();
                MessageBox.Show("Game over: Your tamagotchi has died");
                Close();
            }
        }

        private void btnSleep_Click(object sender, EventArgs e)
        {
            gameBar.stopDecrementTimers();
            tmrUpdateTamagotchiImage.Stop();
            tmrGameOver.Stop();

            pbxTamagotchiState.Image = Image.FromFile(@"..\..\images\sleep.jpg");
            tmrIncreaseSleep.Start();

            btnSleep.Text = "Sleeping";
            btnSleep.Width = 100;
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
                    "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (stopSleeping == DialogResult.Yes)
                {
                    MessageBox.Show("Tamagotchi is awake!");
                    btnSleep.Text = "Sleep";
                    btnSleep.Width = 64;

                    gameBar.startDecrementTimers();
                    tmrUpdateTamagotchiImage.Start();
                    tmrGameOver.Start();
                }
                else
                {
                    MessageBox.Show("Tamagotch is still sleeping!");
                    btnSleep.Text = "Wake tamagotchi up";
                    btnSleep.Width = 140;
                }
            }
        }

        private void frmHome_Shown(object sender, EventArgs e)
        {

        }
    }
}
