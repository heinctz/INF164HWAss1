namespace INF164HWAss1
{
    using System.Windows.Forms;
    public class Fridge
    {
        private readonly int MIN_CAPACITY = 0;
        private readonly int MAX_CAPACITY = 20;

        private int NumDrinks;
        private int NumFood_Items;
        private int Curr_Capacity;

        public Fridge()
        {
            NumDrinks     = 0;
            NumFood_Items = 0;
            Curr_Capacity = 0;
        }

        public Fridge(int NumDrinks, int NumFood_Items, int Curr_Capacity)
        {
            // To calculate if the food items plus the drinking items are smaller than the MAX_CAPACITY
            bool bSmallerthan_max = false;
            if (NumDrinks + NumFood_Items <= MAX_CAPACITY)
                bSmallerthan_max = true;

            if (NumFood_Items < MIN_CAPACITY)
                MessageBox.Show("Number of food items cannot be a negative number");
            else if (NumFood_Items > MAX_CAPACITY)
                MessageBox.Show("Number of food items cannot be greater than 20");
            else if (bSmallerthan_max)
                this.NumDrinks = NumDrinks;

            if (NumDrinks < MIN_CAPACITY)
                MessageBox.Show("Number of drinks cannot be a negative number");
            else if (NumDrinks > MAX_CAPACITY)
                MessageBox.Show("Number of drinks cannot be greater than 20");
            else if (bSmallerthan_max)
                this.NumFood_Items = NumFood_Items;

            if (Curr_Capacity < MIN_CAPACITY)
                MessageBox.Show("The current capacity cannot be a negative number");
            else if (NumDrinks > MAX_CAPACITY)
                MessageBox.Show("The current capacity cannot be greater than 20");
            else if (bSmallerthan_max)
                this.Curr_Capacity = Curr_Capacity;
        }

        public int Drinks
        { 
            get {return NumDrinks;}
            set
            {
                bool bSmallerthan_max = false;
                if (NumDrinks + NumFood_Items <= MAX_CAPACITY)
                    bSmallerthan_max = true;

                if (NumDrinks < MIN_CAPACITY)
                    MessageBox.Show("Number of drinks cannot be a negative number");
                else if (NumDrinks > MAX_CAPACITY)
                    MessageBox.Show("Number of drinks cannot be greater than 20");
                else if (bSmallerthan_max)
                    this.NumDrinks = value;
            }
        }

        public int Food_Items
        {
            get {return NumFood_Items;}
            set
            {
                bool bSmallerthan_max = false;
                if (NumDrinks + NumFood_Items <= MAX_CAPACITY)
                    bSmallerthan_max = true;

                if (NumFood_Items < MIN_CAPACITY)
                    MessageBox.Show("Number of food items cannot be a negative number");
                else if (NumFood_Items > MAX_CAPACITY)
                    MessageBox.Show("Number of food items cannot be greater than 20");
                else if (bSmallerthan_max)
                    this.Food_Items = value;
            }
        }

        public int Current_Items
        {
            get {return Curr_Capacity;}
            set
            {
                bool bSmallerthan_max = false;
                if (NumDrinks + NumFood_Items <= MAX_CAPACITY)
                    bSmallerthan_max = true;

                if (Curr_Capacity < MIN_CAPACITY)
                    MessageBox.Show("The current capacity cannot be a negative number");
                else if (NumDrinks > MAX_CAPACITY)
                    MessageBox.Show("The current capacity cannot be greater than 20");
                else if (bSmallerthan_max)
                    this.Curr_Capacity = value;
            }
        }


    }
}
