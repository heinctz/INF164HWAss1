﻿using System;
using System.Windows.Forms;
using INF164HWAss1.ExceptionHandling;

namespace INF164HWAss1
{
    public partial class frmHome : Form
    {
        private int gold;
        private Tamagotchi tamagotchi;

        public frmHome()
        {
            InitializeComponent();

            gold = 100;
            tamagotchi = new Tamagotchi();
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

        private void displayGameLevels()
        {
            lblGameLevel.Text = $"Game: {tamagotchi.GameLevel}";
            lblHungerLevel.Text = $"Hunger: {tamagotchi.HungerLevel}";
            lblSleepLevel.Text = $"Sleep: {tamagotchi.SleepLevel}";
        }

        private void frmHome_Shown(object sender, EventArgs e)
        {
            lblGold.Text = $"Gold: {gold}";
            displayGameLevels();

            tmrUpdateGameAndHunger.Enabled = true;
            tmrUpdateSleep.Enabled = true;
        }

        private void tmrUpdateGameAndHunger_Tick(object sender, EventArgs e)
        {
            try
            {
                tamagotchi.decrementGameLevel();
                tamagotchi.decrementHungerLevel();
                displayGameLevels();
            }

            catch (NegativeGameLevel)
            {
            }

            catch (NegativeHungerLevel)
            {
            }
        }

        private void tmrUpdateSleep_Tick(object sender, EventArgs e)
        {
            try
            {
                tamagotchi.decrementSleepLevel();
                displayGameLevels();
            }

            catch (NegativeSleepLevel)
            {
            }
        }
    }
}
