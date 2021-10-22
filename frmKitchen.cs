using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF164HWAss1
{
    public partial class frmKitchen : Form
    {
        private int gold;
        private Tamagotchi tamagotchi;

        public frmKitchen(Tamagotchi tamagotchi, int gold)
        {
            InitializeComponent();
            this.gold = gold;
            this.tamagotchi = new Tamagotchi(tamagotchi);
        }
        public int Gold
        {
            get { return gold; }
        }
        public Tamagotchi EditedTamagotchi
        {
            get { return tamagotchi; }
        }
        List<Food> myfoods = new List<Food>();
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
            newDate_Expired = new DateTime(2021, 10, 12);
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
    }
}
