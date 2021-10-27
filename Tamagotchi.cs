using INF164HWAss1.ExceptionHandling;

namespace INF164HWAss1
{
    public class Tamagotchi
    {
        private readonly int minLevel = 0;
        private readonly int maxLevel = 100;

        private int gameLevel;
        private int hungerLevel;
        private int sleepLevel;

        public Tamagotchi()
        {
            gameLevel = 100;
            hungerLevel = 100;
            sleepLevel = 100;
        }

        public Tamagotchi(int gameLevel, int hungerLevel, int sleepLevel)
        {
            if (gameLevel < minLevel)
                throw new NegativeGameLevel();
            else if (gameLevel > maxLevel)
                throw new AboveMaxGameLevel();
            else
                this.gameLevel = gameLevel;

            if (hungerLevel < minLevel)
                throw new NegativeHungerLevel();
            else if (hungerLevel > maxLevel)
                throw new AboveMaxHungerLevel();
            else
                this.hungerLevel = hungerLevel;

            if (sleepLevel < minLevel)
                throw new NegativeSleepLevel();
            else if (sleepLevel > maxLevel)
                throw new AboveMaxSleepLevel();
            else
                this.sleepLevel = sleepLevel;
        }

        public Tamagotchi(Tamagotchi tamagotchi)
        {
            gameLevel = tamagotchi.GameLevel;
            hungerLevel = tamagotchi.HungerLevel;
            sleepLevel = tamagotchi.SleepLevel;
        }

        public int GameLevel
        {
            get { return gameLevel; }
            set
            {
                if (gameLevel < minLevel)
                    throw new NegativeGameLevel();
                else if (gameLevel > maxLevel)
                    throw new AboveMaxGameLevel();
                else
                    this.gameLevel = value;
            }
        }

        public int HungerLevel
        {
            get { return hungerLevel; }
            set
            {
                if (hungerLevel < minLevel)
                    throw new NegativeHungerLevel();
                else if (hungerLevel > maxLevel)
                    throw new AboveMaxHungerLevel();
                else
                    this.hungerLevel = value;
            }
        }

        public int SleepLevel
        {
            get { return sleepLevel; }
            set
            {
                if (sleepLevel < minLevel)
                    throw new NegativeSleepLevel();
                else if (sleepLevel > maxLevel)
                    throw new AboveMaxSleepLevel();
                else
                    sleepLevel = value;
            }
        }

        public void decrementGameLevel()
        {
            if ((gameLevel - 1) == -1)
                throw new NegativeGameLevel();
            else
                gameLevel--;
        }

        public void decrementHungerLevel()
        {
            if ((hungerLevel - 1) == -1)
                throw new NegativeHungerLevel();
            else
                hungerLevel--;
        }

        public void decrementSleepLevel()
        {
            if ((sleepLevel - 1) == -1)
                throw new NegativeSleepLevel();
            else
                sleepLevel--;
        }

        public void increaseSleepLevel()
        {
            if ((sleepLevel + 1) == 101)
                throw new AboveMaxSleepLevel();
            else
                sleepLevel++;
        }

        public int getHappinessLevel()
        {
            return (gameLevel + hungerLevel + sleepLevel) / 3;
        }
    }
}
