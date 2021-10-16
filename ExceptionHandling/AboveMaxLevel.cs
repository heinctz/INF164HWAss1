namespace INF164HWAss1.ExceptionHandling
{
    public class AboveMaxLevel : System.Exception
    {
        private int level;

        public AboveMaxLevel(int level)
        {
            this.level = level;
        }

        public override string Message
        {
            get
            {
                return $"Level of {this.level} received. Level must be less than or" +
                    " equal to 100";
            }
        }
    }
}
