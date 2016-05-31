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
    public partial class Game : Form
    {
        private int player1Speed = 10;
        private int player1BombsMax = 5;
        private int player1Bombs = 0;
        private int player1Power = 5;
        List<int> player1Keys = new List<int>();
        List<int> player2Keys = new List<int>();
        List<Label>bombsList = new List<Label>();
        List<Label>fireList = new List<Label>();
        Label[,] map = new Label[12, 18];
        int[, ,] gameMaps = new int[,,] {{{ 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1 },
                                          { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1 },
                                          { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1 },
                                          { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1 },
                                          { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1 },
                                          { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1 },
                                          { 0, 0, 0, 2, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1 },
                                          { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1 },
                                          { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1 },
                                          { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1 },
                                          { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1 },
                                          { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1 }}};
        public Game()
        {
            InitializeComponent();
            
        }

        private void Game_Load(object sender, EventArgs e)
        {
            player1.BackColor = System.Drawing.Color.Transparent;
           // pictureBox1.BackColor = System.Drawing.Color.Transparent;
            timer1.Interval = 33;
            timer1.Enabled = true;
            player1.ImageList = imageList1;
            player1.Left = 0;
            player1.Top = 0;
            player1.ImageIndex = 3;
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
                    this.Controls.Add(map[i, j]);
                }
            }
            map[5, 5].ImageIndex = 1;
            map[5, 7].ImageIndex = 2;

            setMap(0);
        }

        private void setMap(int stage)
        {
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 18; j++)
                {
                    map[i, j].ImageIndex = gameMaps[stage, i, j];
                }
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
            if (e.KeyCode == Keys.Space)
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

        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            int keyValue = Convert.ToInt32(e.KeyValue);//儲存按鍵值
             if (e.KeyCode == Keys.W || e.KeyCode == Keys.S || e.KeyCode == Keys.A || e.KeyCode == Keys.D)
            {
                player1Keys .Remove(keyValue ) ;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)    //移動的timer
        {
            if (player1Keys.Count > 0)
            {
                int i, j;
                i = player1.Top / 40;
                j = player1.Left / 40;
                switch (player1Keys[player1Keys.Count - 1])
                {
                    case 87://w
                    //    picTank1.Image = imgWUp;
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
                    //    picTank1.Image = imgWDown;
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
                    //    picTank1.Image = imgWLeft;
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
                   //     player1.Image = imgWRight;
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

       }
    }
}
