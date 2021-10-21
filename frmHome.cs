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

        private void frmHome_Shown(object sender, EventArgs e)
        {
            lblGold.Text = $"Gold: {gold}";
            lblGameLevel.Text = $"Game: {gameLevel}";
            lblHungerLevel.Text = $"Hunger: {hungerLevel}";
            lblSleepLevel.Text = $"Sleep: {sleepLevel}";
        }
    }
}
