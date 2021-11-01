
namespace INF164HWAss1
{
    partial class frmFridge
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblSleepLevel = new System.Windows.Forms.Label();
            this.lblHungerLevel = new System.Windows.Forms.Label();
            this.lblGameLevel = new System.Windows.Forms.Label();
            this.tmrGameOver = new System.Windows.Forms.Timer(this.components);
            this.gbxNewItem = new System.Windows.Forms.GroupBox();
            this.btnAddToFridge = new System.Windows.Forms.Button();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gbxFridge = new System.Windows.Forms.GroupBox();
            this.btnConsumeSelectedItem = new System.Windows.Forms.Button();
            this.btnNumItemsPerCategory = new System.Windows.Forms.Button();
            this.btnBackToHome = new System.Windows.Forms.Button();
            this.btnThrowAway = new System.Windows.Forms.Button();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.dgvFridge = new System.Windows.Forms.DataGridView();
            this.lblGold = new System.Windows.Forms.Label();
            this.gbxNewItem.SuspendLayout();
            this.gbxFridge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFridge)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSleepLevel
            // 
            this.lblSleepLevel.AutoSize = true;
            this.lblSleepLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblSleepLevel.Font = new System.Drawing.Font("Consolas", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSleepLevel.Location = new System.Drawing.Point(429, 11);
            this.lblSleepLevel.Name = "lblSleepLevel";
            this.lblSleepLevel.Size = new System.Drawing.Size(49, 14);
            this.lblSleepLevel.TabIndex = 9;
            this.lblSleepLevel.Text = "Sleep:";
            // 
            // lblHungerLevel
            // 
            this.lblHungerLevel.AutoSize = true;
            this.lblHungerLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblHungerLevel.Font = new System.Drawing.Font("Consolas", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHungerLevel.Location = new System.Drawing.Point(312, 9);
            this.lblHungerLevel.Name = "lblHungerLevel";
            this.lblHungerLevel.Size = new System.Drawing.Size(56, 14);
            this.lblHungerLevel.TabIndex = 8;
            this.lblHungerLevel.Text = "Hunger:";
            // 
            // lblGameLevel
            // 
            this.lblGameLevel.AutoSize = true;
            this.lblGameLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblGameLevel.Font = new System.Drawing.Font("Consolas", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameLevel.Location = new System.Drawing.Point(205, 9);
            this.lblGameLevel.Name = "lblGameLevel";
            this.lblGameLevel.Size = new System.Drawing.Size(42, 14);
            this.lblGameLevel.TabIndex = 7;
            this.lblGameLevel.Text = "Game:";
            // 
            // tmrGameOver
            // 
            this.tmrGameOver.Interval = 500;
            this.tmrGameOver.Tick += new System.EventHandler(this.tmrGameOver_Tick);
            // 
            // gbxNewItem
            // 
            this.gbxNewItem.Controls.Add(this.btnAddToFridge);
            this.gbxNewItem.Controls.Add(this.txtCost);
            this.gbxNewItem.Controls.Add(this.dtpPurchaseDate);
            this.gbxNewItem.Controls.Add(this.cbxCategory);
            this.gbxNewItem.Controls.Add(this.txtName);
            this.gbxNewItem.Controls.Add(this.lblCost);
            this.gbxNewItem.Controls.Add(this.lblPurchaseDate);
            this.gbxNewItem.Controls.Add(this.lblCategory);
            this.gbxNewItem.Controls.Add(this.lblName);
            this.gbxNewItem.Font = new System.Drawing.Font("Consolas", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxNewItem.Location = new System.Drawing.Point(28, 44);
            this.gbxNewItem.Name = "gbxNewItem";
            this.gbxNewItem.Size = new System.Drawing.Size(616, 185);
            this.gbxNewItem.TabIndex = 10;
            this.gbxNewItem.TabStop = false;
            this.gbxNewItem.Text = "Add New Item";
            // 
            // btnAddToFridge
            // 
            this.btnAddToFridge.Location = new System.Drawing.Point(350, 147);
            this.btnAddToFridge.Name = "btnAddToFridge";
            this.btnAddToFridge.Size = new System.Drawing.Size(182, 23);
            this.btnAddToFridge.TabIndex = 8;
            this.btnAddToFridge.Text = "Add To Fridge";
            this.btnAddToFridge.UseVisualStyleBackColor = true;
            this.btnAddToFridge.Click += new System.EventHandler(this.btnAddToFridge_Click);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(350, 117);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(242, 21);
            this.txtCost.TabIndex = 7;
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.Location = new System.Drawing.Point(350, 86);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(242, 21);
            this.dtpPurchaseDate.TabIndex = 6;
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Items.AddRange(new object[] {
            "food",
            "beverage"});
            this.cbxCategory.Location = new System.Drawing.Point(350, 55);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(242, 21);
            this.cbxCategory.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(350, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(242, 21);
            this.txtName.TabIndex = 4;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(29, 112);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(77, 14);
            this.lblCost.TabIndex = 3;
            this.lblCost.Text = "Gold Cost:";
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Location = new System.Drawing.Point(29, 86);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(105, 14);
            this.lblPurchaseDate.TabIndex = 2;
            this.lblPurchaseDate.Text = "Purchase date:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(29, 58);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(70, 14);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(29, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 14);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // gbxFridge
            // 
            this.gbxFridge.Controls.Add(this.btnConsumeSelectedItem);
            this.gbxFridge.Controls.Add(this.btnNumItemsPerCategory);
            this.gbxFridge.Controls.Add(this.btnBackToHome);
            this.gbxFridge.Controls.Add(this.btnThrowAway);
            this.gbxFridge.Controls.Add(this.btnEditItem);
            this.gbxFridge.Controls.Add(this.dgvFridge);
            this.gbxFridge.Font = new System.Drawing.Font("Consolas", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFridge.Location = new System.Drawing.Point(28, 235);
            this.gbxFridge.Name = "gbxFridge";
            this.gbxFridge.Size = new System.Drawing.Size(616, 296);
            this.gbxFridge.TabIndex = 11;
            this.gbxFridge.TabStop = false;
            this.gbxFridge.Text = "Fridge";
            // 
            // btnConsumeSelectedItem
            // 
            this.btnConsumeSelectedItem.Location = new System.Drawing.Point(29, 197);
            this.btnConsumeSelectedItem.Name = "btnConsumeSelectedItem";
            this.btnConsumeSelectedItem.Size = new System.Drawing.Size(105, 23);
            this.btnConsumeSelectedItem.TabIndex = 5;
            this.btnConsumeSelectedItem.Text = "Consume Item";
            this.btnConsumeSelectedItem.UseVisualStyleBackColor = true;
            this.btnConsumeSelectedItem.Click += new System.EventHandler(this.btnConsumeSelectedItem_Click);
            // 
            // btnNumItemsPerCategory
            // 
            this.btnNumItemsPerCategory.Location = new System.Drawing.Point(312, 246);
            this.btnNumItemsPerCategory.Name = "btnNumItemsPerCategory";
            this.btnNumItemsPerCategory.Size = new System.Drawing.Size(233, 23);
            this.btnNumItemsPerCategory.TabIndex = 4;
            this.btnNumItemsPerCategory.Text = "Number of Items Per Category";
            this.btnNumItemsPerCategory.UseVisualStyleBackColor = true;
            this.btnNumItemsPerCategory.Click += new System.EventHandler(this.btnNumItemsPerCategory_Click);
            // 
            // btnBackToHome
            // 
            this.btnBackToHome.Location = new System.Drawing.Point(37, 246);
            this.btnBackToHome.Name = "btnBackToHome";
            this.btnBackToHome.Size = new System.Drawing.Size(182, 23);
            this.btnBackToHome.TabIndex = 3;
            this.btnBackToHome.Text = "Back to Home";
            this.btnBackToHome.UseVisualStyleBackColor = true;
            this.btnBackToHome.Click += new System.EventHandler(this.btnBackToHome_Click);
            // 
            // btnThrowAway
            // 
            this.btnThrowAway.Location = new System.Drawing.Point(423, 197);
            this.btnThrowAway.Name = "btnThrowAway";
            this.btnThrowAway.Size = new System.Drawing.Size(160, 23);
            this.btnThrowAway.TabIndex = 2;
            this.btnThrowAway.Text = "Throw Item away";
            this.btnThrowAway.UseVisualStyleBackColor = true;
            this.btnThrowAway.Click += new System.EventHandler(this.btnThrowAway_Click);
            // 
            // btnEditItem
            // 
            this.btnEditItem.Location = new System.Drawing.Point(215, 197);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(149, 23);
            this.btnEditItem.TabIndex = 1;
            this.btnEditItem.Text = "Edit Item details";
            this.btnEditItem.UseVisualStyleBackColor = true;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // dgvFridge
            // 
            this.dgvFridge.AllowUserToAddRows = false;
            this.dgvFridge.AllowUserToDeleteRows = false;
            this.dgvFridge.AllowUserToResizeColumns = false;
            this.dgvFridge.AllowUserToResizeRows = false;
            this.dgvFridge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFridge.Location = new System.Drawing.Point(29, 28);
            this.dgvFridge.Name = "dgvFridge";
            this.dgvFridge.ReadOnly = true;
            this.dgvFridge.RowHeadersVisible = false;
            this.dgvFridge.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFridge.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvFridge.ShowCellErrors = false;
            this.dgvFridge.ShowCellToolTips = false;
            this.dgvFridge.ShowEditingIcon = false;
            this.dgvFridge.ShowRowErrors = false;
            this.dgvFridge.Size = new System.Drawing.Size(563, 154);
            this.dgvFridge.TabIndex = 0;
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblGold.Font = new System.Drawing.Font("Consolas", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGold.Location = new System.Drawing.Point(25, 11);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(42, 14);
            this.lblGold.TabIndex = 12;
            this.lblGold.Text = "Gold:";
            // 
            // frmFridge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 559);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.gbxFridge);
            this.Controls.Add(this.gbxNewItem);
            this.Controls.Add(this.lblSleepLevel);
            this.Controls.Add(this.lblHungerLevel);
            this.Controls.Add(this.lblGameLevel);
            this.Name = "frmFridge";
            this.Text = "Fridge";
            this.Shown += new System.EventHandler(this.frmFridge_Shown);
            this.gbxNewItem.ResumeLayout(false);
            this.gbxNewItem.PerformLayout();
            this.gbxFridge.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFridge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSleepLevel;
        private System.Windows.Forms.Label lblHungerLevel;
        private System.Windows.Forms.Label lblGameLevel;
        private System.Windows.Forms.Timer tmrGameOver;
        private System.Windows.Forms.GroupBox gbxNewItem;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblPurchaseDate;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbxFridge;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button btnNumItemsPerCategory;
        private System.Windows.Forms.Button btnBackToHome;
        private System.Windows.Forms.Button btnThrowAway;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.Button btnAddToFridge;
        private System.Windows.Forms.DataGridView dgvFridge;
        private System.Windows.Forms.Button btnConsumeSelectedItem;
    }
}