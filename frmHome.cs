﻿using System;
using System.Windows.Forms;
using System.Drawing;
using INF164HWAss1.ExceptionHandling;

namespace INF164HWAss1
{
    public partial class frmHome : Form
    {
        private int gold;
        private Tamagotchi tamagotchi;
        private int gameLevelCounter;
        private int hungerLevelCounter;
        private int sleepLevelCounter;

        public frmHome()
        {
            InitializeComponent();

            gold = 100;
            tamagotchi = new Tamagotchi();

            displayGameLevels();

            tmrUpdateGame.Enabled = true;
            tmrUpdateHunger.Enabled = true;
            tmrUpdateSleep.Enabled = true;

            gameLevelCounter = 0;
            hungerLevelCounter = 0;
            sleepLevelCounter = 0;
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

            tmrUpdateGame.Enabled = true;
            tmrUpdateSleep.Enabled = true;
        }

        private void tmrUpdateGameAndHunger_Tick(object sender, EventArgs e)
        {
            try
            {
                tamagotchi.decrementGameLevel();
                displayGameLevels();

                if ((tamagotchi.GameLevel >= 90) && (tamagotchi.GameLevel <= 100))
                    lblGameLevel.BackColor = Color.Lime;
                else if ((tamagotchi.GameLevel >= 80) && (tamagotchi.GameLevel <= 89))
                    lblGameLevel.BackColor = Color.LightGreen;
                else if ((tamagotchi.GameLevel >= 70) && (tamagotchi.GameLevel <= 79))
                    lblGameLevel.BackColor = Color.Yellow;
                else if ((tamagotchi.GameLevel >= 60) && (tamagotchi.GameLevel <= 69))
                    lblGameLevel.BackColor = Color.Orange;
                else if ((tamagotchi.GameLevel >= 50) && (tamagotchi.GameLevel <= 59))
                    lblGameLevel.BackColor = Color.OrangeRed;
                else
                    lblGameLevel.BackColor = Color.Red;

                tmrNegativeGameLevel.Enabled = false;
            }

            catch (NegativeGameLevel)
            {
                tmrNegativeGameLevel.Enabled = true;
            }

        }

        private void tmrUpdateHunger_Tick(object sender, EventArgs e)
        {
            try
            {
                tamagotchi.decrementHungerLevel();
                displayGameLevels();

                if ((tamagotchi.HungerLevel >= 90) && (tamagotchi.HungerLevel <= 100))
                    lblHungerLevel.BackColor = Color.Lime;
                else if ((tamagotchi.HungerLevel >= 80) && (tamagotchi.HungerLevel <= 89))
                    lblHungerLevel.BackColor = Color.LightGreen;
                else if ((tamagotchi.HungerLevel >= 70) && (tamagotchi.HungerLevel <= 79))
                    lblHungerLevel.BackColor = Color.Yellow;
                else if ((tamagotchi.HungerLevel >= 60) && (tamagotchi.HungerLevel <= 69))
                    lblHungerLevel.BackColor = Color.Orange;
                else if ((tamagotchi.HungerLevel >= 50) && (tamagotchi.HungerLevel <= 59))
                    lblHungerLevel.BackColor = Color.OrangeRed;
                else
                    lblHungerLevel.BackColor = Color.Red;

                tmrNegativeHungerLevel.Enabled = false;
            }

            catch (NegativeHungerLevel)
            {
                tmrNegativeHungerLevel.Enabled = true;
            }
        }

        private void tmrUpdateSleep_Tick(object sender, EventArgs e)
        {
            try
            {
                tamagotchi.decrementSleepLevel();
                displayGameLevels();

                if ((tamagotchi.SleepLevel >= 90) && (tamagotchi.SleepLevel <= 100))
                    lblSleepLevel.BackColor = Color.Lime;
                else if ((tamagotchi.SleepLevel >= 80) && (tamagotchi.SleepLevel <= 89))
                    lblSleepLevel.BackColor = Color.LightGreen;
                else if ((tamagotchi.SleepLevel >= 70) && (tamagotchi.SleepLevel <= 79))
                    lblSleepLevel.BackColor = Color.Yellow;
                else if ((tamagotchi.SleepLevel >= 60) && (tamagotchi.SleepLevel <= 69))
                    lblSleepLevel.BackColor = Color.Orange;
                else if ((tamagotchi.SleepLevel >= 50) && (tamagotchi.HungerLevel <= 59))
                    lblSleepLevel.BackColor = Color.OrangeRed;
                else
                    lblSleepLevel.BackColor = Color.Red;

                tmrNegativeSleepLevel.Enabled = false;
            }

            catch (NegativeSleepLevel)
            {
                tmrNegativeSleepLevel.Enabled = true;
            }
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            frmGame Gameform = new frmGame(tamagotchi, gold);
            Hide();
            Gameform.ShowDialog();

            gold = Gameform.Gold;
            tamagotchi = Gameform.EditedTamagotchi;
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            frmKitchen myKitchen = new frmKitchen(tamagotchi,gold);
            Hide();
            myKitchen.ShowDialog();
            gold = myKitchen.Gold;
            tamagotchi = myKitchen.EditedTamagotchi;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tmrNegativeGameLevel_Tick(object sender, EventArgs e)
        {
            gameLevelCounter++;
            if (gameLevelCounter % 2 == 0)
                lblGameLevel.Visible = false;
            else
                lblGameLevel.Visible = true;
        }

        private void tmrNegativeHungerLevel_Tick(object sender, EventArgs e)
        {
            hungerLevelCounter++;
            if (hungerLevelCounter % 2 == 0)
                lblHungerLevel.Visible = false;
            else
                lblHungerLevel.Visible = true;
        }

        private void tmrNegativeSleepLevel_Tick(object sender, EventArgs e)
        {
            sleepLevelCounter++;
            if (sleepLevelCounter % 2 == 0)
                lblSleepLevel.Visible = false;
            else
                lblSleepLevel.Visible = true;
        }

    }
}
