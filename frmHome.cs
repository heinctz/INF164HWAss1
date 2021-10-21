using System;
using System.Windows.Forms;
using INF164HWAss1.ExceptionHandling;

namespace INF164HWAss1
{
    public partial class frmHome : Form
    {
        private int gameLevel;
        private int hungerLevel;
        private int sleepLevel;

        private int gold;
        private Tamagotchi tamagotchi;

        public frmHome()
        {
            InitializeComponent();

            gameLevel = 100;
            hungerLevel = 100;
            sleepLevel = 100;

            gold = 100;
            tamagotchi = new Tamagotchi(gameLevel, hungerLevel, sleepLevel);
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
        private void displayUpdatedLevels()
        {
            lblGameLevel.Text = $"Game: {tamagotchi.GameLevel}";
            lblHungerLevel.Text = $"Hunger: {tamagotchi.HungerLevel}";
            lblSleepLevel.Text = $"Sleep: {tamagotchi.SleepLevel}";
        }

        private void frmHome_Shown(object sender, EventArgs e)
        {
            lblGold.Text = $"Gold: {gold}";
            displayUpdatedLevels();

            tmrUpdateGameAndHunger.Enabled = true;
            tmrUpdateSleep.Enabled = true;
        }

        private void tmrUpdateGameAndHunger_Tick(object sender, EventArgs e)
        {
            gameLevel -= 1;
            hungerLevel -= 1;
            try
            {
                tamagotchi.GameLevel = gameLevel;
                tamagotchi.HungerLevel = hungerLevel;
                displayUpdatedLevels();
            }

            catch (NegativeLevel obj)
            {
                // when one of the levels is negative do something
            }
        }

        private void tmrUpdateSleep_Tick(object sender, EventArgs e)
        {
            sleepLevel -= 1;
            try
            {
                tamagotchi.SleepLevel = sleepLevel;
                displayUpdatedLevels();
            }

            catch (NegativeLevel obj)
            {
                // when the sleep level is negative do something
            }
        }
    }
}
