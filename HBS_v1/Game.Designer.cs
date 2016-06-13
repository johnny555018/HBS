namespace HBS_v1
{
    partial class Game
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bombImages = new System.Windows.Forms.ImageList(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.fireImages = new System.Windows.Forms.ImageList(this.components);
            this.player2 = new System.Windows.Forms.Label();
            this.player1 = new System.Windows.Forms.Label();
            this.player1MoveUp = new System.Windows.Forms.ImageList(this.components);
            this.player1MoveDown = new System.Windows.Forms.ImageList(this.components);
            this.player1MoveLeft = new System.Windows.Forms.ImageList(this.components);
            this.player1MoveRight = new System.Windows.Forms.ImageList(this.components);
            this.player2MoveUp = new System.Windows.Forms.ImageList(this.components);
            this.player2MoveDown = new System.Windows.Forms.ImageList(this.components);
            this.player2MoveLeft = new System.Windows.Forms.ImageList(this.components);
            this.player2MoveRight = new System.Windows.Forms.ImageList(this.components);
            this.itemImages = new System.Windows.Forms.ImageList(this.components);
            this.player1Die = new System.Windows.Forms.ImageList(this.components);
            this.player2Die = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Ground1.png");
            this.imageList1.Images.SetKeyName(1, "ground2-yellow.png");
            this.imageList1.Images.SetKeyName(2, "ground2_stone.png");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bombImages
            // 
            this.bombImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("bombImages.ImageStream")));
            this.bombImages.TransparentColor = System.Drawing.Color.Transparent;
            this.bombImages.Images.SetKeyName(0, "fire.png");
            this.bombImages.Images.SetKeyName(1, "water_ball_1.png");
            this.bombImages.Images.SetKeyName(2, "water_ball_3.png");
            this.bombImages.Images.SetKeyName(3, "water_ball_2.png");
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // fireImages
            // 
            this.fireImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fireImages.ImageStream")));
            this.fireImages.TransparentColor = System.Drawing.Color.Transparent;
            this.fireImages.Images.SetKeyName(0, "waterbomb_mid.png");
            this.fireImages.Images.SetKeyName(1, "waterbomb_up_mid.png");
            this.fireImages.Images.SetKeyName(2, "waterbomb_up.png");
            this.fireImages.Images.SetKeyName(3, "waterbomb_down_mid .png");
            this.fireImages.Images.SetKeyName(4, "waterbomb_down.png");
            this.fireImages.Images.SetKeyName(5, "waterbomb_left_mid.png");
            this.fireImages.Images.SetKeyName(6, "waterbomb_left.png");
            this.fireImages.Images.SetKeyName(7, "waterbomb_right_mid.png");
            this.fireImages.Images.SetKeyName(8, "waterbomb_right.png");
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.Transparent;
            this.player2.Image = global::HBS_v1.Properties.Resources.man3;
            this.player2.Location = new System.Drawing.Point(480, 125);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(40, 40);
            this.player2.TabIndex = 1;
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.Transparent;
            this.player1.Image = global::HBS_v1.Properties.Resources.slice07_07;
            this.player1.Location = new System.Drawing.Point(118, 125);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(40, 40);
            this.player1.TabIndex = 0;
            // 
            // player1MoveUp
            // 
            this.player1MoveUp.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("player1MoveUp.ImageStream")));
            this.player1MoveUp.TransparentColor = System.Drawing.Color.Transparent;
            this.player1MoveUp.Images.SetKeyName(0, "slice01_01.png");
            this.player1MoveUp.Images.SetKeyName(1, "slice01_01.png");
            this.player1MoveUp.Images.SetKeyName(2, "slice02_02.png");
            this.player1MoveUp.Images.SetKeyName(3, "slice02_02.png");
            this.player1MoveUp.Images.SetKeyName(4, "slice03_03.png");
            this.player1MoveUp.Images.SetKeyName(5, "slice03_03.png");
            this.player1MoveUp.Images.SetKeyName(6, "slice04_04.png");
            this.player1MoveUp.Images.SetKeyName(7, "slice04_04.png");
            this.player1MoveUp.Images.SetKeyName(8, "slice05_05.png");
            this.player1MoveUp.Images.SetKeyName(9, "slice05_05.png");
            this.player1MoveUp.Images.SetKeyName(10, "slice06_06.png");
            this.player1MoveUp.Images.SetKeyName(11, "slice06_06.png");
            // 
            // player1MoveDown
            // 
            this.player1MoveDown.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("player1MoveDown.ImageStream")));
            this.player1MoveDown.TransparentColor = System.Drawing.Color.Transparent;
            this.player1MoveDown.Images.SetKeyName(0, "slice07_07.png");
            this.player1MoveDown.Images.SetKeyName(1, "slice07_07.png");
            this.player1MoveDown.Images.SetKeyName(2, "slice08_08.png");
            this.player1MoveDown.Images.SetKeyName(3, "slice08_08.png");
            this.player1MoveDown.Images.SetKeyName(4, "slice09_09.png");
            this.player1MoveDown.Images.SetKeyName(5, "slice09_09.png");
            this.player1MoveDown.Images.SetKeyName(6, "slice10_10.png");
            this.player1MoveDown.Images.SetKeyName(7, "slice10_10.png");
            this.player1MoveDown.Images.SetKeyName(8, "slice11_11.png");
            this.player1MoveDown.Images.SetKeyName(9, "slice11_11.png");
            this.player1MoveDown.Images.SetKeyName(10, "slice12_12.png");
            this.player1MoveDown.Images.SetKeyName(11, "slice12_12.png");
            // 
            // player1MoveLeft
            // 
            this.player1MoveLeft.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("player1MoveLeft.ImageStream")));
            this.player1MoveLeft.TransparentColor = System.Drawing.Color.Transparent;
            this.player1MoveLeft.Images.SetKeyName(0, "slice13_13.png");
            this.player1MoveLeft.Images.SetKeyName(1, "slice13_13.png");
            this.player1MoveLeft.Images.SetKeyName(2, "slice14_14.png");
            this.player1MoveLeft.Images.SetKeyName(3, "slice14_14.png");
            this.player1MoveLeft.Images.SetKeyName(4, "slice15_15.png");
            this.player1MoveLeft.Images.SetKeyName(5, "slice15_15.png");
            this.player1MoveLeft.Images.SetKeyName(6, "slice16_16.png");
            this.player1MoveLeft.Images.SetKeyName(7, "slice16_16.png");
            this.player1MoveLeft.Images.SetKeyName(8, "slice17_17.png");
            this.player1MoveLeft.Images.SetKeyName(9, "slice17_17.png");
            this.player1MoveLeft.Images.SetKeyName(10, "slice18_18.png");
            this.player1MoveLeft.Images.SetKeyName(11, "slice18_18.png");
            // 
            // player1MoveRight
            // 
            this.player1MoveRight.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("player1MoveRight.ImageStream")));
            this.player1MoveRight.TransparentColor = System.Drawing.Color.Transparent;
            this.player1MoveRight.Images.SetKeyName(0, "slice19_19.png");
            this.player1MoveRight.Images.SetKeyName(1, "slice19_19.png");
            this.player1MoveRight.Images.SetKeyName(2, "slice20_20.png");
            this.player1MoveRight.Images.SetKeyName(3, "slice20_20.png");
            this.player1MoveRight.Images.SetKeyName(4, "slice21_21.png");
            this.player1MoveRight.Images.SetKeyName(5, "slice21_21.png");
            this.player1MoveRight.Images.SetKeyName(6, "slice22_22.png");
            this.player1MoveRight.Images.SetKeyName(7, "slice22_22.png");
            this.player1MoveRight.Images.SetKeyName(8, "slice23_23.png");
            this.player1MoveRight.Images.SetKeyName(9, "slice23_23.png");
            this.player1MoveRight.Images.SetKeyName(10, "slice24_24.png");
            this.player1MoveRight.Images.SetKeyName(11, "slice24_24.png");
            // 
            // player2MoveUp
            // 
            this.player2MoveUp.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("player2MoveUp.ImageStream")));
            this.player2MoveUp.TransparentColor = System.Drawing.Color.Transparent;
            this.player2MoveUp.Images.SetKeyName(0, "slice01_01.png");
            this.player2MoveUp.Images.SetKeyName(1, "slice01_01.png");
            this.player2MoveUp.Images.SetKeyName(2, "slice02_02.png");
            this.player2MoveUp.Images.SetKeyName(3, "slice02_02.png");
            this.player2MoveUp.Images.SetKeyName(4, "slice03_03.png");
            this.player2MoveUp.Images.SetKeyName(5, "slice03_03.png");
            this.player2MoveUp.Images.SetKeyName(6, "slice04_04.png");
            this.player2MoveUp.Images.SetKeyName(7, "slice04_04.png");
            this.player2MoveUp.Images.SetKeyName(8, "slice05_05.png");
            this.player2MoveUp.Images.SetKeyName(9, "slice05_05.png");
            this.player2MoveUp.Images.SetKeyName(10, "slice06_06.png");
            this.player2MoveUp.Images.SetKeyName(11, "slice06_06.png");
            // 
            // player2MoveDown
            // 
            this.player2MoveDown.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("player2MoveDown.ImageStream")));
            this.player2MoveDown.TransparentColor = System.Drawing.Color.Transparent;
            this.player2MoveDown.Images.SetKeyName(0, "slice07_07.png");
            this.player2MoveDown.Images.SetKeyName(1, "slice07_07.png");
            this.player2MoveDown.Images.SetKeyName(2, "slice08_08.png");
            this.player2MoveDown.Images.SetKeyName(3, "slice08_08.png");
            this.player2MoveDown.Images.SetKeyName(4, "slice09_09.png");
            this.player2MoveDown.Images.SetKeyName(5, "slice09_09.png");
            this.player2MoveDown.Images.SetKeyName(6, "slice10_10.png");
            this.player2MoveDown.Images.SetKeyName(7, "slice10_10.png");
            this.player2MoveDown.Images.SetKeyName(8, "slice11_11.png");
            this.player2MoveDown.Images.SetKeyName(9, "slice11_11.png");
            this.player2MoveDown.Images.SetKeyName(10, "slice12_12.png");
            this.player2MoveDown.Images.SetKeyName(11, "slice12_12.png");
            // 
            // player2MoveLeft
            // 
            this.player2MoveLeft.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("player2MoveLeft.ImageStream")));
            this.player2MoveLeft.TransparentColor = System.Drawing.Color.Transparent;
            this.player2MoveLeft.Images.SetKeyName(0, "slice13_13.png");
            this.player2MoveLeft.Images.SetKeyName(1, "slice13_13.png");
            this.player2MoveLeft.Images.SetKeyName(2, "slice14_14.png");
            this.player2MoveLeft.Images.SetKeyName(3, "slice14_14.png");
            this.player2MoveLeft.Images.SetKeyName(4, "slice15_15.png");
            this.player2MoveLeft.Images.SetKeyName(5, "slice15_15.png");
            this.player2MoveLeft.Images.SetKeyName(6, "slice16_16.png");
            this.player2MoveLeft.Images.SetKeyName(7, "slice16_16.png");
            this.player2MoveLeft.Images.SetKeyName(8, "slice17_17.png");
            this.player2MoveLeft.Images.SetKeyName(9, "slice17_17.png");
            this.player2MoveLeft.Images.SetKeyName(10, "slice18_18.png");
            this.player2MoveLeft.Images.SetKeyName(11, "slice18_18.png");
            // 
            // player2MoveRight
            // 
            this.player2MoveRight.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("player2MoveRight.ImageStream")));
            this.player2MoveRight.TransparentColor = System.Drawing.Color.Transparent;
            this.player2MoveRight.Images.SetKeyName(0, "slice19_19.png");
            this.player2MoveRight.Images.SetKeyName(1, "slice19_19.png");
            this.player2MoveRight.Images.SetKeyName(2, "slice20_20.png");
            this.player2MoveRight.Images.SetKeyName(3, "slice20_20.png");
            this.player2MoveRight.Images.SetKeyName(4, "slice21_21.png");
            this.player2MoveRight.Images.SetKeyName(5, "slice21_21.png");
            this.player2MoveRight.Images.SetKeyName(6, "slice22_22.png");
            this.player2MoveRight.Images.SetKeyName(7, "slice22_22.png");
            this.player2MoveRight.Images.SetKeyName(8, "slice23_23.png");
            this.player2MoveRight.Images.SetKeyName(9, "slice23_23.png");
            this.player2MoveRight.Images.SetKeyName(10, "slice24_24.png");
            this.player2MoveRight.Images.SetKeyName(11, "slice24_24.png");
            // 
            // itemImages
            // 
            this.itemImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("itemImages.ImageStream")));
            this.itemImages.TransparentColor = System.Drawing.Color.Transparent;
            this.itemImages.Images.SetKeyName(0, "slice01_01.png");
            this.itemImages.Images.SetKeyName(1, "g2_shoe1_1.png");
            this.itemImages.Images.SetKeyName(2, "g2_blue_1.png");
            this.itemImages.Images.SetKeyName(3, "g2_poison1.png");
            // 
            // player1Die
            // 
            this.player1Die.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("player1Die.ImageStream")));
            this.player1Die.TransparentColor = System.Drawing.Color.Transparent;
            this.player1Die.Images.SetKeyName(0, "slice01_01.png");
            this.player1Die.Images.SetKeyName(1, "slice02_02.png");
            this.player1Die.Images.SetKeyName(2, "slice03_03.png");
            this.player1Die.Images.SetKeyName(3, "slice04_04.png");
            this.player1Die.Images.SetKeyName(4, "slice05_05.png");
            this.player1Die.Images.SetKeyName(5, "slice06_06.png");
            this.player1Die.Images.SetKeyName(6, "slice07_07.png");
            this.player1Die.Images.SetKeyName(7, "slice08_08.png");
            this.player1Die.Images.SetKeyName(8, "slice09_09.png");
            this.player1Die.Images.SetKeyName(9, "slice10_10.png");
            this.player1Die.Images.SetKeyName(10, "slice12_12.png");
            // 
            // player2Die
            // 
            this.player2Die.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("player2Die.ImageStream")));
            this.player2Die.TransparentColor = System.Drawing.Color.Transparent;
            this.player2Die.Images.SetKeyName(0, "slice01_01.png");
            this.player2Die.Images.SetKeyName(1, "slice02_02.png");
            this.player2Die.Images.SetKeyName(2, "slice03_03.png");
            this.player2Die.Images.SetKeyName(3, "slice04_04.png");
            this.player2Die.Images.SetKeyName(4, "slice05_05.png");
            this.player2Die.Images.SetKeyName(5, "slice06_06.png");
            this.player2Die.Images.SetKeyName(6, "slice07_07.png");
            this.player2Die.Images.SetKeyName(7, "slice08_08.png");
            this.player2Die.Images.SetKeyName(8, "slice09_09.png");
            this.player2Die.Images.SetKeyName(9, "slice10_10.png");
            this.player2Die.Images.SetKeyName(10, "slice12_12.png");
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.DoubleBuffered = true;
            this.Name = "Game";
            this.Text = "HBS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label player1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList bombImages;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ImageList fireImages;
        private System.Windows.Forms.Label player2;
        private System.Windows.Forms.ImageList player1MoveUp;
        private System.Windows.Forms.ImageList player1MoveDown;
        private System.Windows.Forms.ImageList player1MoveLeft;
        private System.Windows.Forms.ImageList player1MoveRight;
        private System.Windows.Forms.ImageList player2MoveUp;
        private System.Windows.Forms.ImageList player2MoveDown;
        private System.Windows.Forms.ImageList player2MoveLeft;
        private System.Windows.Forms.ImageList player2MoveRight;
        private System.Windows.Forms.ImageList itemImages;
        private System.Windows.Forms.ImageList player1Die;
        private System.Windows.Forms.ImageList player2Die;
    }
}

