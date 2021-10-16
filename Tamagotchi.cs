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
            gameLevel = 0;
            hungerLevel = 0;
            sleepLevel = 0;
        }

        public Tamagotchi(int gameLevel, int hungerLevel, int sleepLevel)
        {
            if (gameLevel < minLevel)
                throw new NegativeLevel(gameLevel);
            else if (gameLevel > maxLevel)
                throw new AboveMaxLevel(gameLevel);
            else
                this.gameLevel = gameLevel;

            if (hungerLevel < minLevel)
                throw new NegativeLevel(hungerLevel);
            else if (hungerLevel > maxLevel)
                throw new AboveMaxLevel(hungerLevel);
            else
                this.hungerLevel = hungerLevel;

            if (sleepLevel < minLevel)
                throw new NegativeLevel(sleepLevel);
            else if (sleepLevel > maxLevel)
                throw new AboveMaxLevel(sleepLevel);
            else
                this.sleepLevel = sleepLevel;
        }

        public int GameLevel
        {
            get { return gameLevel; }
            set
            {
                if (gameLevel < minLevel)
                    throw new NegativeLevel(gameLevel);
                else if (gameLevel > maxLevel)
                    throw new AboveMaxLevel(gameLevel);
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
                    throw new NegativeLevel(hungerLevel);
                else if (hungerLevel > maxLevel)
                    throw new AboveMaxLevel(hungerLevel);
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
                    throw new NegativeLevel(sleepLevel);
                else if (sleepLevel > maxLevel)
                    throw new AboveMaxLevel(sleepLevel);
                else
                    this.sleepLevel = value;
            }
        }

        public int getHappinessLevel()
        {
            return (this.gameLevel + this.hungerLevel + this.sleepLevel) / 3;
        }
    }
}
