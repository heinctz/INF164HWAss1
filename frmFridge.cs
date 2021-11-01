using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using INF164HWAss1.ExceptionHandling;

namespace INF164HWAss1
{
    public partial class frmFridge : Form
    {
        private int gold;
        private Tamagotchi tamagotchi;
        private BindingList<Item> itemsList;
        private GameBar gameBar;
        private bool gameOver;

        public frmFridge(Tamagotchi tamagotchi, int gold)
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

        private void displayGold()
        {
            lblGold.Text = $"Gold: {gold}";
        }

        private void displayAddConfirmation()
        {
            txtName.Clear();
            cbxCategory.Text = "";
            dtpPurchaseDate.Value = DateTime.Today;
            txtCost.Clear();

            MessageBox.Show("Item was added to the fridge", "Notification",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmFridge_Shown(object sender, EventArgs e)
        {
            displayGold();
            try
            {
                using (StreamReader inputFile = new StreamReader(@"..\..\files\items.ser"))
                {
                    BinaryFormatter binaryToObjectConveter = new BinaryFormatter();

                    itemsList = (BindingList<Item>)binaryToObjectConveter.Deserialize(inputFile.BaseStream);
                    dgvFridge.DataSource = itemsList;

                    dgvFridge.Columns[0].Width = 260;
                    dgvFridge.Columns[1].Width = 100;
                    dgvFridge.Columns[2].Width = 100;
                    dgvFridge.Columns[3].Width = 100;
                }
            }

            catch (FileNotFoundException) {}
        }

        private void btnBackToHome_Click(object sender, EventArgs e)
        {
            tmrGameOver.Stop();
            gameBar.stopDecrementTimers();

            using (StreamWriter outputFile = new StreamWriter(@"..\..\files\items.ser"))
            {
                BinaryFormatter objectToBinaryConverer = new BinaryFormatter();

                objectToBinaryConverer.Serialize(outputFile.BaseStream, itemsList);
            }

            Close();
        }

        private void tmrGameOver_Tick(object sender, EventArgs e)
        {
            if ((tamagotchi.GameLevel == 0) && (tamagotchi.HungerLevel == 0) && (tamagotchi.SleepLevel == 0))
            {
                gameBar.stopDecrementTimers();
                tmrGameOver.Stop();
                gameOver = true;
                MessageBox.Show("Tamagotchi has died", "Game Over",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void btnAddToFridge_Click(object sender, EventArgs e)
        {
            string name;
            string category;
            DateTime purchaseDate;
            int cost;

            name = txtName.Text;
            category = cbxCategory.Text;
            purchaseDate = dtpPurchaseDate.Value.Date;
            cost = Convert.ToInt32(txtCost.Text);

            Item item = new Item(name, category, purchaseDate, cost);
            itemsList.Add(item);

            displayAddConfirmation();
        }

        private void btnConsumeSelectedItem_Click(object sender, EventArgs e)
        {
            int selectedIndex = dgvFridge.CurrentCell.RowIndex;
            Item selectedItem = itemsList[selectedIndex];

            if ((gold - selectedItem.GoldCost) >= 0)
            {
                try
                {
                    gameBar.increaseHungerLevel(selectedItem.GoldCost);
                }

                catch (AboveMaxGameLevel)
                {
                    gameBar.increaseHungerLevel(100 - tamagotchi.HungerLevel);
                }

                gold -= selectedItem.GoldCost;
                displayGold();

                itemsList.RemoveAt(selectedIndex);
                MessageBox.Show("Item was consumed", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Not enough gold to consume item", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThrowAway_Click(object sender, EventArgs e)
        {
            DialogResult deleteItem;
            string output;

            deleteItem = MessageBox.Show("Are you sure you want to throw away this item?",
                "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (deleteItem == DialogResult.Yes)
            {
                itemsList.RemoveAt(dgvFridge.CurrentCell.RowIndex);
                output = "Item was thrown away";
            }
            else
                output = "Item was not thrown away";

            MessageBox.Show(output, "Notification", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnNumItemsPerCategory_Click(object sender, EventArgs e)
        {
            int numBeverage = 0, numFood = 0;

            for (int index = 0; index < itemsList.Count; index++)
            {
                if (itemsList[index].Category == "food")
                    numFood++;
                else
                    numBeverage++;
            }

            MessageBox.Show($"Number of Beverages: {numBeverage}" +
                $"\nNumber of Food items: {numFood}", "Summary", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            int selectedIndex = dgvFridge.CurrentCell.RowIndex;
            frmEditItem editItemFrom = new frmEditItem(itemsList[selectedIndex]);

            editItemFrom.ShowDialog();

            itemsList[selectedIndex] = editItemFrom.EditedItem;
        }
    }
}
