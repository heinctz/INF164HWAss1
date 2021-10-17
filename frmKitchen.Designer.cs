
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
            this.lblBeverage = new System.Windows.Forms.Label();
            this.lblFood_Item = new System.Windows.Forms.Label();
            this.cmbBeverage = new System.Windows.Forms.ComboBox();
            this.cmbFood_item = new System.Windows.Forms.ComboBox();
            this.btnEat = new System.Windows.Forms.Button();
            this.gbxKitchen.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxKitchen
            // 
            this.gbxKitchen.Controls.Add(this.btnEat);
            this.gbxKitchen.Controls.Add(this.cmbFood_item);
            this.gbxKitchen.Controls.Add(this.cmbBeverage);
            this.gbxKitchen.Controls.Add(this.lblFood_Item);
            this.gbxKitchen.Controls.Add(this.lblBeverage);
            this.gbxKitchen.Location = new System.Drawing.Point(57, 51);
            this.gbxKitchen.Name = "gbxKitchen";
            this.gbxKitchen.Size = new System.Drawing.Size(380, 233);
            this.gbxKitchen.TabIndex = 0;
            this.gbxKitchen.TabStop = false;
            this.gbxKitchen.Text = "Kitchen";
            // 
            // lblBeverage
            // 
            this.lblBeverage.AutoSize = true;
            this.lblBeverage.Location = new System.Drawing.Point(40, 40);
            this.lblBeverage.Name = "lblBeverage";
            this.lblBeverage.Size = new System.Drawing.Size(97, 13);
            this.lblBeverage.TabIndex = 0;
            this.lblBeverage.Text = "Select a beverage:";
            // 
            // lblFood_Item
            // 
            this.lblFood_Item.AutoSize = true;
            this.lblFood_Item.Location = new System.Drawing.Point(228, 40);
            this.lblFood_Item.Name = "lblFood_Item";
            this.lblFood_Item.Size = new System.Drawing.Size(95, 13);
            this.lblFood_Item.TabIndex = 1;
            this.lblFood_Item.Text = "Select a food item:";
            // 
            // cmbBeverage
            // 
            this.cmbBeverage.FormattingEnabled = true;
            this.cmbBeverage.Items.AddRange(new object[] {
            "Soda",
            "Water",
            "Juice",
            "Coffee"});
            this.cmbBeverage.Location = new System.Drawing.Point(43, 75);
            this.cmbBeverage.Name = "cmbBeverage";
            this.cmbBeverage.Size = new System.Drawing.Size(121, 21);
            this.cmbBeverage.TabIndex = 1;
            // 
            // cmbFood_item
            // 
            this.cmbFood_item.FormattingEnabled = true;
            this.cmbFood_item.Items.AddRange(new object[] {
            "Apple",
            "Bread",
            "Fish",
            "Burger"});
            this.cmbFood_item.Location = new System.Drawing.Point(231, 75);
            this.cmbFood_item.Name = "cmbFood_item";
            this.cmbFood_item.Size = new System.Drawing.Size(121, 21);
            this.cmbFood_item.TabIndex = 2;
            // 
            // btnEat
            // 
            this.btnEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEat.Location = new System.Drawing.Point(146, 168);
            this.btnEat.Name = "btnEat";
            this.btnEat.Size = new System.Drawing.Size(94, 41);
            this.btnEat.TabIndex = 3;
            this.btnEat.Text = "EAT!!!";
            this.btnEat.UseVisualStyleBackColor = true;
            // 
            // frmKitchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxKitchen);
            this.Name = "frmKitchen";
            this.Text = "frmKitchen";
            this.gbxKitchen.ResumeLayout(false);
            this.gbxKitchen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxKitchen;
        private System.Windows.Forms.Button btnEat;
        private System.Windows.Forms.ComboBox cmbFood_item;
        private System.Windows.Forms.ComboBox cmbBeverage;
        private System.Windows.Forms.Label lblFood_Item;
        private System.Windows.Forms.Label lblBeverage;
    }
}