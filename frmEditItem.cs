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
    public partial class frmEditItem : Form
    {
        private Item item;

        public frmEditItem(Item item)
        {
            InitializeComponent();

            this.item = item;
        }

        public Item EditedItem
        {
            get { return item; }
        }

        private void frmEditItem_Shown(object sender, EventArgs e)
        {
            txtName.Text = item.Name;
            cbxCategory.Text = item.Category;
            dtpPurchaseDate.Value = item.PurchaseDate.Date;
            txtCost.Text = item.GoldCost.ToString();
        }

        private void btnEditDetails_Click(object sender, EventArgs e)
        {
            item.Name = txtName.Text;
            item.Category = cbxCategory.Text;
            item.PurchaseDate = dtpPurchaseDate.Value.Date;
            item.GoldCost = Convert.ToInt32(txtCost.Text);

            Close();
        }
    }
}
