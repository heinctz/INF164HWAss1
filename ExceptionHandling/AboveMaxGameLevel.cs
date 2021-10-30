namespace INF164HWAss1.ExceptionHandling
{
    public class AboveMaxGameLevel : System.Exception
    {
        public override string Message
        {
            get { return "Tamagotchi Game level is full"; }
        }
    }
}
