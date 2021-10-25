namespace INF164HWAss1
{
    using System.Windows.Forms;
    using System;
    public class Food
    {
        private readonly int MIN_CAPACITY = 0;
        private readonly int MAX_CAPACITY = 20;

        private int Curr_Capacity =0;

        private string sName;
        private string Category;
        private DateTime Purchased;
        private DateTime Expire;
        private double dCost;

        public Food()
        {
            sName = "";
            Category  = "";
            Purchased = new DateTime(2021, 1, 1);
            Expire    = new DateTime(2021, 12, 31);
            dCost      = 0.0;
        }

        public Food(string Name, string Category, DateTime Purchased, DateTime Expire, double Cost)
        {
            // To calculate if the food items are smaller than the MAX_CAPACITY and larger than the MIN_CAPACITY.
            bool bSmallerthan_max = false;
            if (Curr_Capacity + 1 <= MAX_CAPACITY)
                bSmallerthan_max = true;

            if (Curr_Capacity < MIN_CAPACITY)
                MessageBox.Show("Number of food items cannot be a negative number");
            else if (Curr_Capacity > MAX_CAPACITY)
                MessageBox.Show("Number of food items cannot be greater than 20");
            else if (bSmallerthan_max)
                 Curr_Capacity++;

            this.sName     = Name;
            this.Category  = Category;
            this.Purchased = Purchased;
            this.Expire    = Expire;
            this.dCost      = Cost;
        }

        public string Name
        {
            get { return sName;}
        }

        private int Current_Items
        {
            get {return Curr_Capacity;}
        }

        public string category
        {
            get {return Category;}
        }

        public DateTime expire
        {
            get { return Expire; }
        }

        public DateTime purchased
        {
            get { return Purchased; }
        }
        public double Cost
        {
            get { return dCost;}
        }
    }
}
