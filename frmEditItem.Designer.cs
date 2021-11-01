
namespace INF164HWAss1
{
    partial class frmEditItem
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
            this.btnEditDetails = new System.Windows.Forms.Button();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEditDetails
            // 
            this.btnEditDetails.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDetails.Location = new System.Drawing.Point(184, 172);
            this.btnEditDetails.Name = "btnEditDetails";
            this.btnEditDetails.Size = new System.Drawing.Size(110, 23);
            this.btnEditDetails.TabIndex = 8;
            this.btnEditDetails.Text = "Edit Details";
            this.btnEditDetails.UseVisualStyleBackColor = true;
            this.btnEditDetails.Click += new System.EventHandler(this.btnEditDetails_Click);
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(184, 134);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(226, 22);
            this.txtCost.TabIndex = 7;
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPurchaseDate.Location = new System.Drawing.Point(184, 97);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(226, 22);
            this.dtpPurchaseDate.TabIndex = 6;
            // 
            // cbxCategory
            // 
            this.cbxCategory.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Items.AddRange(new object[] {
            "beverage",
            "food"});
            this.cbxCategory.Location = new System.Drawing.Point(184, 58);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(226, 22);
            this.cbxCategory.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(184, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(226, 22);
            this.txtName.TabIndex = 4;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(29, 141);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(77, 14);
            this.lblCost.TabIndex = 3;
            this.lblCost.Text = "Gold Cost:";
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseDate.Location = new System.Drawing.Point(29, 103);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(105, 14);
            this.lblPurchaseDate.TabIndex = 2;
            this.lblPurchaseDate.Text = "Purchase date:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(29, 61);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(70, 14);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(29, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 14);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // frmEditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 234);
            this.Controls.Add(this.btnEditDetails);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dtpPurchaseDate);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.lblPurchaseDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCost);
            this.Name = "frmEditItem";
            this.Text = "Edit Item";
            this.Shown += new System.EventHandler(this.frmEditItem_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditDetails;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblPurchaseDate;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblName;
    }
}