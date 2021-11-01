using System;

namespace INF164HWAss1
{
    [Serializable]
    public class Item
    {
        private string name;
        private string category;
        private DateTime purchaseDate;
        private int goldCost;

        public Item(string name, string category, DateTime purchaseDate, int goldCost)
        {
            this.name = name;
            this.category = category;
            this.purchaseDate = purchaseDate;
            this.goldCost = goldCost;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public DateTime PurchaseDate
        {
            get { return purchaseDate; }
            set { purchaseDate = value; }
        }

        public int GoldCost
        {
            get { return goldCost; }
            set { goldCost = value;  }
        }
    }
}

