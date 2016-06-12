using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HBS_v1
{
    public partial class Game : Form
    {

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(Keys vKey);
        //player1
        private int player1Speed = 10;
        private int player1BombsMax = 5;
        private int player1Bombs = 0;
        private int player1Power = 5;
        List<int> player1Keys = new List<int>();
        //player2
        private int player2Speed = 10;
        private int player2BombsMax = 5;
        private int player2Bombs = 0;
        private int player2Power = 5;
        List<int> player2Keys = new List<int>();
        //global variable
        Random rand = new Random();
        List<Label>bombsList = new List<Label>();   //for player1
        List<Label> bombsList2 = new List<Label>(); //for player2
        List<Label>fireList = new List<Label>();
        Label[,] map = new Label[12, 18];
        bool twoPlayers = false;
        int[,] gameMaps = new int[12, 18];

        public Game(int players, bool monster, int mapnumber)
        {
            InitializeComponent();
            player2.Hide();
            if (players == 2)   //set player 2
            {
                twoPlayers = true;
                player2.Top = 100;
                player2.Left = 100;
                player2.ImageList = player2MoveDown;
                player2.ImageIndex = 0;
                player2.BackColor = System.Drawing.Color.Transparent;
                player2.Show();
            }
            string mapname = string.Format(@"{0}", "..\\..\\" + mapnumber + ".txt");
            using (TextReader reader = File.OpenText(mapname))
            {
                string text;
                string[] bits;
                for (int a = 0; a < 12; a++)
                {
                    text = reader.ReadLine();
                    bits = text.Split(' ');
                    for (int b = 0; b < 18; b++)
                    {
                        gameMaps[a, b] = int.Parse(bits[b]);
                    }
                }
            }

        }

        private void Game_Load(object sender, EventArgs e)
        {
            player1.BackColor = System.Drawing.Color.Transparent;
            timer1.Interval = 33;
            timer1.Enabled = true;
            player1.ImageList = player1MoveUp;
            player1.Left = 0;
            player1.Top = 0;
            player1.ImageIndex = 6;
          //  player1.AutoSize = true;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 18; j++)
                {
                    map[i, j] = new Label();
                    map[i, j].Width = 40;
                    map[i, j].Height = 40;
                    map[i, j].Top = 40 * i;
                    map[i, j].Left = 40 * j;
                    map[i, j].ImageList = imageList1;
                    map[i, j].ImageIndex = 0;
                 //   map[i, j].BackColor = System.Drawing.Color.Transparent;
                    this.Controls.Add(map[i, j]);
                }
            }

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 18; j++)
                {
                    map[i, j].ImageIndex = gameMaps[i, j];
                }
            }
            
        }

        private void spawnItem(int row, int col)
        {
            int tmp = rand.Next(20);
            if (tmp < 9)
            {
                int rnd = rand.Next(10);
                if (rnd < 3)
                    tmp = 0;
                else if (rnd < 6)
                    tmp = 1;
                else if (rnd < 9)
                    tmp = 2;
                else
                    tmp = 3;
                map[row, col].ImageList = itemImages;
                map[row, col].ImageIndex = tmp;
            }
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            int keyValue=Convert.ToInt32 (e.KeyValue ); //儲存按鍵值
            //player1 move
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.S || e.KeyCode == Keys.A || e.KeyCode == Keys.D) 
            {
                if (player1Keys.Count == 0)
                {
                    player1Keys.Add(keyValue);
                }
                else //检测按键池是否存在该键，不存在则入池
                {
                    bool flag = true;
                    foreach (int k in player1Keys)
                    {
                        if (k == keyValue)
                        {
                            flag = false;
                        }
                    }
                    if (flag)
                    {
                        player1Keys.Add(keyValue);
                    }
                }
            }
            //player2 move
            if (twoPlayers == true)
            {
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
                {
                    if (player2Keys.Count == 0)
                    {
                        player2Keys.Add(keyValue);
                    }
                    else
                    {
                        bool flag = true;
                        foreach (int k in player2Keys)
                        {
                            if (k == keyValue)
                            {
                                flag = false;
                            }
                        }
                        if (flag)
                        {
                            player2Keys.Add(keyValue);
                        }
                    }
                }
            }

            if (e.KeyCode == Keys.ShiftKey)
            {
                if (Convert.ToBoolean(GetAsyncKeyState(Keys.LShiftKey)))
                {
                    if (player1Bombs < player1BombsMax) //還可以放炸彈
                    {
                        int i, j;
                        if (player1.Top % 40 < 20)
                            i = player1.Top / 40;
                        else
                            i = player1.Top / 40 + 1;
                        if (player1.Left % 40 < 20)
                            j = player1.Left / 40;
                        else
                            j = player1.Left / 40 + 1;
                        map[i, j].ImageList = bombImages;
                        map[i, j].ImageIndex = 3;
                        player1Bombs++;
                        bombsList.Add(map[i, j]);
                    }
                }
                if (twoPlayers == true)
                {
                    if (Convert.ToBoolean(GetAsyncKeyState(Keys.RShiftKey)))
                    {
                        if (player2Bombs < player2BombsMax) //還可以放炸彈
                        {
                            int i, j;
                            if (player2.Top % 40 < 20)
                                i = player2.Top / 40;
                            else
                                i = player2.Top / 40 + 1;
                            if (player2.Left % 40 < 20)
                                j = player2.Left / 40;
                            else
                                j = player2.Left / 40 + 1;
                            map[i, j].ImageList = bombImages;
                            map[i, j].ImageIndex = 3;
                            player2Bombs++;
                            bombsList2.Add(map[i, j]);
                        }
                    }
                }
                
            }

        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            int keyValue = Convert.ToInt32(e.KeyValue);//儲存按鍵值
             if (e.KeyCode == Keys.W || e.KeyCode == Keys.S || e.KeyCode == Keys.A || e.KeyCode == Keys.D)
            {
                player1Keys .Remove(keyValue ) ;
            }
             if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
             {
                 player2Keys.Remove(keyValue);
             }
        }


        private void timer1_Tick(object sender, EventArgs e)    //移動的timer
        {
            if (player1Keys.Count > 0)  //player1 move
            {
                int i, j;
                i = player1.Top / 40;
                j = player1.Left / 40;
                switch (player1Keys[player1Keys.Count - 1])
                {
                    case 87://w
                        if (player1.ImageList != player1MoveUp)
                            player1.ImageList = player1MoveUp;
                        if (player1.ImageIndex % 12 == 0)
                            player1.ImageIndex += 12;
                        player1.ImageIndex--;
                        if (player1.Top > 0)
                        {
                            if (player1.Top % 40 == 0 && 
                                map[i - 1, j].ImageList == bombImages)
                                break;
                            if (player1.Top % 40 == 0 &&
                                map[i-1, j].ImageList == imageList1 &&
                                map[i-1, j].ImageIndex >= 1)
                                break;
                            if (player1.Top % 40 == 0 &&
                                player1.Left % 40 > 0 &&
                                map[i - 1, j+1].ImageList == bombImages)
                                break;
                            if (player1.Top % 40 == 0 &&
                                player1.Left % 40 > 0 &&
                                map[i - 1, j+1].ImageList == imageList1 &&
                                map[i - 1, j+1].ImageIndex >= 1)
                                break;
                            player1.Top -= player1Speed;
                        }
                        else
                        {
                            player1.Top = 0;
                        }
                        break;
                    case 83://s
                        if (player1.ImageList != player1MoveDown)
                            player1.ImageList = player1MoveDown;
                        if (player1.ImageIndex % 12 == 0)
                            player1.ImageIndex += 12;
                        player1.ImageIndex--;
                        if (player1.Top < 440)
                        {
                            if (player1.Top % 40 == 0 &&
                                map[i + 1, j].ImageList == bombImages)
                                break;
                            if (player1.Top % 40 == 0 &&
                                map[i + 1, j].ImageList == imageList1 &&
                                map[i + 1, j].ImageIndex >= 1)
                                break;
                            if (player1.Top % 40 == 0 &&
                                player1.Left % 40 > 0 &&
                                map[i + 1, j + 1].ImageList == bombImages)
                                break;
                            if (player1.Top % 40 == 0 &&
                                player1.Left % 40 >0 &&
                                map[i + 1, j + 1].ImageList == imageList1 &&
                                map[i + 1, j + 1].ImageIndex >= 1)
                                break;
                            player1.Top += player1Speed;
                        }
                        else
                        {
                            player1.Top = 440;
                        }
                        break;
                    case 65://a
                        if (player1.ImageList != player1MoveLeft)
                            player1.ImageList = player1MoveLeft;
                        if (player1.ImageIndex % 12 == 0)
                            player1.ImageIndex += 12;
                        player1.ImageIndex--;
                        if (player1.Left > 0)
                        {
                            if (player1.Left % 40 == 0 &&
                                map[i, j - 1].ImageList == bombImages)
                                break;
                            if (player1.Left % 40 == 0 &&
                                map[i , j-1].ImageList == imageList1 &&
                                map[i , j-1].ImageIndex >= 1)
                                break;
                            if (player1.Left % 40 == 0 &&
                                player1.Top % 40 > 0 &&
                                map[i + 1, j - 1].ImageList == bombImages)
                                break;
                            if (player1.Left % 40 == 0 &&
                                player1.Top % 40 > 0 &&
                                map[i + 1, j - 1].ImageList == imageList1 &&
                                map[i + 1, j - 1].ImageIndex >= 1)
                                break;
                            player1.Left -= player1Speed;
                        }
                        else
                        {
                            player1.Left = 0;
                        }
                        break;
                    case 68://d
                        if (player1.ImageList != player1MoveRight)
                            player1.ImageList = player1MoveRight;
                        if (player1.ImageIndex % 12 == 0)
                            player1.ImageIndex += 12;
                        player1.ImageIndex--;
                        if (player1.Left < 680)
                        {
                            if (player1.Left % 40 == 0 &&
                                map[i, j + 1].ImageList == bombImages)
                                break;
                            if (player1.Left % 40 == 0 &&
                                map[i, j + 1].ImageList == imageList1 &&
                                map[i, j + 1].ImageIndex >= 1)
                                break;
                            if (player1.Left % 40 == 0 &&
                                player1.Top % 40 > 0 &&
                                map[i + 1, j + 1].ImageList == bombImages)
                                break;
                            if (player1.Left % 40 == 0 &&
                                player1.Top % 40 > 0 &&
                                map[i + 1, j + 1].ImageList == imageList1 &&
                                map[i + 1, j + 1].ImageIndex >= 1)
                                break;
                            player1.Left += player1Speed;
                        }
                        else
                        {
                            player1.Left = 680;
                        }
                        break;
                }
            }

            if (player2Keys.Count > 0)
            {
                int i, j;
                i = player2.Top / 40;
                j = player2.Left / 40;
                switch (player2Keys[player2Keys.Count - 1])
                {
                    case 38:// Up
                        if (player2.ImageList != player2MoveUp)
                            player2.ImageList = player2MoveUp;
                        if (player2.ImageIndex % 12 == 0)
                            player2.ImageIndex += 12;
                        player2.ImageIndex--;
                        if (player2.Top > 0)
                        {
                            if (player2.Top % 40 == 0 && 
                                map[i - 1, j].ImageList == bombImages)
                                break;
                            if (player2.Top % 40 == 0 &&
                                map[i-1, j].ImageList == imageList1 &&
                                map[i-1, j].ImageIndex >= 1)
                                break;
                            if (player2.Top % 40 == 0 &&
                                player2.Left % 40 > 0 &&
                                map[i - 1, j+1].ImageList == bombImages)
                                break;
                            if (player2.Top % 40 == 0 &&
                                player2.Left % 40 > 0 &&
                                map[i - 1, j+1].ImageList == imageList1 &&
                                map[i - 1, j+1].ImageIndex >= 1)
                                break;
                            player2.Top -= player2Speed;
                        }
                        else
                        {
                            player2.Top = 0;
                        }
                        break;
                    case 40://down
                        if (player2.ImageList != player2MoveDown)
                            player2.ImageList = player2MoveDown;
                        if (player2.ImageIndex % 12 == 0)
                            player2.ImageIndex += 12;
                        player2.ImageIndex--;
                        if (player2.Top < 440)
                        {
                            if (player2.Top % 40 == 0 &&
                                map[i + 1, j].ImageList == bombImages)
                                break;
                            if (player2.Top % 40 == 0 &&
                                map[i + 1, j].ImageList == imageList1 &&
                                map[i + 1, j].ImageIndex >= 1)
                                break;
                            if (player2.Top % 40 == 0 &&
                                player2.Left % 40 > 0 &&
                                map[i + 1, j + 1].ImageList == bombImages)
                                break;
                            if (player2.Top % 40 == 0 &&
                                player2.Left % 40 >0 &&
                                map[i + 1, j + 1].ImageList == imageList1 &&
                                map[i + 1, j + 1].ImageIndex >= 1)
                                break;
                            player2.Top += player2Speed;
                        }
                        else
                        {
                            player2.Top = 440;
                        }
                        break;
                    case 37://left
                        if (player2.ImageList != player2MoveLeft)
                            player2.ImageList = player2MoveLeft;
                        if (player2.ImageIndex % 12 == 0)
                            player2.ImageIndex += 12;
                        player2.ImageIndex--;
                        if (player2.Left > 0)
                        {
                            if (player2.Left % 40 == 0 &&
                                map[i, j - 1].ImageList == bombImages)
                                break;
                            if (player2.Left % 40 == 0 &&
                                map[i , j-1].ImageList == imageList1 &&
                                map[i , j-1].ImageIndex >= 1)
                                break;
                            if (player2.Left % 40 == 0 &&
                                player2.Top % 40 > 0 &&
                                map[i + 1, j - 1].ImageList == bombImages)
                                break;
                            if (player2.Left % 40 == 0 &&
                                player2.Top % 40 > 0 &&
                                map[i + 1, j - 1].ImageList == imageList1 &&
                                map[i + 1, j - 1].ImageIndex >= 1)
                                break;
                            player2.Left -= player1Speed;
                        }
                        else
                        {
                            player2.Left = 0;
                        }
                        break;
                    case 39: //right
                        if (player2.ImageList != player2MoveRight)
                            player2.ImageList = player2MoveRight;
                        if (player2.ImageIndex % 12 == 0)
                            player2.ImageIndex += 12;
                        player2.ImageIndex--;
                        if (player2.Left < 680)
                        {
                            if (player2.Left % 40 == 0 &&
                                map[i, j + 1].ImageList == bombImages)
                                break;
                            if (player2.Left % 40 == 0 &&
                                map[i, j + 1].ImageList == imageList1 &&
                                map[i, j + 1].ImageIndex >= 1)
                                break;
                            if (player2.Left % 40 == 0 &&
                                player2.Top % 40 > 0 &&
                                map[i + 1, j + 1].ImageList == bombImages)
                                break;
                            if (player2.Left % 40 == 0 &&
                                player2.Top % 40 > 0 &&
                                map[i + 1, j + 1].ImageList == imageList1 &&
                                map[i + 1, j + 1].ImageIndex >= 1)
                                break;
                            player2.Left += player1Speed;
                        }
                        else
                        {
                            player2.Left = 680;
                        }
                        break;
                }
            }

            //定位player1
            int a, b;
            if (player1.Top % 40 < 20)
                a = player1.Top / 40;
            else
                a = player1.Top / 40 + 1;
            if (player1.Left % 40 < 20)
                b = player1.Left / 40;
            else
                b = player1.Left / 40 + 1;
            if (map[a, b].ImageList == fireImages) //被炸死了
            {
                map[11, 17].ImageIndex = 2;
            }
        }

       private void timer2_Tick(object sender, EventArgs e) //炸彈的timer，每秒觸發一次
       {
           while (fireList.Count > 0)
           {
               fireList[0].ImageList = imageList1;
               fireList.RemoveAt(0);
           }
           if (bombsList.Count > 0)
           {
               for (int i = 0; i < bombsList.Count; i++)
               {
                   if (bombsList[i].ImageIndex>0)
                       bombsList[i].ImageIndex--;
                   if (bombsList[i].ImageIndex == 0)//加入炸彈爆炸發生的事
                   {                       
                       //fireList.Add(bombsList[i]);
                       int j = bombsList[i].Top / 40;
                       int k = bombsList[i].Left / 40;
                       for (int index = 1; index <= player1Power && j>=index; index++)  //上面炸開
                       {
                           if (map[j - index, k].ImageList == imageList1)
                           {
                               if (map[j - index, k].ImageIndex == 0)
                               {
                                   map[j - index, k].ImageList = fireImages;
                                   map[j - index, k].ImageIndex = 0;
                                   fireList.Add(map[j - index, k]);
                               }
                               else if (map[j - index, k].ImageIndex == 1)   //炸到箱子
                               {
                                   break;
                               }
                               else if (map[j - index, k].ImageIndex == 2)   //炸到牆壁
                               {
                                   break;
                               }
                           }                           
                           else if (map[j - index, k].ImageList == bombImages &&    //炸到炸彈
                                    map[j - index, k].ImageIndex > 0)
                           {
                               map[j - index, k].ImageIndex = 0;
                           }
                       }

                       for (int index = 1; index <= player1Power && j+index<12; index++)  //下面炸開
                       {
                           if (map[j + index, k].ImageList == imageList1)
                           {
                               if (map[j + index, k].ImageIndex == 0)
                               {
                                   map[j + index, k].ImageList = fireImages;
                                   map[j + index, k].ImageIndex = 0;
                                   fireList.Add(map[j + index, k]);
                               }
                               else if (map[j + index, k].ImageIndex == 1)   //炸到箱子
                               {
                                   break;
                               }
                               else if (map[j + index, k].ImageIndex == 2)   //炸到牆壁
                               {
                                   break;
                               }
                           }
                           else if (map[j + index, k].ImageList == bombImages &&    //炸到炸彈
                                    map[j + index, k].ImageIndex > 0)
                           {
                               map[j + index, k].ImageIndex = 0;
                           }
                       }

                       for (int index = 1; index <= player1Power && k >= index; index++)  //左邊炸開
                       {
                           if (map[j, k - index].ImageList == imageList1)
                           {
                               if (map[j, k - index].ImageIndex == 0)
                               {
                                   map[j, k - index].ImageList = fireImages;
                                   map[j, k - index].ImageIndex = 0;
                                   fireList.Add(map[j, k - index]);
                               }
                               else if (map[j, k - index].ImageIndex == 1)   //炸到箱子
                               {
                                   break;
                               }
                               else if (map[j, k - index].ImageIndex == 2)   //炸到牆壁
                               {
                                   break;
                               }
                           }
                           else if (map[j, k - index].ImageList == bombImages &&    //炸到炸彈
                                    map[j, k - index].ImageIndex > 0)
                           {
                               map[j, k - index].ImageIndex = 0;
                           }
                       }

                       for (int index = 1; index <= player1Power && k+index<18; index++)  //右邊炸開
                       {
                           if (map[j, k + index].ImageList == imageList1)
                           {
                               if (map[j, k + index].ImageIndex == 0)
                               {
                                   map[j, k + index].ImageList = fireImages;
                                   map[j, k + index].ImageIndex = 0;
                                   fireList.Add(map[j, k + index]);
                               }
                               else if (map[j, k + index].ImageIndex == 1)   //炸到箱子
                               {
                                   break;
                               }
                               else if (map[j, k + index].ImageIndex == 2)   //炸到牆壁
                               {
                                   break;
                               }
                           }
                           else if (map[j, k + index].ImageList == bombImages &&    //炸到炸彈
                                    map[j, k + index].ImageIndex > 0)
                           {
                               map[j, k + index].ImageIndex = 0;
                           }
                       }
                   }
               }
               //再跑一次迴圈，把較先放的炸彈但是被炸到的也爆炸
               for (int i = 0; i < bombsList.Count; i++)
               {
               //    if (bombsList[i].ImageIndex > 0 && bombsList[i].ImageList == bombImages)
                //       bombsList[i].ImageIndex--;
                   if (bombsList[i].ImageIndex == 0)//加入炸彈爆炸發生的事
                   {
                       player1Bombs--;  //已放炸彈減少
                       fireList.Add(bombsList[i]);
                       int j = bombsList[i].Top / 40;
                       int k = bombsList[i].Left / 40;
                       for (int index = 1; index <= player1Power && j >= index; index++)  //上面炸開
                       {
                           if (map[j - index, k].ImageList == imageList1)
                           {
                               if (map[j - index, k].ImageIndex == 0)
                               {
                                   map[j - index, k].ImageList = fireImages;
                                   map[j - index, k].ImageIndex = 0;
                                   fireList.Add(map[j - index, k]);
                               }
                               else if (map[j - index, k].ImageIndex == 1)   //炸到箱子
                               {
                                   map[j - index, k].ImageIndex = 0;    //加入道具掉落
                                   spawnItem(j - index, k);
                                   break;
                               }
                               else if (map[j - index, k].ImageIndex == 2)   //炸到牆壁
                               {
                                   break;
                               }
                           }
                           else if (map[j - index, k].ImageList == bombImages &&    //炸到炸彈
                                    map[j - index, k].ImageIndex > 0)
                           {
                               map[j - index, k].ImageIndex = 0;
                           }
                       }
                       for (int index = 1; index <= player1Power && j + index < 12; index++)  //下面炸開
                       {
                           if (map[j + index, k].ImageList == imageList1)
                           {
                               if (map[j + index, k].ImageIndex == 0)
                               {
                                   map[j + index, k].ImageList = fireImages;
                                   map[j + index, k].ImageIndex = 0;
                                   fireList.Add(map[j + index, k]);
                               }
                               else if (map[j + index, k].ImageIndex == 1)   //炸到箱子
                               {
                                   map[j + index, k].ImageIndex = 0;    //加入道具掉落
                                   spawnItem(j + index, k);
                                   break;
                               }
                               else if (map[j + index, k].ImageIndex == 2)   //炸到牆壁
                               {
                                   break;
                               }
                           }
                           else if (map[j + index, k].ImageList == bombImages &&    //炸到炸彈
                                    map[j + index, k].ImageIndex > 0)
                           {
                               map[j + index, k].ImageIndex = 0;
                           }
                       }

                       for (int index = 1; index <= player1Power && k >= index; index++)  //左邊炸開
                       {
                           if (map[j, k - index].ImageList == imageList1)
                           {
                               if (map[j, k - index].ImageIndex == 0)
                               {
                                   map[j, k - index].ImageList = fireImages;
                                   map[j, k - index].ImageIndex = 0;
                                   fireList.Add(map[j, k - index]);
                               }
                               else if (map[j, k - index].ImageIndex == 1)   //炸到箱子
                               {
                                   map[j, k - index].ImageIndex = 0;    //加入道具掉落
                                   spawnItem(j, k - index);
                                   break;
                               }
                               else if (map[j, k - index].ImageIndex == 2)   //炸到牆壁
                               {
                                   break;
                               }
                           }
                           else if (map[j, k - index].ImageList == bombImages &&    //炸到炸彈
                                    map[j, k - index].ImageIndex > 0)
                           {
                               map[j, k - index].ImageIndex = 0;
                           }
                       }

                       for (int index = 1; index <= player1Power && k + index < 18; index++)  //右邊炸開
                       {
                           if (map[j, k + index].ImageList == imageList1)
                           {
                               if (map[j, k + index].ImageIndex == 0)
                               {
                                   map[j, k + index].ImageList = fireImages;
                                   map[j, k + index].ImageIndex = 0;
                                   fireList.Add(map[j, k + index]);
                               }
                               else if (map[j, k + index].ImageIndex == 1)   //炸到箱子
                               {
                                   map[j, k + index].ImageIndex = 0;    //加入道具掉落
                                   spawnItem(j, k + index);
                                   break;
                               }
                               else if (map[j, k + index].ImageIndex == 2)   //炸到牆壁
                               {
                                   break;
                               }
                           }      
                           else if (map[j, k + index].ImageList == bombImages &&    //炸到炸彈
                                    map[j, k + index].ImageIndex > 0)
                           {
                               map[j, k + index].ImageIndex = 0;
                           }
                       }
                   }
               }
               bombsList.RemoveAll(item => item.ImageIndex == 0);
            }

           if (bombsList2.Count > 0)
           {
               for (int i = 0; i < bombsList2.Count; i++)
               {
                   if (bombsList2[i].ImageIndex>0)
                       bombsList2[i].ImageIndex--;
                   if (bombsList2[i].ImageIndex == 0)//加入炸彈爆炸發生的事
                   {                       
                       //fireList.Add(bombsList[i]);
                       int j = bombsList2[i].Top / 40;
                       int k = bombsList2[i].Left / 40;
                       for (int index = 1; index <= player2Power && j>=index; index++)  //上面炸開
                       {
                           if (map[j - index, k].ImageList == imageList1)
                           {
                               if (map[j - index, k].ImageIndex == 0)
                               {
                                   map[j - index, k].ImageList = fireImages;
                                   map[j - index, k].ImageIndex = 0;
                                   fireList.Add(map[j - index, k]);
                               }
                               else if (map[j - index, k].ImageIndex == 1)   //炸到箱子
                               {
                                   break;
                               }
                               else if (map[j - index, k].ImageIndex == 2)   //炸到牆壁
                               {
                                   break;
                               }
                           }                           
                           else if (map[j - index, k].ImageList == bombImages &&    //炸到炸彈
                                    map[j - index, k].ImageIndex > 0)
                           {
                               map[j - index, k].ImageIndex = 0;
                           }
                       }

                       for (int index = 1; index <= player2Power && j+index<12; index++)  //下面炸開
                       {
                           if (map[j + index, k].ImageList == imageList1)
                           {
                               if (map[j + index, k].ImageIndex == 0)
                               {
                                   map[j + index, k].ImageList = fireImages;
                                   map[j + index, k].ImageIndex = 0;
                                   fireList.Add(map[j + index, k]);
                               }
                               else if (map[j + index, k].ImageIndex == 1)   //炸到箱子
                               {
                                   break;
                               }
                               else if (map[j + index, k].ImageIndex == 2)   //炸到牆壁
                               {
                                   break;
                               }
                           }
                           else if (map[j + index, k].ImageList == bombImages &&    //炸到炸彈
                                    map[j + index, k].ImageIndex > 0)
                           {
                               map[j + index, k].ImageIndex = 0;
                           }
                       }

                       for (int index = 1; index <= player2Power && k >= index; index++)  //左邊炸開
                       {
                           if (map[j, k - index].ImageList == imageList1)
                           {
                               if (map[j, k - index].ImageIndex == 0)
                               {
                                   map[j, k - index].ImageList = fireImages;
                                   map[j, k - index].ImageIndex = 0;
                                   fireList.Add(map[j, k - index]);
                               }
                               else if (map[j, k - index].ImageIndex == 1)   //炸到箱子
                               {
                                   break;
                               }
                               else if (map[j, k - index].ImageIndex == 2)   //炸到牆壁
                               {
                                   break;
                               }
                           }
                           else if (map[j, k - index].ImageList == bombImages &&    //炸到炸彈
                                    map[j, k - index].ImageIndex > 0)
                           {
                               map[j, k - index].ImageIndex = 0;
                           }
                       }

                       for (int index = 1; index <= player2Power && k+index<18; index++)  //右邊炸開
                       {
                           if (map[j, k + index].ImageList == imageList1)
                           {
                               if (map[j, k + index].ImageIndex == 0)
                               {
                                   map[j, k + index].ImageList = fireImages;
                                   map[j, k + index].ImageIndex = 0;
                                   fireList.Add(map[j, k + index]);
                               }
                               else if (map[j, k + index].ImageIndex == 1)   //炸到箱子
                               {
                                   break;
                               }
                               else if (map[j, k + index].ImageIndex == 2)   //炸到牆壁
                               {
                                   break;
                               }
                           }
                           else if (map[j, k + index].ImageList == bombImages &&    //炸到炸彈
                                    map[j, k + index].ImageIndex > 0)
                           {
                               map[j, k + index].ImageIndex = 0;
                           }
                       }
                   }
               }
               //再跑一次迴圈，把較先放的炸彈但是被炸到的也爆炸
               for (int i = 0; i < bombsList2.Count; i++)
               {
               //    if (bombsList[i].ImageIndex > 0 && bombsList[i].ImageList == bombImages)
                //       bombsList[i].ImageIndex--;
                   if (bombsList2[i].ImageIndex == 0)//加入炸彈爆炸發生的事
                   {
                       player2Bombs--;  //已放炸彈減少
                       fireList.Add(bombsList2[i]);
                       int j = bombsList2[i].Top / 40;
                       int k = bombsList2[i].Left / 40;
                       for (int index = 1; index <= player2Power && j >= index; index++)  //上面炸開
                       {
                           if (map[j - index, k].ImageList == imageList1)
                           {
                               if (map[j - index, k].ImageIndex == 0)
                               {
                                   map[j - index, k].ImageList = fireImages;
                                   map[j - index, k].ImageIndex = 0;
                                   fireList.Add(map[j - index, k]);
                               }
                               else if (map[j - index, k].ImageIndex == 1)   //炸到箱子
                               {
                                   map[j - index, k].ImageIndex = 0;    //加入道具掉落
                                   spawnItem(j - index, k);
                                   break;
                               }
                               else if (map[j - index, k].ImageIndex == 2)   //炸到牆壁
                               {
                                   break;
                               }
                           }
                           else if (map[j - index, k].ImageList == bombImages &&    //炸到炸彈
                                    map[j - index, k].ImageIndex > 0)
                           {
                               map[j - index, k].ImageIndex = 0;
                           }
                       }
                       for (int index = 1; index <= player2Power && j + index < 12; index++)  //下面炸開
                       {
                           if (map[j + index, k].ImageList == imageList1)
                           {
                               if (map[j + index, k].ImageIndex == 0)
                               {
                                   map[j + index, k].ImageList = fireImages;
                                   map[j + index, k].ImageIndex = 0;
                                   fireList.Add(map[j + index, k]);
                               }
                               else if (map[j + index, k].ImageIndex == 1)   //炸到箱子
                               {
                                   map[j + index, k].ImageIndex = 0;    //加入道具掉落
                                   spawnItem(j + index, k);
                                   break;
                               }
                               else if (map[j + index, k].ImageIndex == 2)   //炸到牆壁
                               {
                                   break;
                               }
                           }
                           else if (map[j + index, k].ImageList == bombImages &&    //炸到炸彈
                                    map[j + index, k].ImageIndex > 0)
                           {
                               map[j + index, k].ImageIndex = 0;
                           }
                       }

                       for (int index = 1; index <= player2Power && k >= index; index++)  //左邊炸開
                       {
                           if (map[j, k - index].ImageList == imageList1)
                           {
                               if (map[j, k - index].ImageIndex == 0)
                               {
                                   map[j, k - index].ImageList = fireImages;
                                   map[j, k - index].ImageIndex = 0;
                                   fireList.Add(map[j, k - index]);
                               }
                               else if (map[j, k - index].ImageIndex == 1)   //炸到箱子
                               {
                                   map[j, k - index].ImageIndex = 0;    //加入道具掉落
                                   spawnItem(j, k - index);
                                   break;
                               }
                               else if (map[j, k - index].ImageIndex == 2)   //炸到牆壁
                               {
                                   break;
                               }
                           }
                           else if (map[j, k - index].ImageList == bombImages &&    //炸到炸彈
                                    map[j, k - index].ImageIndex > 0)
                           {
                               map[j, k - index].ImageIndex = 0;
                           }
                       }

                       for (int index = 1; index <= player2Power && k + index < 18; index++)  //右邊炸開
                       {
                           if (map[j, k + index].ImageList == imageList1)
                           {
                               if (map[j, k + index].ImageIndex == 0)
                               {
                                   map[j, k + index].ImageList = fireImages;
                                   map[j, k + index].ImageIndex = 0;
                                   fireList.Add(map[j, k + index]);
                               }
                               else if (map[j, k + index].ImageIndex == 1)   //炸到箱子
                               {
                                   map[j, k + index].ImageIndex = 0;    //加入道具掉落
                                   spawnItem(j, k + index);
                                   break;
                               }
                               else if (map[j, k + index].ImageIndex == 2)   //炸到牆壁
                               {
                                   break;
                               }
                           }      
                           else if (map[j, k + index].ImageList == bombImages &&    //炸到炸彈
                                    map[j, k + index].ImageIndex > 0)
                           {
                               map[j, k + index].ImageIndex = 0;
                           }
                       }
                   }
               }
               bombsList2.RemoveAll(item => item.ImageIndex == 0);
            }

       }
    }
}
