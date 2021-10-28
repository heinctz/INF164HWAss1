
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
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblExpired = new System.Windows.Forms.Label();
            this.lblCompost = new System.Windows.Forms.Label();
            this.btnAddCompost = new System.Windows.Forms.Button();
            this.btnExpired = new System.Windows.Forms.Button();
            this.btnCalculateNum_category = new System.Windows.Forms.Button();
            this.dgvFridge = new System.Windows.Forms.DataGridView();
            this.btnEat = new System.Windows.Forms.Button();
            this.btnKitchen_Back = new System.Windows.Forms.Button();
            this.gbxKitchen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFridge)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxKitchen
            // 
            this.gbxKitchen.Controls.Add(this.btnKitchen_Back);
            this.gbxKitchen.Controls.Add(this.lblCategory);
            this.gbxKitchen.Controls.Add(this.lblExpired);
            this.gbxKitchen.Controls.Add(this.lblCompost);
            this.gbxKitchen.Controls.Add(this.btnAddCompost);
            this.gbxKitchen.Controls.Add(this.btnExpired);
            this.gbxKitchen.Controls.Add(this.btnCalculateNum_category);
            this.gbxKitchen.Controls.Add(this.dgvFridge);
            this.gbxKitchen.Controls.Add(this.btnEat);
            this.gbxKitchen.Location = new System.Drawing.Point(4, 12);
            this.gbxKitchen.Name = "gbxKitchen";
            this.gbxKitchen.Size = new System.Drawing.Size(732, 437);
            this.gbxKitchen.TabIndex = 0;
            this.gbxKitchen.TabStop = false;
            this.gbxKitchen.Text = "Kitchen";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(11, 303);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(186, 13);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Calculate number of items in category:";
            // 
            // lblExpired
            // 
            this.lblExpired.AutoSize = true;
            this.lblExpired.Location = new System.Drawing.Point(11, 350);
            this.lblExpired.Name = "lblExpired";
            this.lblExpired.Size = new System.Drawing.Size(207, 13);
            this.lblExpired.TabIndex = 7;
            this.lblExpired.Text = "Calculate number of items that are expired:";
            // 
            // lblCompost
            // 
            this.lblCompost.AutoSize = true;
            this.lblCompost.Location = new System.Drawing.Point(11, 394);
            this.lblCompost.Name = "lblCompost";
            this.lblCompost.Size = new System.Drawing.Size(158, 13);
            this.lblCompost.TabIndex = 6;
            this.lblCompost.Text = "Add an item to the compost pile:";
            // 
            // btnAddCompost
            // 
            this.btnAddCompost.Location = new System.Drawing.Point(264, 394);
            this.btnAddCompost.Name = "btnAddCompost";
            this.btnAddCompost.Size = new System.Drawing.Size(142, 23);
            this.btnAddCompost.TabIndex = 5;
            this.btnAddCompost.Text = "Add to Compost";
            this.btnAddCompost.UseVisualStyleBackColor = true;
            this.btnAddCompost.Click += new System.EventHandler(this.btnAddCompost_Click);
            // 
            // btnExpired
            // 
            this.btnExpired.Location = new System.Drawing.Point(264, 350);
            this.btnExpired.Name = "btnExpired";
            this.btnExpired.Size = new System.Drawing.Size(142, 23);
            this.btnExpired.TabIndex = 4;
            this.btnExpired.Text = "Calculate Expired Items";
            this.btnExpired.UseVisualStyleBackColor = true;
            this.btnExpired.Click += new System.EventHandler(this.btnExpired_Click);
            // 
            // btnCalculateNum_category
            // 
            this.btnCalculateNum_category.Location = new System.Drawing.Point(264, 303);
            this.btnCalculateNum_category.Name = "btnCalculateNum_category";
            this.btnCalculateNum_category.Size = new System.Drawing.Size(142, 23);
            this.btnCalculateNum_category.TabIndex = 1;
            this.btnCalculateNum_category.Text = "Calculate Category";
            this.btnCalculateNum_category.UseVisualStyleBackColor = true;
            this.btnCalculateNum_category.Click += new System.EventHandler(this.btnCalculateNum_category_Click);
            // 
            // dgvFridge
            // 
            this.dgvFridge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFridge.Location = new System.Drawing.Point(44, 48);
            this.dgvFridge.Name = "dgvFridge";
            this.dgvFridge.Size = new System.Drawing.Size(545, 225);
            this.dgvFridge.TabIndex = 1;
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
            this.btnEat.Click += new System.EventHandler(this.btnEat_Click);
            // 
            // btnKitchen_Back
            // 
            this.btnKitchen_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKitchen_Back.Location = new System.Drawing.Point(604, 383);
            this.btnKitchen_Back.Name = "btnKitchen_Back";
            this.btnKitchen_Back.Size = new System.Drawing.Size(94, 34);
            this.btnKitchen_Back.TabIndex = 1;
            this.btnKitchen_Back.Text = "BACK";
            this.btnKitchen_Back.UseVisualStyleBackColor = true;
            this.btnKitchen_Back.Click += new System.EventHandler(this.btnKitchen_Back_Click);
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
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblExpired;
        private System.Windows.Forms.Label lblCompost;
        private System.Windows.Forms.Button btnAddCompost;
        private System.Windows.Forms.Button btnExpired;
        private System.Windows.Forms.Button btnCalculateNum_category;
        private System.Windows.Forms.DataGridView dgvFridge;
        private System.Windows.Forms.Button btnKitchen_Back;
    }
}