
namespace INF164HWAss1
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.btnGame = new System.Windows.Forms.Button();
            this.btnFridge = new System.Windows.Forms.Button();
            this.btnSleep = new System.Windows.Forms.Button();
            this.lblGold = new System.Windows.Forms.Label();
            this.gbxTop = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSleepLevel = new System.Windows.Forms.Label();
            this.lblHungerLevel = new System.Windows.Forms.Label();
            this.lblGameLevel = new System.Windows.Forms.Label();
            this.gbxBottom = new System.Windows.Forms.GroupBox();
            this.imlTamagochiStates = new System.Windows.Forms.ImageList(this.components);
            this.tmrUpdateTamagotchiImage = new System.Windows.Forms.Timer(this.components);
            this.pbxTamagotchiState = new System.Windows.Forms.PictureBox();
            this.tmrGameOver = new System.Windows.Forms.Timer(this.components);
            this.tmrIncreaseSleep = new System.Windows.Forms.Timer(this.components);
            this.gbxTop.SuspendLayout();
            this.gbxBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTamagotchiState)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGame
            // 
            this.btnGame.Location = new System.Drawing.Point(115, 19);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(63, 40);
            this.btnGame.TabIndex = 0;
            this.btnGame.Text = "Game";
            this.btnGame.UseVisualStyleBackColor = true;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // btnFridge
            // 
            this.btnFridge.Location = new System.Drawing.Point(212, 19);
            this.btnFridge.Name = "btnFridge";
            this.btnFridge.Size = new System.Drawing.Size(71, 40);
            this.btnFridge.TabIndex = 1;
            this.btnFridge.Text = "Fridge";
            this.btnFridge.UseVisualStyleBackColor = true;
            this.btnFridge.Click += new System.EventHandler(this.btnKitchen_Click);
            // 
            // btnSleep
            // 
            this.btnSleep.Location = new System.Drawing.Point(319, 19);
            this.btnSleep.Name = "btnSleep";
            this.btnSleep.Size = new System.Drawing.Size(63, 40);
            this.btnSleep.TabIndex = 2;
            this.btnSleep.Text = "Sleep";
            this.btnSleep.UseVisualStyleBackColor = true;
            this.btnSleep.Click += new System.EventHandler(this.btnSleep_Click);
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblGold.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGold.Location = new System.Drawing.Point(12, 40);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(42, 15);
            this.lblGold.TabIndex = 3;
            this.lblGold.Text = "Gold:";
            // 
            // gbxTop
            // 
            this.gbxTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbxTop.Controls.Add(this.btnExit);
            this.gbxTop.Controls.Add(this.lblSleepLevel);
            this.gbxTop.Controls.Add(this.lblHungerLevel);
            this.gbxTop.Controls.Add(this.lblGameLevel);
            this.gbxTop.Controls.Add(this.lblGold);
            this.gbxTop.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTop.Location = new System.Drawing.Point(0, -5);
            this.gbxTop.Name = "gbxTop";
            this.gbxTop.Size = new System.Drawing.Size(529, 85);
            this.gbxTop.TabIndex = 5;
            this.gbxTop.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Tomato;
            this.btnExit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(444, 31);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(51, 33);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblSleepLevel
            // 
            this.lblSleepLevel.AutoSize = true;
            this.lblSleepLevel.BackColor = System.Drawing.Color.Lime;
            this.lblSleepLevel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSleepLevel.Location = new System.Drawing.Point(316, 19);
            this.lblSleepLevel.Name = "lblSleepLevel";
            this.lblSleepLevel.Size = new System.Drawing.Size(77, 15);
            this.lblSleepLevel.TabIndex = 6;
            this.lblSleepLevel.Text = "Sleep: 100";
            // 
            // lblHungerLevel
            // 
            this.lblHungerLevel.AutoSize = true;
            this.lblHungerLevel.BackColor = System.Drawing.Color.Lime;
            this.lblHungerLevel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHungerLevel.Location = new System.Drawing.Point(209, 19);
            this.lblHungerLevel.Name = "lblHungerLevel";
            this.lblHungerLevel.Size = new System.Drawing.Size(84, 15);
            this.lblHungerLevel.TabIndex = 5;
            this.lblHungerLevel.Text = "Hunger: 100";
            // 
            // lblGameLevel
            // 
            this.lblGameLevel.AutoSize = true;
            this.lblGameLevel.BackColor = System.Drawing.Color.Lime;
            this.lblGameLevel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameLevel.Location = new System.Drawing.Point(112, 19);
            this.lblGameLevel.Name = "lblGameLevel";
            this.lblGameLevel.Size = new System.Drawing.Size(70, 15);
            this.lblGameLevel.TabIndex = 4;
            this.lblGameLevel.Text = "Game: 100";
            // 
            // gbxBottom
            // 
            this.gbxBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbxBottom.Controls.Add(this.btnGame);
            this.gbxBottom.Controls.Add(this.btnFridge);
            this.gbxBottom.Controls.Add(this.btnSleep);
            this.gbxBottom.Location = new System.Drawing.Point(0, 394);
            this.gbxBottom.Name = "gbxBottom";
            this.gbxBottom.Size = new System.Drawing.Size(529, 81);
            this.gbxBottom.TabIndex = 4;
            this.gbxBottom.TabStop = false;
            // 
            // imlTamagochiStates
            // 
            this.imlTamagochiStates.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlTamagochiStates.ImageStream")));
            this.imlTamagochiStates.TransparentColor = System.Drawing.Color.Transparent;
            this.imlTamagochiStates.Images.SetKeyName(0, "state1.png");
            this.imlTamagochiStates.Images.SetKeyName(1, "state2.png");
            this.imlTamagochiStates.Images.SetKeyName(2, "state3.png");
            this.imlTamagochiStates.Images.SetKeyName(3, "state4.png");
            this.imlTamagochiStates.Images.SetKeyName(4, "state5.png");
            this.imlTamagochiStates.Images.SetKeyName(5, "state6.png");
            this.imlTamagochiStates.Images.SetKeyName(6, "state7.png");
            this.imlTamagochiStates.Images.SetKeyName(7, "state8.png");
            // 
            // tmrUpdateTamagotchiImage
            // 
            this.tmrUpdateTamagotchiImage.Interval = 500;
            this.tmrUpdateTamagotchiImage.Tick += new System.EventHandler(this.tmrUpdateTamagotchiImage_Tick);
            // 
            // pbxTamagotchiState
            // 
            this.pbxTamagotchiState.Location = new System.Drawing.Point(143, 132);
            this.pbxTamagotchiState.Name = "pbxTamagotchiState";
            this.pbxTamagotchiState.Size = new System.Drawing.Size(200, 200);
            this.pbxTamagotchiState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxTamagotchiState.TabIndex = 6;
            this.pbxTamagotchiState.TabStop = false;
            // 
            // tmrGameOver
            // 
            this.tmrGameOver.Interval = 500;
            this.tmrGameOver.Tick += new System.EventHandler(this.tmrGameOver_Tick);
            // 
            // tmrIncreaseSleep
            // 
            this.tmrIncreaseSleep.Interval = 1000;
            this.tmrIncreaseSleep.Tick += new System.EventHandler(this.tmrIncreaseSleep_Tick);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 474);
            this.Controls.Add(this.pbxTamagotchiState);
            this.Controls.Add(this.gbxTop);
            this.Controls.Add(this.gbxBottom);
            this.Name = "frmHome";
            this.Text = "Home";
            this.Shown += new System.EventHandler(this.frmHome_Shown);
            this.gbxTop.ResumeLayout(false);
            this.gbxTop.PerformLayout();
            this.gbxBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxTamagotchiState)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Button btnFridge;
        private System.Windows.Forms.Button btnSleep;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.GroupBox gbxTop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSleepLevel;
        private System.Windows.Forms.Label lblHungerLevel;
        private System.Windows.Forms.Label lblGameLevel;
        private System.Windows.Forms.GroupBox gbxBottom;
        private System.Windows.Forms.ImageList imlTamagochiStates;
        private System.Windows.Forms.Timer tmrUpdateTamagotchiImage;
        private System.Windows.Forms.PictureBox pbxTamagotchiState;
        private System.Windows.Forms.Timer tmrGameOver;
        private System.Windows.Forms.Timer tmrIncreaseSleep;
    }
}