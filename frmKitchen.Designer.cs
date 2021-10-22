﻿
namespace INF164HWAss1
{
    partial class frmKitchen
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
            this.gbxKitchen = new System.Windows.Forms.GroupBox();
            this.lblAddItem = new System.Windows.Forms.Label();
            this.lblRemove = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblExpired = new System.Windows.Forms.Label();
            this.lblCompost = new System.Windows.Forms.Label();
            this.btnAddCompost = new System.Windows.Forms.Button();
            this.btnExpired = new System.Windows.Forms.Button();
            this.btnCalculateNum_category = new System.Windows.Forms.Button();
            this.btnRemove_Item = new System.Windows.Forms.Button();
            this.btnAdd_Item = new System.Windows.Forms.Button();
            this.dgvFridge = new System.Windows.Forms.DataGridView();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDatePurchased = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvExpire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEat = new System.Windows.Forms.Button();
            this.gbxKitchen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFridge)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxKitchen
            // 
            this.gbxKitchen.Controls.Add(this.lblAddItem);
            this.gbxKitchen.Controls.Add(this.lblRemove);
            this.gbxKitchen.Controls.Add(this.lblCategory);
            this.gbxKitchen.Controls.Add(this.lblExpired);
            this.gbxKitchen.Controls.Add(this.lblCompost);
            this.gbxKitchen.Controls.Add(this.btnAddCompost);
            this.gbxKitchen.Controls.Add(this.btnExpired);
            this.gbxKitchen.Controls.Add(this.btnCalculateNum_category);
            this.gbxKitchen.Controls.Add(this.btnRemove_Item);
            this.gbxKitchen.Controls.Add(this.btnAdd_Item);
            this.gbxKitchen.Controls.Add(this.dgvFridge);
            this.gbxKitchen.Controls.Add(this.btnEat);
            this.gbxKitchen.Location = new System.Drawing.Point(4, 12);
            this.gbxKitchen.Name = "gbxKitchen";
            this.gbxKitchen.Size = new System.Drawing.Size(732, 437);
            this.gbxKitchen.TabIndex = 0;
            this.gbxKitchen.TabStop = false;
            this.gbxKitchen.Text = "Kitchen";
            // 
            // lblAddItem
            // 
            this.lblAddItem.AutoSize = true;
            this.lblAddItem.Location = new System.Drawing.Point(11, 289);
            this.lblAddItem.Name = "lblAddItem";
            this.lblAddItem.Size = new System.Drawing.Size(108, 13);
            this.lblAddItem.TabIndex = 10;
            this.lblAddItem.Text = "Add item to The fride:";
            // 
            // lblRemove
            // 
            this.lblRemove.AutoSize = true;
            this.lblRemove.Location = new System.Drawing.Point(11, 319);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(118, 13);
            this.lblRemove.TabIndex = 9;
            this.lblRemove.Text = "Remove item from fride:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(11, 349);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(186, 13);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Calculate number of items in category:";
            // 
            // lblExpired
            // 
            this.lblExpired.AutoSize = true;
            this.lblExpired.Location = new System.Drawing.Point(11, 382);
            this.lblExpired.Name = "lblExpired";
            this.lblExpired.Size = new System.Drawing.Size(240, 13);
            this.lblExpired.TabIndex = 7;
            this.lblExpired.Text = "Calculate number of items that are almost expired:";
            // 
            // lblCompost
            // 
            this.lblCompost.AutoSize = true;
            this.lblCompost.Location = new System.Drawing.Point(11, 413);
            this.lblCompost.Name = "lblCompost";
            this.lblCompost.Size = new System.Drawing.Size(158, 13);
            this.lblCompost.TabIndex = 6;
            this.lblCompost.Text = "Add an item to the compost pile:";
            // 
            // btnAddCompost
            // 
            this.btnAddCompost.Location = new System.Drawing.Point(264, 408);
            this.btnAddCompost.Name = "btnAddCompost";
            this.btnAddCompost.Size = new System.Drawing.Size(142, 23);
            this.btnAddCompost.TabIndex = 5;
            this.btnAddCompost.Text = "Add to Compost";
            this.btnAddCompost.UseVisualStyleBackColor = true;
            // 
            // btnExpired
            // 
            this.btnExpired.Location = new System.Drawing.Point(264, 377);
            this.btnExpired.Name = "btnExpired";
            this.btnExpired.Size = new System.Drawing.Size(142, 23);
            this.btnExpired.TabIndex = 4;
            this.btnExpired.Text = "Calculate Almost Expired";
            this.btnExpired.UseVisualStyleBackColor = true;
            // 
            // btnCalculateNum_category
            // 
            this.btnCalculateNum_category.Location = new System.Drawing.Point(264, 344);
            this.btnCalculateNum_category.Name = "btnCalculateNum_category";
            this.btnCalculateNum_category.Size = new System.Drawing.Size(142, 23);
            this.btnCalculateNum_category.TabIndex = 1;
            this.btnCalculateNum_category.Text = "Calculate Category";
            this.btnCalculateNum_category.UseVisualStyleBackColor = true;
            // 
            // btnRemove_Item
            // 
            this.btnRemove_Item.Location = new System.Drawing.Point(264, 313);
            this.btnRemove_Item.Name = "btnRemove_Item";
            this.btnRemove_Item.Size = new System.Drawing.Size(142, 25);
            this.btnRemove_Item.TabIndex = 1;
            this.btnRemove_Item.Text = "Remove Item";
            this.btnRemove_Item.UseVisualStyleBackColor = true;
            // 
            // btnAdd_Item
            // 
            this.btnAdd_Item.Location = new System.Drawing.Point(264, 282);
            this.btnAdd_Item.Name = "btnAdd_Item";
            this.btnAdd_Item.Size = new System.Drawing.Size(142, 26);
            this.btnAdd_Item.TabIndex = 2;
            this.btnAdd_Item.Text = "Add Item";
            this.btnAdd_Item.UseVisualStyleBackColor = true;
            // 
            // dgvFridge
            // 
            this.dgvFridge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFridge.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvName,
            this.dgvCategory,
            this.dgvDatePurchased,
            this.dgvExpire,
            this.dgvCost});
            this.dgvFridge.Location = new System.Drawing.Point(44, 48);
            this.dgvFridge.Name = "dgvFridge";
            this.dgvFridge.Size = new System.Drawing.Size(545, 225);
            this.dgvFridge.TabIndex = 1;
            // 
            // dgvName
            // 
            this.dgvName.HeaderText = "Name";
            this.dgvName.Name = "dgvName";
            // 
            // dgvCategory
            // 
            this.dgvCategory.HeaderText = "Category";
            this.dgvCategory.Name = "dgvCategory";
            // 
            // dgvDatePurchased
            // 
            this.dgvDatePurchased.HeaderText = "Date Purchased";
            this.dgvDatePurchased.Name = "dgvDatePurchased";
            // 
            // dgvExpire
            // 
            this.dgvExpire.HeaderText = "Expire Date";
            this.dgvExpire.Name = "dgvExpire";
            // 
            // dgvCost
            // 
            this.dgvCost.HeaderText = "Purchase Cost";
            this.dgvCost.Name = "dgvCost";
            // 
            // btnEat
            // 
            this.btnEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEat.Location = new System.Drawing.Point(604, 48);
            this.btnEat.Name = "btnEat";
            this.btnEat.Size = new System.Drawing.Size(94, 34);
            this.btnEat.TabIndex = 3;
            this.btnEat.Text = "EAT!!!";
            this.btnEat.UseVisualStyleBackColor = true;
            // 
            // frmKitchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.Controls.Add(this.gbxKitchen);
            this.Name = "frmKitchen";
            this.Text = "frmKitchen";
            this.Load += new System.EventHandler(this.frmKitchen_Load);
            this.gbxKitchen.ResumeLayout(false);
            this.gbxKitchen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFridge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxKitchen;
        private System.Windows.Forms.Button btnEat;
        private System.Windows.Forms.Label lblAddItem;
        private System.Windows.Forms.Label lblRemove;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblExpired;
        private System.Windows.Forms.Label lblCompost;
        private System.Windows.Forms.Button btnAddCompost;
        private System.Windows.Forms.Button btnExpired;
        private System.Windows.Forms.Button btnCalculateNum_category;
        private System.Windows.Forms.Button btnRemove_Item;
        private System.Windows.Forms.Button btnAdd_Item;
        private System.Windows.Forms.DataGridView dgvFridge;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDatePurchased;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvExpire;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCost;
    }
}