using System;

namespace INF164HWAss1
{
    public class Food
    {
        private string name;
        private string category;
        private DateTime purchaseDate;
        private double cost;

        public Food(string name, string category, DateTime purchaseDate,
            DateTime expireDate, double cost)
        {
            this.name = name;
            this.category = category;
            this.purchaseDate = purchaseDate;
            this.cost = cost;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Category
        {
            get { return category; }
            set { name = value; }
        }

        public DateTime PurchaseDate
        {
            get { return purchaseDate; }
            set { purchaseDate = value; }
        }

        public double Cost
        {
            get { return cost; }
            set { cost = value;  }
        }
    }
}

