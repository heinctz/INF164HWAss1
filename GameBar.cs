using System;
using System.Windows.Forms;
using System.Drawing;
using INF164HWAss1.ExceptionHandling;

namespace INF164HWAss1
{
    public class GameBar
    {
        private Tamagotchi tamagotchi;

        private Label lblGameLevel;
        private Label lblHungerLevel;
        private Label lblSleepLevel;

        private System.Timers.Timer tmrDecrementGameLevel;
        private System.Timers.Timer tmrDecrementHungerLevel;
        private System.Timers.Timer tmrDecrementSleepLevel;

        private System.Timers.Timer tmrFlashGameLevel;
        private System.Timers.Timer tmrFlashHungerLevel;
        private System.Timers.Timer tmrFlashSleepLevel;

        private bool gameLevelFlag;
        private bool hungerLevelFlag;
        private bool sleepLevelFlag;

        private void displayGameLevel()
        {
            try
            {
                if (lblGameLevel.InvokeRequired)
                {
                    lblGameLevel.Invoke(new Action(displayGameLevel));
                    return;
                }

                lblGameLevel.Text = $"Game: {tamagotchi.GameLevel}";

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
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void displayHungerLevel()
        {
            try
            {
                if (lblHungerLevel.InvokeRequired)
                {
                    lblHungerLevel.Invoke(new Action(displayHungerLevel));
                    return;
                }

                lblHungerLevel.Text = $"Hunger: {tamagotchi.HungerLevel}";

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
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void displaySleepLevel()
        {
            try
            {
                if (lblSleepLevel.InvokeRequired)
                {
                    lblSleepLevel.Invoke(new Action(displaySleepLevel));
                    return;
                }
                lblSleepLevel.Text = $"Sleep: {tamagotchi.SleepLevel}";

                if ((tamagotchi.SleepLevel >= 90) && (tamagotchi.SleepLevel <= 100))
                    lblSleepLevel.BackColor = Color.Lime;
                else if ((tamagotchi.SleepLevel >= 80) && (tamagotchi.SleepLevel <= 89))
                    lblSleepLevel.BackColor = Color.LightGreen;
                else if ((tamagotchi.SleepLevel >= 70) && (tamagotchi.SleepLevel <= 79))
                    lblSleepLevel.BackColor = Color.Yellow;
                else if ((tamagotchi.SleepLevel >= 60) && (tamagotchi.SleepLevel <= 69))
                    lblSleepLevel.BackColor = Color.Orange;
                else if ((tamagotchi.SleepLevel >= 50) && (tamagotchi.SleepLevel <= 59))
                    lblSleepLevel.BackColor = Color.OrangeRed;
                else
                    lblSleepLevel.BackColor = Color.Red;
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


        private void decrementGameLevel(object source, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                tamagotchi.decrementGameLevel();
                displayGameLevel();

                tmrFlashGameLevel.Stop();
            }

            catch (NegativeGameLevel)
            {
                tmrFlashGameLevel.Start();
            }
        }

        private void decrementHungerLevel(object source, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                tamagotchi.decrementHungerLevel();
                displayHungerLevel();

                tmrFlashHungerLevel.Stop();
            }

            catch (NegativeHungerLevel)
            {
                tmrFlashHungerLevel.Start();
            }
        }

        private void decrementSleepLevel(object source, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                tamagotchi.decrementSleepLevel();
                displaySleepLevel();

                tmrFlashSleepLevel.Stop();
            }

            catch (NegativeSleepLevel)
            {
                tmrFlashSleepLevel.Start();
            }
        }

        private void changeGameLevelVisibility()
        {
            try
            {
                if (lblGameLevel.InvokeRequired)
                {
                    lblGameLevel.Invoke(new Action(changeGameLevelVisibility));
                    return;
                }

                if (gameLevelFlag)
                {
                    lblGameLevel.Visible = false;
                    gameLevelFlag = false;
                }
                else
                {
                    lblGameLevel.Visible = true;
                    gameLevelFlag = true;
                }
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void changeHungerLevelVisibility()
        {
            try
            {
                if (lblHungerLevel.InvokeRequired)
                {
                    lblHungerLevel.Invoke(new Action(changeHungerLevelVisibility));
                    return;
                }

                if (hungerLevelFlag)
                {
                    lblHungerLevel.Visible = false;
                    hungerLevelFlag = false;
                }
                else
                {
                    lblHungerLevel.Visible = true;
                    hungerLevelFlag = true;
                }
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void changeSleepLevelVisibility()
        {
            try
            {
                if (lblSleepLevel.InvokeRequired)
                {
                    lblSleepLevel.Invoke(new Action(changeSleepLevelVisibility));
                    return;
                }

                if (sleepLevelFlag)
                {
                    lblSleepLevel.Visible = false;
                    sleepLevelFlag = false;
                }
                else
                {
                    lblSleepLevel.Visible = true;
                    sleepLevelFlag = true;
                }
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void flashGameLevel(object source, System.Timers.ElapsedEventArgs e)
        {
            changeGameLevelVisibility();
        }

        private void flashHungerLevel(object source, System.Timers.ElapsedEventArgs e)
        {
            changeHungerLevelVisibility();
        }

        private void flashSleepLevel(object source, System.Timers.ElapsedEventArgs e)
        {
            changeSleepLevelVisibility();
        }

        public GameBar(ref Tamagotchi tamagotchi, ref Label lblGameLevel, ref Label lblHungerLevel,
            ref Label lblSleepLevel)
        {
            this.tamagotchi = tamagotchi;

            this.lblGameLevel = lblGameLevel;
            this.lblHungerLevel = lblHungerLevel;
            this.lblSleepLevel = lblSleepLevel;

            displayGameBar();

            tmrDecrementGameLevel = new System.Timers.Timer(200);
            tmrDecrementHungerLevel = new System.Timers.Timer(200);
            tmrDecrementSleepLevel = new System.Timers.Timer(400);

            tmrFlashGameLevel = new System.Timers.Timer(400);
            tmrFlashHungerLevel = new System.Timers.Timer(400);
            tmrFlashSleepLevel = new System.Timers.Timer(400);

            tmrDecrementGameLevel.Elapsed += decrementGameLevel;
            tmrDecrementHungerLevel.Elapsed += decrementHungerLevel;
            tmrDecrementSleepLevel.Elapsed += decrementSleepLevel;

            tmrFlashGameLevel.Elapsed += flashGameLevel;
            tmrFlashHungerLevel.Elapsed += flashHungerLevel;
            tmrFlashSleepLevel.Elapsed += flashSleepLevel;

            tmrDecrementGameLevel.Start();
            tmrDecrementHungerLevel.Start();
            tmrDecrementSleepLevel.Start();

            gameLevelFlag = true;
            hungerLevelFlag = true;
            sleepLevelFlag = true;
        }

        public void displayGameBar()
        {
            displayGameLevel();
            displayHungerLevel();
            displaySleepLevel();
        }

        public void increaseGameLevel(int value)
        {
            try
            {
                tamagotchi.increaseGameLevel(value);
                displayGameLevel();
            }

            catch (AboveMaxGameLevel maxGameLevel)
            {
                MessageBox.Show(maxGameLevel.Message, "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        public void increaseHungerLevel(int value)
        {
            try
            {
                tamagotchi.increaseHungerLevel(value);
                displayHungerLevel();
            }

            catch (AboveMaxHungerLevel maxHungerLevel)
            {
                MessageBox.Show(maxHungerLevel.Message, "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        public void incrementSleepLevel()
        {
            try
            {
                tamagotchi.incrementSleepLevel();
                displaySleepLevel();
            }
            
            catch (AboveMaxSleepLevel maxSleep)
            {
                throw maxSleep;
            }
        }

        public void stopDecrementTimers()
        {
            tmrDecrementGameLevel.Stop();
            tmrDecrementHungerLevel.Stop();
            tmrDecrementSleepLevel.Stop();
        }
        public void startDecrementTimers()
        {
            tmrDecrementGameLevel.Start();
            tmrDecrementHungerLevel.Start();
            tmrDecrementSleepLevel.Start();
        }

    }
}
