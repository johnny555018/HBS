namespace HBS_v1
{
    partial class Menu
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
            this.Title = new System.Windows.Forms.Label();
            this.Start_button = new System.Windows.Forms.Label();
            this.DPF_button = new System.Windows.Forms.Label();
            this.DPC_button = new System.Windows.Forms.Label();
            this.instructions_button = new System.Windows.Forms.Label();
            this.instructions = new System.Windows.Forms.Label();
            this.close_button = new System.Windows.Forms.Label();
            this.set_panel = new System.Windows.Forms.Panel();
            this.map_number = new System.Windows.Forms.Label();
            this.right_button_map = new System.Windows.Forms.Label();
            this.right_button_2P = new System.Windows.Forms.Label();
            this.right_button_1P = new System.Windows.Forms.Label();
            this.left_button_map = new System.Windows.Forms.Label();
            this.left_button_2P = new System.Windows.Forms.Label();
            this.left_button_1P = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Label();
            this.label_map = new System.Windows.Forms.Label();
            this.label_2P = new System.Windows.Forms.Label();
            this.label_1P = new System.Windows.Forms.Label();
            this.startgame_button = new System.Windows.Forms.Label();
            this.set_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Title.Image = global::HBS_v1.Properties.Resources.menutitle;
            this.Title.Location = new System.Drawing.Point(107, 24);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(292, 82);
            this.Title.TabIndex = 0;
            // 
            // Start_button
            // 
            this.Start_button.BackColor = System.Drawing.Color.Transparent;
            this.Start_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start_button.Image = global::HBS_v1.Properties.Resources.start;
            this.Start_button.Location = new System.Drawing.Point(176, 120);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(135, 52);
            this.Start_button.TabIndex = 1;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // DPF_button
            // 
            this.DPF_button.BackColor = System.Drawing.Color.Transparent;
            this.DPF_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DPF_button.Image = global::HBS_v1.Properties.Resources.DPF;
            this.DPF_button.Location = new System.Drawing.Point(24, 185);
            this.DPF_button.Name = "DPF_button";
            this.DPF_button.Size = new System.Drawing.Size(465, 52);
            this.DPF_button.TabIndex = 2;
            this.DPF_button.Click += new System.EventHandler(this.DPF_button_Click);
            // 
            // DPC_button
            // 
            this.DPC_button.BackColor = System.Drawing.Color.Transparent;
            this.DPC_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DPC_button.Image = global::HBS_v1.Properties.Resources.DPC;
            this.DPC_button.Location = new System.Drawing.Point(26, 255);
            this.DPC_button.Name = "DPC_button";
            this.DPC_button.Size = new System.Drawing.Size(463, 52);
            this.DPC_button.TabIndex = 3;
            this.DPC_button.Click += new System.EventHandler(this.DPC_button_Click);
            // 
            // instructions_button
            // 
            this.instructions_button.BackColor = System.Drawing.Color.Transparent;
            this.instructions_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.instructions_button.Image = global::HBS_v1.Properties.Resources.Instructions;
            this.instructions_button.Location = new System.Drawing.Point(107, 318);
            this.instructions_button.Name = "instructions_button";
            this.instructions_button.Size = new System.Drawing.Size(290, 52);
            this.instructions_button.TabIndex = 4;
            this.instructions_button.Click += new System.EventHandler(this.instructions_button_Click);
            // 
            // instructions
            // 
            this.instructions.AutoSize = true;
            this.instructions.BackColor = System.Drawing.Color.Transparent;
            this.instructions.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.instructions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.instructions.Location = new System.Drawing.Point(23, 118);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(467, 182);
            this.instructions.TabIndex = 5;
            this.instructions.Text = "1P使用W A S D鍵控制方向, 左Shift鍵放置炸彈\r\n2P使用上 下 左 右鍵控制方向, 右Shift鍵放置炸彈\r\n將炸彈放置在磚塊的旁邊來炸掉磚塊\r\n磚" +
    "塊被炸掉後有機會掉落道具道具\r\n可以改變角色或炸彈的性能!\r\n小心不要碰到怪獸和炸彈的爆炸範圍!\r\nps.吃到紫色炸彈會讓炸彈威力Max!";
            this.instructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.instructions.Visible = false;
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.Transparent;
            this.close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_button.Image = global::HBS_v1.Properties.Resources.close;
            this.close_button.Location = new System.Drawing.Point(178, 318);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(133, 52);
            this.close_button.TabIndex = 6;
            this.close_button.Visible = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // set_panel
            // 
            this.set_panel.BackColor = System.Drawing.Color.Transparent;
            this.set_panel.Controls.Add(this.map_number);
            this.set_panel.Controls.Add(this.right_button_map);
            this.set_panel.Controls.Add(this.right_button_2P);
            this.set_panel.Controls.Add(this.right_button_1P);
            this.set_panel.Controls.Add(this.left_button_map);
            this.set_panel.Controls.Add(this.left_button_2P);
            this.set_panel.Controls.Add(this.left_button_1P);
            this.set_panel.Controls.Add(this.back_button);
            this.set_panel.Controls.Add(this.label_map);
            this.set_panel.Controls.Add(this.label_2P);
            this.set_panel.Controls.Add(this.label_1P);
            this.set_panel.Controls.Add(this.startgame_button);
            this.set_panel.Location = new System.Drawing.Point(26, 9);
            this.set_panel.Name = "set_panel";
            this.set_panel.Size = new System.Drawing.Size(457, 358);
            this.set_panel.TabIndex = 7;
            this.set_panel.Visible = false;
            // 
            // map_number
            // 
            this.map_number.AutoSize = true;
            this.map_number.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.map_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.map_number.Location = new System.Drawing.Point(282, 173);
            this.map_number.Name = "map_number";
            this.map_number.Size = new System.Drawing.Size(36, 40);
            this.map_number.TabIndex = 19;
            this.map_number.Text = "1";
            // 
            // right_button_map
            // 
            this.right_button_map.BackColor = System.Drawing.Color.Transparent;
            this.right_button_map.Cursor = System.Windows.Forms.Cursors.Hand;
            this.right_button_map.Image = global::HBS_v1.Properties.Resources.arrow_orange_right_p;
            this.right_button_map.Location = new System.Drawing.Point(359, 160);
            this.right_button_map.Name = "right_button_map";
            this.right_button_map.Size = new System.Drawing.Size(67, 62);
            this.right_button_map.TabIndex = 18;
            this.right_button_map.Click += new System.EventHandler(this.right_button_map_Click);
            // 
            // right_button_2P
            // 
            this.right_button_2P.BackColor = System.Drawing.Color.Transparent;
            this.right_button_2P.Cursor = System.Windows.Forms.Cursors.Hand;
            this.right_button_2P.Image = global::HBS_v1.Properties.Resources.arrow_orange_right_p;
            this.right_button_2P.Location = new System.Drawing.Point(359, 85);
            this.right_button_2P.Name = "right_button_2P";
            this.right_button_2P.Size = new System.Drawing.Size(67, 62);
            this.right_button_2P.TabIndex = 17;
            this.right_button_2P.Click += new System.EventHandler(this.right_button_2P_Click);
            // 
            // right_button_1P
            // 
            this.right_button_1P.BackColor = System.Drawing.Color.Transparent;
            this.right_button_1P.Cursor = System.Windows.Forms.Cursors.Hand;
            this.right_button_1P.Image = global::HBS_v1.Properties.Resources.arrow_orange_right_p;
            this.right_button_1P.Location = new System.Drawing.Point(359, 12);
            this.right_button_1P.Name = "right_button_1P";
            this.right_button_1P.Size = new System.Drawing.Size(67, 62);
            this.right_button_1P.TabIndex = 16;
            this.right_button_1P.Click += new System.EventHandler(this.right_button_1P_Click);
            // 
            // left_button_map
            // 
            this.left_button_map.BackColor = System.Drawing.Color.Transparent;
            this.left_button_map.Cursor = System.Windows.Forms.Cursors.Hand;
            this.left_button_map.Image = global::HBS_v1.Properties.Resources.arrow_orange_left_p;
            this.left_button_map.Location = new System.Drawing.Point(172, 160);
            this.left_button_map.Name = "left_button_map";
            this.left_button_map.Size = new System.Drawing.Size(67, 62);
            this.left_button_map.TabIndex = 15;
            this.left_button_map.Click += new System.EventHandler(this.left_button_map_Click);
            // 
            // left_button_2P
            // 
            this.left_button_2P.BackColor = System.Drawing.Color.Transparent;
            this.left_button_2P.Cursor = System.Windows.Forms.Cursors.Hand;
            this.left_button_2P.Image = global::HBS_v1.Properties.Resources.arrow_orange_left_p;
            this.left_button_2P.Location = new System.Drawing.Point(172, 85);
            this.left_button_2P.Name = "left_button_2P";
            this.left_button_2P.Size = new System.Drawing.Size(67, 62);
            this.left_button_2P.TabIndex = 14;
            this.left_button_2P.Click += new System.EventHandler(this.left_button_2P_Click);
            // 
            // left_button_1P
            // 
            this.left_button_1P.BackColor = System.Drawing.Color.Transparent;
            this.left_button_1P.Cursor = System.Windows.Forms.Cursors.Hand;
            this.left_button_1P.Image = global::HBS_v1.Properties.Resources.arrow_orange_left_p;
            this.left_button_1P.Location = new System.Drawing.Point(172, 12);
            this.left_button_1P.Name = "left_button_1P";
            this.left_button_1P.Size = new System.Drawing.Size(67, 62);
            this.left_button_1P.TabIndex = 13;
            this.left_button_1P.Click += new System.EventHandler(this.left_button_1P_Click);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.Transparent;
            this.back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_button.Image = global::HBS_v1.Properties.Resources.back;
            this.back_button.Location = new System.Drawing.Point(146, 295);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(133, 52);
            this.back_button.TabIndex = 12;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // label_map
            // 
            this.label_map.AutoSize = true;
            this.label_map.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_map.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label_map.Location = new System.Drawing.Point(57, 173);
            this.label_map.Name = "label_map";
            this.label_map.Size = new System.Drawing.Size(76, 35);
            this.label_map.TabIndex = 11;
            this.label_map.Text = "地圖:";
            // 
            // label_2P
            // 
            this.label_2P.AutoSize = true;
            this.label_2P.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_2P.ForeColor = System.Drawing.Color.Blue;
            this.label_2P.Location = new System.Drawing.Point(57, 94);
            this.label_2P.Name = "label_2P";
            this.label_2P.Size = new System.Drawing.Size(109, 35);
            this.label_2P.TabIndex = 10;
            this.label_2P.Text = "2P角色:";
            // 
            // label_1P
            // 
            this.label_1P.AutoSize = true;
            this.label_1P.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_1P.ForeColor = System.Drawing.Color.Red;
            this.label_1P.Location = new System.Drawing.Point(57, 29);
            this.label_1P.Name = "label_1P";
            this.label_1P.Size = new System.Drawing.Size(109, 35);
            this.label_1P.TabIndex = 9;
            this.label_1P.Text = "1P角色:";
            // 
            // startgame_button
            // 
            this.startgame_button.BackColor = System.Drawing.Color.Transparent;
            this.startgame_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startgame_button.Image = global::HBS_v1.Properties.Resources.startgame;
            this.startgame_button.Location = new System.Drawing.Point(77, 225);
            this.startgame_button.Name = "startgame_button";
            this.startgame_button.Size = new System.Drawing.Size(288, 52);
            this.startgame_button.TabIndex = 8;
            this.startgame_button.Click += new System.EventHandler(this.startgame_button_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HBS_v1.Properties.Resources.menubg;
            this.ClientSize = new System.Drawing.Size(513, 379);
            this.Controls.Add(this.set_panel);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.instructions);
            this.Controls.Add(this.instructions_button);
            this.Controls.Add(this.DPC_button);
            this.Controls.Add(this.DPF_button);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.Title);
            this.Name = "Menu";
            this.Text = "氫彈超人";
            this.set_panel.ResumeLayout(false);
            this.set_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Start_button;
        private System.Windows.Forms.Label DPF_button;
        private System.Windows.Forms.Label DPC_button;
        private System.Windows.Forms.Label instructions_button;
        private System.Windows.Forms.Label instructions;
        private System.Windows.Forms.Label close_button;
        private System.Windows.Forms.Panel set_panel;
        private System.Windows.Forms.Label back_button;
        private System.Windows.Forms.Label label_map;
        private System.Windows.Forms.Label label_2P;
        private System.Windows.Forms.Label label_1P;
        private System.Windows.Forms.Label startgame_button;
        private System.Windows.Forms.Label left_button_1P;
        private System.Windows.Forms.Label right_button_1P;
        private System.Windows.Forms.Label left_button_map;
        private System.Windows.Forms.Label left_button_2P;
        private System.Windows.Forms.Label right_button_map;
        private System.Windows.Forms.Label right_button_2P;
        private System.Windows.Forms.Label map_number;
    }
}