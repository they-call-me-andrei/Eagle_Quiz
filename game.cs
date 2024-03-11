using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eagle
{
    public partial class game3 : Form { 

        private static Boolean jump = false;
        private static int strPos = 230;
        private static int health = 10, score = 0;

        private static PictureBox[] arr = new PictureBox[2];
        private static int[] positions = { 1, 2 };
        private static Panel[] pan = new Panel[2];
        int width,copyhealth;
     
        public game3(int x)
        {
            
            InitializeComponent();
            setGameObj();
            label1.Text = "" + score;
            upwall.Location = new Point(-50, 180);
            zindex();
            if (x <= 40)
            {
                health = 4;
                healthbar.Width = 24 * 4;
                width = 24 * 4;
            }
            else
            {
                health = x / 10;
                healthbar.Width = 24 * (x / 10);
                width = 24 * (x / 10);
            }
            copyhealth = health;
            

        }

        
        Random r = new Random();

        private void zindex()
        { 
            player.BringToFront();
            spikes.BringToFront();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].BringToFront();
            }
            floor.BringToFront();
            hole.BringToFront();
            pictureBox1.BringToFront();
            healthbar.BringToFront();
            upwall.BringToFront();
            menupanel.BringToFront();
            dialog.BringToFront();
            levels.BringToFront();
            instructiuni.BringToFront();
        }

        private void setGameObj()
        { 
            arr[0] = donut1;
            arr[0].Left = upwall.Left - 50;
            arr[0].Top = upwall.Top - 10;
            arr[1] = donut2;
            pan[0] = dialog;
            pan[1] = levels;
            hole.Left = -100;
            dialog.Location = new Point(210, 70);
            levels.Location = new Point(210, 70);


        }

        private void game3_Load(object sender, EventArgs e)
        {
            
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if((keyData == Keys.Up)&&(fallen == false)&&(startgame == true))
            {
                
                jump = true;
                
               // strPos = pictureBox1.Top;
            }else if(keyData == Keys.Left&& startgame == true)
            {
                if(player.Left > 0)
                {
                    player.Left -= 3;
                }
                
            }else if(keyData == Keys.Right&& startgame == true)
            {
                // pictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                player.Left += 3;
                
                
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private static Boolean top = false;
        private static Boolean standing = false, onTop = false;

        //private static Boolean waiting = true;

        private static int speed = 3;
        private static Boolean[] lvl = { true, false, false };

        private void spikesplus()
        {
            spikes.Left += speed;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(startgame == true)
            {
                upwall.Left += 1;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == 0)
                    {
                        if (arr[i].Left != -270)
                        {
                            arr[i].Left += 1;
                        }
                        else if (upwall.Left > -300 && upwall.Left < -280)
                        {
                            arr[i].Left += 1;
                        }
                    }
                    else if (i == 1)
                    {
                        if (arr[i].Left != -190)
                        {
                            arr[i].Left += 1;
                        }
                        else if (upwall.Left > -300 && upwall.Left < -280)
                        {
                            arr[i].Left += 1;
                        }

                    }


                }
                spikesplus();
                floor.Left += 1;
                hole.Left += 1;
            }
            checkObjOverMap();                  //see if obj got over the map

            if (jump == true)
            {
                if(player.Top == upwall.Top + 100)
                {
                    top = true;
                }
                if (top == false)
                { 
                    player.Top -= 2;
                }
                else if (top == true)
                {
                    player.Top += 2;
                }
                if (player.Top == strPos - 150)
                {
                    top = true;
                }
            }
            if ((player.Top == strPos)&&fallen == false)               // !!!!
            {
                onTop = false;
                jump = false;
                top = false;
                upperhit = false;
            }
            if ((player.Top + 86 == upwall.Top) && (player.Left > upwall.Left - 50) && (player.Left < upwall.Left + 170))
            {
                onTop = true;
                jump = false;
                top = false;
            }
            if (((jump != true) && (onTop == true) && (player.Left < upwall.Left - 50)) || upperhit == true||fallen == true)
            {
                player.Top += 2;
            }
            
            if((player.Top == upwall.Top + 20 )&& (player.Left > upwall.Left - 50) && (player.Left < upwall.Left + upwall.Width))
            {
                top = false;
                jump = false;
                upperhit = true;
            }
            checkspikeshit(spikes);
            //checkPlayerOutOfMap(player);
            checkDonutsHit(player);
            checkHole(player);
            if((menuopened == true)&&menupanel.Height < 230)
            {
                menuHeightIncrease();
            }
            if ((menuclosed == true) && menupanel.Height > 25)
            {
                menuHeightDecrease();
            }
            checkHealth();



        }
        private static Boolean upperhit = false;
        private static int pauseCount = 0;

        private void checkspikeshit(PictureBox pic)
        {
            if((player.Top>=pic.Top - 80)&&(player.Left + pic.Width>pic.Left)&&(player.Left < pic.Left + pic.Width)&&fallen == false)
            {
                
                jump = false;
                if (player.Left < 250)
                {
                    player.Left = 600;
                }
                else
                {
                    player.Left = spikes.Left - 120;
                }
                player.Top = strPos;
                healthbar.Width -= 24;
                health--;
                
            }
            
        }

        private void checkPlayerOutOfMap(PictureBox pic)
        {
            if(pic.Left< -30)
            {
                pic.Left = 1010;
            }
        }

        private void checkObjOverMap()
        {
            if (floor.Left > -10)
            {
                floor.Left = -1300;
            }
            if (spikes.Left > 1100)
            {
                spikes.Left = -100;
            }
            if (upwall.Left > 1000)
            {
                upwall.Left = -300;
            }
            if(hole.Left > 800)
            {
                hole.Left = -150;
            }

            for( int i = 0;i< arr.Length; i++)
            {
                if(arr[i].Left > 1000)
                {
                    int x = r.Next(1,3);
                    if (x == 1)
                    {
                        if( i == 0)
                        {
                            arr[i].Left = -270;
                        }else if( i == 1)
                        {
                            arr[i].Left = -190;
                        }
                        arr[i].Top = upwall.Top - 60;
                    }
                    else if( x == 2)
                    {
                        arr[i].Left = r.Next(-189, -10);
                        arr[i].Top = strPos + 35;
                    }
                }
            }
            
        }

        private void checkDonutsHit( PictureBox pic)

        {
            for(int i =0; i< arr.Length; i++)
            {
                if((pic.Left>arr[i].Left - pic.Width )&&(pic.Left< arr[i].Left + arr[i].Width)){
                    if((pic.Top>arr[i].Top - pic.Height )&&(pic.Top < arr[i].Top + arr[i].Height )){
                        int x = r.Next(1, 3);
                        if (x == 1)
                        {
                            if (i == 0)
                            {
                                arr[i].Left = -270;
                            }
                            else if (i == 1)
                            {
                                arr[i].Left = -190;
                            }
                            arr[i].Top = upwall.Top - 60;

                        }
                        else if (x == 2)
                        {
                            arr[i].Left = r.Next(-189,-10);
                            arr[i].Top = strPos +35;
                        }
                        score++;
                        label1.Text = "" +score;
                        if(score == 20)
                        {
                            startgame = false;
                            ecran_castigat.BringToFront();
                            ecran_castigat.Visible = true;
                        }
                        
                    }
                }
            }
        }
        private static Boolean fallen = false;
        int x;

        private void checkHole(PictureBox pic)
        {
            if ((pic.Top == strPos)&&(pic.Left + pic.Width > hole.Left + 50)&&(pic.Left<hole.Left + hole.Width -50))
            {
                player.BringToFront();
                fallen = true;
               
                
            }
            if (pic.Top > strPos + 200)
            {
                fallen = false;
                pic.Top = strPos;
                zindex();
                pic.Left = hole.Left - 50;
                healthbar.Width -= 24;
                health--;
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private static int count1 = 0, count2 = 0, count3 = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if(count1 % 2 == 0)
            {
                menuopened = true;
                menuclosed = false;
                startgame = false;
            }
            else
            {
                menuopened = false;
                menuclosed = true;
                startgame = true;
                dialog.Visible = false;
                levels.Visible = false;
            }
            count1++;

            
        }

        private static Boolean menuopened = false, menuclosed = false;

        private static Boolean startgame = false;

        private void easy_Click(object sender, EventArgs e)
        {
            speed = 3;
            menuopened = false;
            menuclosed = true;
            startgame = true;
            dialog.Visible = false;
            levels.Visible = false;
            spikes.Left = -100;
            player.Left = 600;
        }

        private void normal_Click(object sender, EventArgs e)
        {
            speed = 5;
            menuopened = false;
            menuclosed = true;
            startgame = true;
            dialog.Visible = false;
            levels.Visible = false;
            spikes.Left = -100;
            player.Left = 600;

        }

        private void hard_Click(object sender, EventArgs e)
        {
            speed = 7;
            menuopened = false;
            menuclosed = true;
            startgame = true;
            dialog.Visible = false;
            levels.Visible = false;
            spikes.Left = -100;
            player.Left = 600;
        }

        private void game3_Deactivate(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label77_Click(object sender, EventArgs e)
        {
            instructiuni.Hide();
            startgame = true;
        }

        private void label77_MouseEnter(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = Color.White;
        }

        private void label77_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = Color.Red;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label14_MouseEnter(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = Color.Red;
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = Color.White;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            health = copyhealth;
            healthbar.Width = width;
            score = 0;
            label1.Text = "" + score;
            speed = 3;
            menuopened = false;
            menuclosed = true;
            dialog.Visible = false;
            levels.Visible = false;
            spikes.Left = -100;
            player.Left = 600;
            ecran_pierdut.Visible = false;
            startgame = true;
        }

        private void difficulty_Click(object sender, EventArgs e)
        {
            dialog.Visible = false;
            
            if (count3 % 2 == 0)
            {
                levels.Visible = true;
            }
            else
            {
                levels.Visible = false;
            }
            count3++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            levels.Visible = false;
            if (count2 % 2 == 0)
            {
                dialog.Visible = true;
            }
            else
            {
                dialog.Visible = false;
            }
            count2++;
        }

        private void checkHealth()
        {
            if(health == 0)
            {
                startgame = false;
                ecran_pierdut.BringToFront();
                ecran_pierdut.Visible = true;

            }
        }

        private void menuHeightIncrease()
        {
            menupanel.Height += 3;
        }
        private void menuHeightDecrease()
        {
            menupanel.Height -= 3;
        }


    }
    }

