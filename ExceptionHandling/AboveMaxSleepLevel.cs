namespace INF164HWAss1.ExceptionHandling
{
    public class AboveMaxSleepLevel : System.Exception
    {
        public override string Message
        {
            get
            {
                return "Tamagotchi sleep Levels are full. Do you want him to " +
                    "stop sleeping?";
            }
        }
    }
}
