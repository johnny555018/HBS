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
            this.player1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bombImages = new System.Windows.Forms.ImageList(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.fireImages = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.Image = global::HBS_v1.Properties.Resources.man3;
            this.player1.Location = new System.Drawing.Point(118, 125);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(40, 40);
            this.player1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "bg1.png");
            this.imageList1.Images.SetKeyName(1, "box.png");
            this.imageList1.Images.SetKeyName(2, "wall.png");
            this.imageList1.Images.SetKeyName(3, "man.png");
            this.imageList1.Images.SetKeyName(4, "bomb.png");
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
            this.bombImages.Images.SetKeyName(1, "bomb.png");
            this.bombImages.Images.SetKeyName(2, "bomb.png");
            this.bombImages.Images.SetKeyName(3, "bomb.png");
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
            this.fireImages.Images.SetKeyName(0, "fire.png");
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HBS_v1.Properties.Resources.bg1;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.player1);
            this.Name = "Game";
            this.Text = "HBS";
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
    }
}

