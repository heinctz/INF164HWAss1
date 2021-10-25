using System.Windows.Forms;
using System;
namespace INF164HWAss1
{
    public class Food
    {
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
