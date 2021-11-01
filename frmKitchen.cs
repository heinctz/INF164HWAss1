using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace INF164HWAss1
{
    public partial class frmKitchen : Form
    {
        private int gold;
        private Tamagotchi tamagotchi;
        private GameBar gameBar;
        private bool gameOver;

        public frmKitchen(Tamagotchi tamagotchi, int gold)
        {
            InitializeComponent();
            this.gold = gold;
            this.tamagotchi = tamagotchi;
            gameBar = new GameBar(ref tamagotchi, ref lblGameLevel, ref lblHungerLevel,
                ref lblSleepLevel);

            gameOver = false;
            tmrGameOver.Start();
        }
        public int Gold
        {
            get { return gold; }
        }

        public Tamagotchi EditedTamagotchi
        {
            get { return tamagotchi; }
        }

        public bool GameOver
        {
            get { return gameOver; }
        }

        BindingList<Food> myfoods = new BindingList<Food>();
        private void frmKitchen_Load(object sender, EventArgs e)
        {
            Food newFood;
            DateTime newDate_Purchased;
            DateTime newDate_Expired;
            // Add six food items to list.
            //#1
            newDate_Purchased = new DateTime(2021, 4, 23);
            newDate_Expired = new DateTime(2021, 8, 23);
            newFood = new Food("Apple","Eat", newDate_Purchased, newDate_Expired,5.0);
            myfoods.Add(newFood);
            //#2
            newDate_Purchased = new DateTime(2021, 3, 10);
            newDate_Expired = new DateTime(2021, 7, 10);
            newFood = new Food("Water", "Drink", newDate_Purchased, newDate_Expired, 5.0);
            myfoods.Add(newFood);
            //#3
            newDate_Purchased = new DateTime(2021, 2, 15);
            newDate_Expired = new DateTime(2021, 6, 15);
            newFood = new Food("Burger", "Eat", newDate_Purchased, newDate_Expired, 15.0);
            myfoods.Add(newFood);
            //#4
            newDate_Purchased = new DateTime(2021, 2, 3);
            newDate_Expired = new DateTime(2021, 6, 3);
            newFood = new Food("Chicken", "Eat", newDate_Purchased, newDate_Expired, 10.0);
            myfoods.Add(newFood);
            //#5
            newDate_Purchased = new DateTime(2021, 6, 12);
            newDate_Expired = new DateTime(2021, 12, 12);
            newFood = new Food("Tea", "Drink", newDate_Purchased, newDate_Expired, 10.0);
            myfoods.Add(newFood);
            //#6
            newDate_Purchased = new DateTime(2021, 5, 17);
            newDate_Expired = new DateTime(2021, 9, 17);
            newFood = new Food("Milk Shake", "Drink", newDate_Purchased, newDate_Expired, 15.0);
            myfoods.Add(newFood);

            //Link the list to the DataGridView.
            dgvFridge.DataSource = myfoods;
        }

        private void btnEat_Click(object sender, EventArgs e)
        {
            int iSelectedIndex = dgvFridge.CurrentCell.RowIndex;
            int Value1 = 0;
            switch (dgvFridge[0, iSelectedIndex].Value)
            {   case "Apple":
                    Value1 = 5;
                    break;
                case "Water":
                    Value1 = 5;
                    break;
                case "Chicken":
                    Value1 = 10;
                    break;
                case "Tea":
                    Value1 = 10;
                    break;
                case "Burger":
                    Value1 = 15;
                    break;
                case "Milk Shake":
                    Value1 = 15;
                    break;
                default:
                    break;
            }
            if ((Value1 < gold) && (tamagotchi.HungerLevel + Value1 < 100) )
            {
                tamagotchi.HungerLevel = tamagotchi.HungerLevel + Value1;
                gold -= Value1;
            }
        }


        private void btnCalculateNum_category_Click(object sender, EventArgs e)
        {
            int iDrink_Items=0;
            int iFood_Items =0;

            for (int j = 0; j < dgvFridge.Rows.Count -1; j++)
            {
               if (dgvFridge[1,j].Value == "Drink")
                {
                    iDrink_Items++;
                }
                if (dgvFridge[1, j].Value == "Eat")
                {
                    iFood_Items++;
                }
            }
            MessageBox.Show(Convert.ToString("There are " + iDrink_Items + " items to drink in the fridge"));
            MessageBox.Show(Convert.ToString("There are " + iFood_Items  + " items to eat in the fridge"));
        }

        private void btnAddCompost_Click(object sender, EventArgs e)
        {
            int iSelectedIndex = dgvFridge.CurrentCell.RowIndex;
            int Value1 = 0;

            switch (dgvFridge[0, iSelectedIndex].Value)
            {
                case "Apple":
                    Value1 = 5;
                    break;
                case "Water":
                    Value1 = 5;
                    break;
                case "Chicken":
                    Value1 = 10;
                    break;
                case "Tea":
                    Value1 = 10;
                    break;
                case "Burger":
                    Value1 = 15;
                    break;
                case "Milk Shake":
                    Value1 = 15;
                    break;
                default:
                    break;
            }
            gold += Value1;
            MessageBox.Show(Convert.ToString(gold));
            dgvFridge.Rows.RemoveAt(iSelectedIndex);
        }

        private void btnKitchen_Back_Click(object sender, EventArgs e)
        {
            gameBar.stopAllTimers();
            Close();
        }

        private void btnExpired_Click(object sender, EventArgs e)
        {
            int iNumber_expired = 0;
            DateTime dNow;
            dNow = DateTime.Now;

            for (int j = 0; j < dgvFridge.Rows.Count - 1; j++)
            {
                DateTime dExpire = Convert.ToDateTime(dgvFridge[2, j].Value);

                if (dExpire < dNow)
                {
                    iNumber_expired++;
                }
            }
            MessageBox.Show("There are " + Convert.ToString(iNumber_expired) + " items expired in the fridge.");
        }

        private void tmrGameOver_Tick(object sender, EventArgs e)
        {
            if ((tamagotchi.GameLevel == 0) && (tamagotchi.HungerLevel == 0) && (tamagotchi.SleepLevel == 0))
            {
                tmrGameOver.Stop();
                gameOver = true;
                MessageBox.Show("Game over: Your tamagotchi has died");
                Close();
            }
        }
    }
}
