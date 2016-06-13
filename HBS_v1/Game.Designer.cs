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
            this.status_panel = new System.Windows.Forms.Panel();
            this.exit_button = new System.Windows.Forms.Label();
            this.water_2p = new System.Windows.Forms.Label();
            this.shoe_2p = new System.Windows.Forms.Label();
            this.bomb_2p = new System.Windows.Forms.Label();
            this.water_1p = new System.Windows.Forms.Label();
            this.shoe_1p = new System.Windows.Forms.Label();
            this.bomb_1p = new System.Windows.Forms.Label();
            this.shoe_pic = new System.Windows.Forms.Label();
            this.water_pic = new System.Windows.Forms.Label();
            this.title_2p = new System.Windows.Forms.Label();
            this.title_1p = new System.Windows.Forms.Label();
            this.bomb_pic = new System.Windows.Forms.Label();
            this.mouhow = new System.Windows.Forms.Label();
            this.second = new System.Windows.Forms.Label();
            this.minute = new System.Windows.Forms.Label();
            this.time_title = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.status_panel.SuspendLayout();
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
            // status_panel
            // 
            this.status_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.status_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.status_panel.Controls.Add(this.exit_button);
            this.status_panel.Controls.Add(this.water_2p);
            this.status_panel.Controls.Add(this.shoe_2p);
            this.status_panel.Controls.Add(this.bomb_2p);
            this.status_panel.Controls.Add(this.water_1p);
            this.status_panel.Controls.Add(this.shoe_1p);
            this.status_panel.Controls.Add(this.bomb_1p);
            this.status_panel.Controls.Add(this.shoe_pic);
            this.status_panel.Controls.Add(this.water_pic);
            this.status_panel.Controls.Add(this.title_2p);
            this.status_panel.Controls.Add(this.title_1p);
            this.status_panel.Controls.Add(this.bomb_pic);
            this.status_panel.Controls.Add(this.mouhow);
            this.status_panel.Controls.Add(this.second);
            this.status_panel.Controls.Add(this.minute);
            this.status_panel.Controls.Add(this.time_title);
            this.status_panel.Location = new System.Drawing.Point(721, 0);
            this.status_panel.Name = "status_panel";
            this.status_panel.Size = new System.Drawing.Size(163, 481);
            this.status_panel.TabIndex = 2;
            // 
            // exit_button
            // 
            this.exit_button.AutoSize = true;
            this.exit_button.BackColor = System.Drawing.Color.Red;
            this.exit_button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exit_button.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exit_button.ForeColor = System.Drawing.Color.White;
            this.exit_button.Location = new System.Drawing.Point(12, 429);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(138, 42);
            this.exit_button.TabIndex = 16;
            this.exit_button.Text = "跳game";
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // water_2p
            // 
            this.water_2p.AutoSize = true;
            this.water_2p.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.water_2p.ForeColor = System.Drawing.Color.Black;
            this.water_2p.Location = new System.Drawing.Point(112, 333);
            this.water_2p.Name = "water_2p";
            this.water_2p.Size = new System.Drawing.Size(36, 40);
            this.water_2p.TabIndex = 15;
            this.water_2p.Text = "0";
            this.water_2p.Visible = false;
            // 
            // shoe_2p
            // 
            this.shoe_2p.AutoSize = true;
            this.shoe_2p.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.shoe_2p.ForeColor = System.Drawing.Color.Black;
            this.shoe_2p.Location = new System.Drawing.Point(112, 255);
            this.shoe_2p.Name = "shoe_2p";
            this.shoe_2p.Size = new System.Drawing.Size(36, 40);
            this.shoe_2p.TabIndex = 14;
            this.shoe_2p.Text = "0";
            this.shoe_2p.Visible = false;
            // 
            // bomb_2p
            // 
            this.bomb_2p.AutoSize = true;
            this.bomb_2p.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bomb_2p.ForeColor = System.Drawing.Color.Black;
            this.bomb_2p.Location = new System.Drawing.Point(112, 175);
            this.bomb_2p.Name = "bomb_2p";
            this.bomb_2p.Size = new System.Drawing.Size(36, 40);
            this.bomb_2p.TabIndex = 13;
            this.bomb_2p.Text = "0";
            this.bomb_2p.Visible = false;
            // 
            // water_1p
            // 
            this.water_1p.AutoSize = true;
            this.water_1p.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.water_1p.ForeColor = System.Drawing.Color.Black;
            this.water_1p.Location = new System.Drawing.Point(58, 333);
            this.water_1p.Name = "water_1p";
            this.water_1p.Size = new System.Drawing.Size(36, 40);
            this.water_1p.TabIndex = 12;
            this.water_1p.Text = "0";
            // 
            // shoe_1p
            // 
            this.shoe_1p.AutoSize = true;
            this.shoe_1p.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.shoe_1p.ForeColor = System.Drawing.Color.Black;
            this.shoe_1p.Location = new System.Drawing.Point(58, 255);
            this.shoe_1p.Name = "shoe_1p";
            this.shoe_1p.Size = new System.Drawing.Size(36, 40);
            this.shoe_1p.TabIndex = 11;
            this.shoe_1p.Text = "0";
            // 
            // bomb_1p
            // 
            this.bomb_1p.AutoSize = true;
            this.bomb_1p.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bomb_1p.ForeColor = System.Drawing.Color.Black;
            this.bomb_1p.Location = new System.Drawing.Point(58, 175);
            this.bomb_1p.Name = "bomb_1p";
            this.bomb_1p.Size = new System.Drawing.Size(36, 40);
            this.bomb_1p.TabIndex = 10;
            this.bomb_1p.Text = "0";
            // 
            // shoe_pic
            // 
            this.shoe_pic.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.shoe_pic.ForeColor = System.Drawing.Color.Lime;
            this.shoe_pic.Image = ((System.Drawing.Image)(resources.GetObject("shoe_pic.Image")));
            this.shoe_pic.Location = new System.Drawing.Point(3, 245);
            this.shoe_pic.Name = "shoe_pic";
            this.shoe_pic.Size = new System.Drawing.Size(49, 50);
            this.shoe_pic.TabIndex = 9;
            // 
            // water_pic
            // 
            this.water_pic.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.water_pic.ForeColor = System.Drawing.Color.Lime;
            this.water_pic.Image = ((System.Drawing.Image)(resources.GetObject("water_pic.Image")));
            this.water_pic.Location = new System.Drawing.Point(3, 323);
            this.water_pic.Name = "water_pic";
            this.water_pic.Size = new System.Drawing.Size(49, 50);
            this.water_pic.TabIndex = 8;
            // 
            // title_2p
            // 
            this.title_2p.AutoSize = true;
            this.title_2p.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.title_2p.ForeColor = System.Drawing.Color.Blue;
            this.title_2p.Location = new System.Drawing.Point(102, 107);
            this.title_2p.Name = "title_2p";
            this.title_2p.Size = new System.Drawing.Size(56, 40);
            this.title_2p.TabIndex = 6;
            this.title_2p.Text = "2P";
            this.title_2p.Visible = false;
            // 
            // title_1p
            // 
            this.title_1p.AutoSize = true;
            this.title_1p.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.title_1p.ForeColor = System.Drawing.Color.Red;
            this.title_1p.Location = new System.Drawing.Point(49, 107);
            this.title_1p.Name = "title_1p";
            this.title_1p.Size = new System.Drawing.Size(56, 40);
            this.title_1p.TabIndex = 5;
            this.title_1p.Text = "1P";
            // 
            // bomb_pic
            // 
            this.bomb_pic.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bomb_pic.ForeColor = System.Drawing.Color.Lime;
            this.bomb_pic.Image = ((System.Drawing.Image)(resources.GetObject("bomb_pic.Image")));
            this.bomb_pic.Location = new System.Drawing.Point(3, 165);
            this.bomb_pic.Name = "bomb_pic";
            this.bomb_pic.Size = new System.Drawing.Size(49, 50);
            this.bomb_pic.TabIndex = 4;
            // 
            // mouhow
            // 
            this.mouhow.AutoSize = true;
            this.mouhow.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mouhow.ForeColor = System.Drawing.Color.Lime;
            this.mouhow.Location = new System.Drawing.Point(62, 49);
            this.mouhow.Name = "mouhow";
            this.mouhow.Size = new System.Drawing.Size(32, 50);
            this.mouhow.TabIndex = 3;
            this.mouhow.Text = ":";
            // 
            // second
            // 
            this.second.AutoSize = true;
            this.second.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.second.ForeColor = System.Drawing.Color.Lime;
            this.second.Location = new System.Drawing.Point(88, 49);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(70, 50);
            this.second.TabIndex = 2;
            this.second.Text = "00";
            // 
            // minute
            // 
            this.minute.AutoSize = true;
            this.minute.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.minute.ForeColor = System.Drawing.Color.Lime;
            this.minute.Location = new System.Drawing.Point(1, 49);
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(70, 50);
            this.minute.TabIndex = 1;
            this.minute.Text = "00";
            // 
            // time_title
            // 
            this.time_title.AutoSize = true;
            this.time_title.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.time_title.ForeColor = System.Drawing.Color.White;
            this.time_title.Location = new System.Drawing.Point(3, 9);
            this.time_title.Name = "time_title";
            this.time_title.Size = new System.Drawing.Size(145, 40);
            this.time_title.TabIndex = 0;
            this.time_title.Text = "剩餘時間";
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 1000;
            this.gametimer.Tick += new System.EventHandler(this.gametimer_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 481);
            this.Controls.Add(this.status_panel);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.DoubleBuffered = true;
            this.Name = "Game";
            this.Text = "HBS";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            this.status_panel.ResumeLayout(false);
            this.status_panel.PerformLayout();
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
        private System.Windows.Forms.Panel status_panel;
        private System.Windows.Forms.Label time_title;
        private System.Windows.Forms.Label shoe_pic;
        private System.Windows.Forms.Label water_pic;
        private System.Windows.Forms.Label title_2p;
        private System.Windows.Forms.Label title_1p;
        private System.Windows.Forms.Label bomb_pic;
        private System.Windows.Forms.Label mouhow;
        private System.Windows.Forms.Label second;
        private System.Windows.Forms.Label minute;
        private System.Windows.Forms.Label exit_button;
        private System.Windows.Forms.Label water_2p;
        private System.Windows.Forms.Label shoe_2p;
        private System.Windows.Forms.Label bomb_2p;
        private System.Windows.Forms.Label water_1p;
        private System.Windows.Forms.Label shoe_1p;
        private System.Windows.Forms.Label bomb_1p;
        private System.Windows.Forms.Timer gametimer;
    }
}

