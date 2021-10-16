namespace INF164HWAss1.ExceptionHandling
{
    public class NegativeLevel : System.Exception
    {
        private int level;

        public NegativeLevel(int level)
        {
            this.level = level;
        }

        public override string Message
        {
            get
            {
                return $"Negative level of {this.level} received. Level can only be positive";
            }
        }
    }
}
