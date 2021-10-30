namespace INF164HWAss1.ExceptionHandling
{
    public class AboveMaxHungerLevel : System.Exception
    {
        public override string Message
        {
            get { return "Tamagotchi hunger level is full"; }
        }
    }
}
