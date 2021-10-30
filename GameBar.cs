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
            lblGameLevel.Text = $"Game: {tamagotchi.GameLevel}";
        }

        private void displayHungerLevel()
        {
            lblHungerLevel.Text = $"Hunger: {tamagotchi.HungerLevel}";
        }

        private void displaySleepLevel()
        {
            lblSleepLevel.Text = $"Sleep: {tamagotchi.SleepLevel}";
        }

        private void displayGameLevelColour()
        {
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

        private void displayHungerLevelColour()
        {
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

        private void displaySleepLevelColour()
        {
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

        private void decrementGameLevel(object source, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                tamagotchi.decrementGameLevel();
                displayGameLevel();
                displayGameLevelColour();

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
                displayHungerLevelColour();

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
                displaySleepLevelColour();

                tmrFlashSleepLevel.Stop();
            }

            catch (NegativeSleepLevel)
            {
                tmrFlashSleepLevel.Start();
            }
        }

        private void flashGameLevel(object source, System.Timers.ElapsedEventArgs e)
        {
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

        private void flashHungerLevel(object source, System.Timers.ElapsedEventArgs e)
        {
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

        private void flashSleepLevel(object source, System.Timers.ElapsedEventArgs e)
        {
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

        public GameBar(ref Label lblGameLevel, ref Label lblHungerLevel,
            ref Label lblSleepLevel)
        {
            this.lblGameLevel = lblGameLevel;
            this.lblHungerLevel = lblHungerLevel;
            this.lblSleepLevel = lblSleepLevel;

            tmrDecrementGameLevel = new System.Timers.Timer(500);
            tmrDecrementHungerLevel = new System.Timers.Timer(500);
            tmrDecrementSleepLevel = new System.Timers.Timer(500);

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

        public void increaseGameLevel(int value)
        {
            try
            {
                tamagotchi.increaseGameLevel(value);
                displayGameLevel();
                displayGameLevelColour();
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
                displayHungerLevelColour();
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
                displaySleepLevelColour();
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
