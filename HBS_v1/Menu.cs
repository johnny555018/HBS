using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBS_v1
{
    public partial class Menu : Form
    {
        private int player;
        private bool monsters;
        private int map_num = 1;

        public Menu()
        {
            InitializeComponent();
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            player = 1;
            monsters = true;
            this.set_panel.Visible = true;
            this.label_2P.Visible = false;
            this.left_button_2P.Visible = false;
            this.right_button_2P.Visible = false;
        }

        // double player fight
        private void DPF_button_Click(object sender, EventArgs e)
        {
            player = 2;
            monsters = false;
            this.set_panel.Visible = true;
            this.label_2P.Visible = true;
            this.left_button_2P.Visible = true;
            this.right_button_2P.Visible = true;
        }

        private void DPC_button_Click(object sender, EventArgs e)
        {
            player = 2;
            monsters = true;
            this.set_panel.Visible = true;
            this.label_2P.Visible = true;
            this.left_button_2P.Visible = true;
            this.right_button_2P.Visible = true;
        }

        private void instructions_button_Click(object sender, EventArgs e)
        {
            this.Start_button.Visible = false;
            this.DPF_button.Visible = false;
            this.DPC_button.Visible = false;
            this.instructions_button.Visible = false;
            this.instructions.Visible = true;
            this.close_button.Visible = true;
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Start_button.Visible = true;
            this.DPF_button.Visible = true;
            this.DPC_button.Visible = true;
            this.instructions_button.Visible = true;
            this.instructions.Visible = false;
            this.close_button.Visible = false;
        }

        private void left_button_1P_Click(object sender, EventArgs e)
        {

        }

        private void right_button_1P_Click(object sender, EventArgs e)
        {

        }

        private void left_button_2P_Click(object sender, EventArgs e)
        {

        }

        private void right_button_2P_Click(object sender, EventArgs e)
        {

        }

        private void left_button_map_Click(object sender, EventArgs e)
        {
            if (map_num == 1) {
                map_num = 10;
            }
            else {
                map_num--;
            }
            this.map_number.Text = map_num.ToString();
        }

        private void right_button_map_Click(object sender, EventArgs e)
        {
            if (map_num == 10)
            {
                map_num = 1;
            }
            else
            {
                map_num++;
            }
            this.map_number.Text = map_num.ToString();
        }

        private void startgame_button_Click(object sender, EventArgs e)
        {
            Game maingame = new Game(player, monsters, map_num);
            this.Hide();
            maingame.ShowDialog();
            this.Show();
            this.set_panel.Visible = false;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.set_panel.Visible = false;
        }
    }
}
