//Title: Level 1
//Purpose: Allows user to play level 1 of game
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;

namespace CulminatingActivity_MdZim
{
    public partial class GameLevel1 : Form
    {
        //Global Variable Declaration
        public static int Score, CoinBonus = 0, TimeBonus = 125000, TotalScore = 0;
        static int LevelBonus = 100000, LivesBonus = 10000; //Recieves these bonus after finishing level
        static int intmove = 6, TopPick = 1, Angle = 180, RandomDrop;
        static bool blndirection, blnRun;
        static bool Jumping = false, Touched = false, PowerUp = false, ZPressed, Boss = false;
        static bool EnemyOne = true, EnemyTwo = true, blnHit1 = false, blnHit2 = false, BossAppearance = false;

        //Global Random Variable Declaration
        static Random Drop = new Random();

        //Constant Variable Declaration
        static int Lives = 12, BeatCount = 0;
        static int Speed = 5, RunSpeed = 18, Radius = 25;
        static int x = 500, y = 481, yTrack = 481;
        static int[] EnemyLives = new int[4];

        //PictureBox Array Declarat6ion
        PictureBox[] PlatformTop = new PictureBox[2];

        public GameLevel1()
        {
            InitializeComponent();
        }

        //Occurs when this level loads
        private void GameLevel1_Load(object sender, EventArgs e)
        {
            //Loads Preset Stuff (Color, Lives etc.)
            for (int i = 0; i < EnemyLives.Length; i++)
            {
                EnemyLives[i] = 40;
                if (i == 2)
                {
                    EnemyLives[2] += 40;
                }
            }

            prgHealth.Maximum = 12;
            prgHealth.Value = Lives;
            prgHealth.Minimum = 0;

            picBonus.Location = new Point(-50, -50);
            picBonus2.Location = new Point(-50, -50);

            picPlat2.BackColor = Color.Black;
            picPlat3Top.BackColor = Color.WhiteSmoke;
            picPlat4Top.BackColor = Color.YellowGreen;
            picFinTop.BackColor = Color.Bisque;
            picStationaryEnemy1.BackColor = Color.BlanchedAlmond;
            picStationaryEnemy2.BackColor = Color.BurlyWood;
            B1.Height -= 5;
            B1.Width += 5;
            B1.BackColor = Color.Chocolate;

            tmrWave.Enabled = true;
            tmrFalling.Enabled = true;

            PlatformTopCreate();
        }

        //Creates very first platform
        private void PlatformTopCreate()
        {
            for (int i = 0; i < PlatformTop.Length; i++)
            {
                PlatformTop[i] = new PictureBox();
                if (TopPick == 1)
                {
                    PlatformTop[0].Location = new Point(0, 465);
                    PlatformTop[0].Size = new Size(175, 10);
                    PlatformTop[i].BackColor = Color.DarkBlue;
                }
                else if (TopPick == 2)
                {
                    PlatformTop[1].Location = new Point(0, 475);
                    PlatformTop[1].Size = new Size(160, 5);
                }
                Controls.Add(PlatformTop[i]);
                TopPick++;
            }
        }

        //Animation to Allow the Character to Move (Walking or Running)
        private void Move()
        {
            #region Walk
            //Walking Animation
            if (blnRun == false)
            {
                picChar.Width = 29;
                //Going Right
                if (blndirection == false)
                {
                    if (intmove == 6)
                    {
                        picChar.Image = Pictures.p21;
                        intmove = 1;
                    }
                    else if (intmove == 1)
                    {
                        picChar.Image = Pictures.p31;
                        intmove = 2;
                    }
                    else if (intmove == 2)
                    {
                        picChar.Image = Pictures.p41;
                        intmove = 3;
                    }
                    else if (intmove == 3)
                    {
                        picChar.Image = Pictures.p51;
                        intmove = 4;
                    }
                    else if (intmove == 4)
                    {
                        picChar.Image = Pictures.p61;
                        intmove = 5;
                    }
                    else if (intmove == 5)
                    {
                        picChar.Image = Pictures.p11;
                        intmove = 6;
                    }
                    picChar.Left += Speed;
                }
                //Walking Left
                else if (blndirection == true)
                {
                    if (intmove == 6)
                    {
                        picChar.Image = Pictures._7;
                        intmove = 1;
                    }
                    else if (intmove == 1)
                    {
                        picChar.Image = Pictures._8;
                        intmove = 2;
                    }
                    else if (intmove == 2)
                    {
                        picChar.Image = Pictures._9;
                        intmove = 3;
                    }
                    else if (intmove == 3)
                    {
                        picChar.Image = Pictures._10;
                        intmove = 4;
                    }
                    else if (intmove == 4)
                    {
                        picChar.Image = Pictures._11;
                        intmove = 5;
                    }
                    else if (intmove == 5)
                    {
                        picChar.Image = Pictures._12;
                        intmove = 6;
                    }
                    picChar.Left -= Speed;
                }
            }
            #endregion
            #region Running
            //Running Animation
            else if (blnRun == true)
            {
                picChar.Width = 51;
                //Running Left
                if (blndirection == true)
                {
                    if (intmove == 6)
                    {
                        picChar.Image = Pictures.l2;
                        intmove = 1;
                    }
                    else if (intmove == 1)
                    {
                        picChar.Image = Pictures.l2;
                        intmove = 2;
                    }
                    else if (intmove == 2)
                    {
                        picChar.Image = Pictures.l3;
                        intmove = 3;
                    }
                    else if (intmove == 3)
                    {
                        picChar.Image = Pictures.l4;
                        intmove = 4;
                    }
                    else if (intmove == 4)
                    {
                        picChar.Image = Pictures.l5;
                        intmove = 5;
                    }
                    else if (intmove == 5)
                    {
                        picChar.Image = Pictures.l6;
                        intmove = 6;
                    }
                    picChar.Left -= RunSpeed;
                }
                //Running Right
                else if (blndirection == false)
                {
                    if (intmove == 6)
                    {
                        picChar.Image = Pictures.r12;
                        intmove = 1;
                    }
                    else if (intmove == 1)
                    {
                        picChar.Image = Pictures.ri2;
                        intmove = 2;
                    }
                    else if (intmove == 2)
                    {
                        picChar.Image = Pictures.ri3;
                        intmove = 3;
                    }
                    else if (intmove == 3)
                    {
                        picChar.Image = Pictures.ri4;
                        intmove = 4;
                    }
                    else if (intmove == 4)
                    {
                        picChar.Image = Pictures.ri5;
                        intmove = 5;
                    }
                    else if (intmove == 5)
                    {
                        picChar.Image = Pictures.ri6;
                        intmove = 6;
                    }
                    picChar.Left += RunSpeed;
                }
            }
            #endregion
        }

        //Walking Timer
        private void tmrWalkTimer_Tick(object sender, EventArgs e)
        {
            tmrFalling.Enabled = true;
            Move();

            if (blndirection == false) { x = picChar.Location.X + 40;}
            else if (blndirection == true) { x = picChar.Location.X - 40;}

            EnemyTouch();

            //Checks if character got powerup
            if (picChar.Bounds.IntersectsWith(lblBonus.Bounds))
            {
                PowerUp = true;  
                lblBonus.Location = new Point(-50, -50);
            }

            //Checks if character intersected with bonus
            if (picChar.Bounds.IntersectsWith(picBonus.Bounds))
            {
                Score = Score + 25000;
                picBonus.Location = new Point(-50, -50);
            }
            else if (picChar.Bounds.IntersectsWith(picBonus2.Bounds))
            {
                Score = Score + 25000;
                picBonus2.Location = new Point(-50, -50);
            }

            Throwing();
        }

        private void EnemyTouch()
        {
            if ((picChar.Bounds.IntersectsWith(picStationaryEnemy1.Bounds) && EnemyOne == true) || (picChar.Bounds.IntersectsWith(picStationaryEnemy2.Bounds) && EnemyTwo == true) || (Boss == true && picChar.Bounds.IntersectsWith(picBoss.Bounds)))
            {
                CharacterHit();
            }
        }

        private void CharacterHit()
        {
            if (Lives > 0)
            {
                if (Lives >= 3)
                {
                    prgHealth.Value -= 3;
                    Lives -= 3;
                }
                else if (Lives >= 2)
                {
                    prgHealth.Value -= 2;
                    Lives -= 2;
                }
                else if (Lives >= 1)
                {
                    prgHealth.Value--;
                    Lives--;
                }
            }
            else { ScoreCheck(); }
            if (blndirection == true){   picChar.Left += 35;}
            else{ picChar.Left -= 35;}
        }

        //Jumping Timer
        private void tmrJump_Tick(object sender, EventArgs e)
        {
            tmrFalling.Enabled = false;
            Jump();
            PlatformTopWalk();
            yTrack = picChar.Location.Y;
            EnemyTouch();
        }

        //Allows character to walk ontop of platforms
        public void PlatformTopWalk()
        {
            if ((picChar.Bounds.IntersectsWith(PlatformTop[0].Bounds) || picChar.Bounds.IntersectsWith(picPlat2.Bounds) || 
                picChar.Bounds.IntersectsWith(picPlat3Top.Bounds) || picChar.Bounds.IntersectsWith(picPlat4Top.Bounds) || 
                picChar.Bounds.IntersectsWith(BottomPlat.Bounds) 
                || picChar.Bounds.IntersectsWith(picFinTop.Bounds)) && Angle > 300)
            {
                tmrJump.Enabled = false;
                tmrFalling.Enabled = false;
                picChar.Top += 0;
                picChar.Location = new Point(x, yTrack);    
                y = picChar.Location.Y;
                Touched = true;
                Jumping = false;
                if (blndirection == true)
                {
                    picChar.Image = Pictures._7;
                    //x = picChar.Location.X - 40;
                }
                else if (blndirection == false)
                {
                    picChar.Image = Pictures.p11;
                    //x = picChar.Location.X + 40;
                }
                Angle = 180;
            }
            else
            {
                Touched = false;
            }

            if ((picChar.Bounds.IntersectsWith(PlatformTop[1].Bounds) || picChar.Bounds.IntersectsWith(picPlat2Bottom.Bounds) || picChar.Bounds.IntersectsWith(picPlat3Bot.Bounds) || picChar.Bounds.IntersectsWith(picPlat4Bot.Bounds) || picChar.Bounds.IntersectsWith(FinalBotPlat.Bounds)))
            {
                tmrJump.Enabled = false;    
                tmrFalling.Enabled = true;
                if (blndirection == true)
                {
                    picChar.Left += 5;
                }
                else if (blndirection == false)
                {
                    picChar.Left -= 5;
                }
                yTrack = picChar.Location.Y;
                y = yTrack;
                Angle = 180;
                if (Lives > 0)
                {
                    Lives -= 1;
                    prgHealth.Value -= 1;
                }
            }
        }

        //Allows for jumping
        private void Jump()
        {
            //Variable Declaration
            int xMove;
            int yMove;

            //Jumping Process
            if (Jumping == true && Angle <= 360 && Touched == false)
            {
                tmrJump.Enabled = true;
                tmrWalkTimer.Enabled = false;

                xMove = horizontalVal(Radius, Angle);
                yMove = verticalVal(Radius, Angle);

                if (blndirection == false)
                {
                    FalseJump();
                    picChar.Location = new Point(x + xMove * 2, y + yMove * 5);
                }
                else if (blndirection == true)
                {
                    TrueJump();
                    xMove = xMove * -1;
                    picChar.Location = new Point(x + xMove * 2, y + yMove * 5);
                }

                Angle++;
            }
            else if (Angle > 360)
            {
                if (Touched == true)
                {
                    tmrJump.Enabled = false;
                    Jumping = false;
                    Angle = 180;
                    if (blndirection == true)
                    {
                        picChar.Image = Pictures._7;
                        x = picChar.Location.X - 40;
                    }
                    else if (blndirection == false)
                    {
                        picChar.Image = Pictures.p11;
                        x = picChar.Location.X + 40;
                    }
                }
                else if (Touched == false && yTrack < 480 || (Touched == false && Jumping == false))
                {
                    picChar.Top += 2;
                    x = picChar.Location.X;
                }
            }
        }

        //Returns Adjacent Value
        static int horizontalVal(int intHyp, int intDeg)
        {
            return (int)(Math.Cos(intDeg * Math.PI / 180) * intHyp);
        }

        //Returns Horizontal Value
        static int verticalVal(int intHyp, int intDeg)
        {
            return (int)(Math.Sin(intDeg * Math.PI / 180) * intHyp);
        }
   
        private void TrueJump()
        {
            //Jumping Left Animation
            #region LeftJump
            picChar.Width = 51;
            if (Angle <= 210)
            {
                picChar.Image = Pictures.ji1;
            }
            else if (Angle <= 240)
            {
                picChar.Image = Pictures.ji2;
            }
            else if (Angle <= 270)
            {
                picChar.Image = Pictures.ji3;
            }
            else if (Angle <= 300)
            {
                picChar.Image = Pictures.ji4;
            }
            else if (Angle <= 330)
            {
                picChar.Image = Pictures.ji5;
            }
            else if (Angle <= 360)
            {
                picChar.Image = Pictures.ji6;
            }
        #endregion
        }
        
        private void FalseJump()
        {
            //Jumping Right Animation
            #region RightJump
            picChar.Width = 51;
            if (Angle <= 210)
            {
                picChar.Image = Pictures.j1;
            }
            else if (Angle <= 240)
            {
                picChar.Image = Pictures.j2;
            }
            else if (Angle <= 270)
            {
                picChar.Image = Pictures.j3;
            }
            else if (Angle <= 300)
            {
                picChar.Image = Pictures.j4;
            }
            else if (Angle <= 330)
            {
                picChar.Image = Pictures.j5;
            }
            else if (Angle <= 360)
            {
                picChar.Image = Pictures.j6;
            }
            #endregion
        }

        //Allows for Key Down Events
        private void GameLevel1_KeyDown(object sender, KeyEventArgs e)
        {
            //Moves Left
            if (e.KeyData == Keys.Left)
            {
                blnRun = false;
                blndirection = true;
                tmrWalkTimer.Enabled = true;
                if (picChar.Location.X < 0)
                {
                    picChar.Left = Form1.ActiveForm.Size.Width - 35;
                }
            }
            //Moves Right
            else if (e.KeyData == Keys.Right)
            {
                blnRun = false;
                blndirection = false;
                tmrWalkTimer.Enabled = true;
                if (picChar.Location.X > Form1.ActiveForm.Size.Width - 35)
                {
                    picChar.Left = -20;
                }
            }
            //Runs
            else if (e.Modifiers == Keys.Shift)
            {
                blnRun = true;
                if (e.KeyData == Keys.Right)
                {
                    blndirection = false;
                }
                else if (e.KeyData == Keys.Left)
                {
                    blndirection = true;
                }

                //Checks If Character Is Out of Boundaries
                if (picChar.Location.X < 0)
                {
                    picChar.Left = Form1.ActiveForm.Size.Width - 35;
                }
                else if (picChar.Location.X > Form1.ActiveForm.Size.Width - 35)
                {
                    picChar.Left = -10;
                }
                tmrWalkTimer.Enabled = true;
            }

            //Allows character to jump
            if (e.KeyData == Keys.Space)
            {
                Jumping = true;
                tmrJump.Enabled = true;
                tmrWalkTimer.Enabled = false;
                Touched = false;
                tmrFalling.Enabled = false;
            }
            else
            {
                tmrFalling.Enabled = true;
            }

            //Weapon Shooting
            if (e.KeyData == Keys.Z)
            {
                tmrJump.Enabled = false;
                ZPressed = true;
                Angle = 180;
            }
            
        }

        //If Key's Are Not Pressed, Then Timer is Stopped and According to Direction, A Picture is Set
        private void GameLevel1_KeyUp(object sender, KeyEventArgs e)
        {
            tmrWalkTimer.Enabled = false;
            if (blndirection == false)
            {
                picChar.Image = Pictures.p11;
            }
            else if (blndirection == true)
            {
                picChar.Image = Pictures._7;
            }
        }

        //Gravity Timer (causes character to fall)
        private void tmrFalling_Tick(object sender, EventArgs e)
        {
            if ((picChar.Bounds.IntersectsWith(PlatformTop[0].Bounds) || picChar.Bounds.IntersectsWith(picPlat2.Bounds) || picChar.Bounds.IntersectsWith(picPlat3Top.Bounds) || picChar.Bounds.IntersectsWith(picPlat4Top.Bounds) || picChar.Bounds.IntersectsWith(BottomPlat.Bounds) || picChar.Bounds.IntersectsWith(picFinTop.Bounds)))
            {
                y = picChar.Location.Y;
                yTrack = picChar.Location.Y;
                tmrFalling.Enabled = false;
                if (blndirection == true)
                {
                    picChar.Image = Pictures._7;
                    x = picChar.Location.X - 40;
                }
                else if (blndirection == false)
                {
                    picChar.Image = Pictures.p11;
                    x = picChar.Location.X + 40;
                }
            }
            else
            {
                picChar.Top += 10;
                y = picChar.Location.Y;
                yTrack = picChar.Location.Y;
            }
        }

        //Game Timer
        private void tmrWave_Tick(object sender, EventArgs e)
        {
            ScoreCheck();
            EnemyShooting();
            Throwing();
            enemyHealthCheck();
            if (BeatCount == 2 && BossAppearance == false)
            {
                Boss = true;
                picBoss.BackColor = Color.PaleGoldenrod;
                picBossBar.BackColor = Color.Red;
                BossBullet.BackColor = Color.Plum;
                BossAppearance = true;
            }
        }

        //Weapon Throwing
        private void Throwing()
        {
            //If the character acquired the power-up
            if (PowerUp == true)
            {
                //If z is pressed
                if (ZPressed == true)
                {
                    //Character Shoots
                    B1.BackColor = Color.Chocolate;
                    if (blndirection == false)
                    {
                        B1.Left += 30;
                        tmrJump.Enabled = false;
                        tmrFalling.Enabled = true;
                        Angle = 180;
                    }
                    else if (blndirection == true)
                    {
                        B1.Left -= 30;
                        tmrJump.Enabled = false;
                        tmrFalling.Enabled = true;
                        Angle = 180;
                    }

                    //Instance when character bullet hits enemy
                    if (B1.Bounds.IntersectsWith(picStationaryEnemy1.Bounds) || B1.Bounds.IntersectsWith(picStationaryEnemy2.Bounds))
                    {
                        //Health decreases
                        if (B1.Bounds.IntersectsWith(picStationaryEnemy1.Bounds))
                        {
                            picEHealth1.BackColor = Color.Red;
                            picEHealth1.Width -= 8;
                            EnemyLives[0] -= 8;
                            enemyHealthCheck();
                            B1.BackColor = Color.CadetBlue;
                            B1.Location = new Point(x, yTrack + 30);
                            ZPressed = false;
                            B1.Left += 0;
                        }
                        else if (B1.Bounds.IntersectsWith(picStationaryEnemy2.Bounds))
                        {
                            picEHealth2.BackColor = Color.Red;
                            picEHealth2.Width -= 8;
                            EnemyLives[1] -= 8;
                            enemyHealthCheck();
                            B1.BackColor = Color.CadetBlue;
                            B1.Location = new Point(x, yTrack + 30);
                            ZPressed = false;
                            B1.Left += 0;
                        }
                    }

                    //Shooting the boss
                    if (Boss == true && B1.Bounds.IntersectsWith(picBoss.Bounds))
                    {
                        picBossBar.Width -= 8;
                        EnemyLives[2] -= 8;
                        enemyHealthCheck();
                        B1.BackColor = Color.CadetBlue;
                        B1.Location = new Point(x, yTrack + 30);
                        ZPressed = false;
                        B1.Left += 0;
                    }

                    //If bullet goes outside form
                    if (B1.Location.X < -25 || B1.Location.X > Form.ActiveForm.Size.Width + 40)
                    {
                        ZPressed = false;
                        B1.Left += 0;
                    }
                }
                else if (ZPressed == false)
                {
                    B1.BackColor = Color.CadetBlue;
                    B1.Location = new Point(x, yTrack + 30);
                }
            }
        }

        //Enemy Death
        private void enemyHealthCheck()
        {
            if (EnemyLives[0] == 0 && blnHit1 == false)
            {
                picStationaryEnemy1.Location = new Point(-50, -50);
                Score += 12500;
                Bullet.Location = new Point(0, 0);
                Bullet.Left += 0;
                Bullet.Hide();
                picStationaryEnemy1.Hide();
                BeatCount++;
                EnemyOne = false;

                //Checks if a coin should be dropped
                RandomDrop = Drop.Next(0, 3);
                if (RandomDrop == 2)
                {
                    if (picBonus.Location.X > 0)
                    {
                        picBonus2.Location = new Point(365, 346);
                    }
                    else if (picBonus.Location.X < 0)
                    {
                        picBonus.Location = new Point(365, 346);
                    }
                }

                blnHit1 = true;
            }
            else if (EnemyLives[1] == 0 && blnHit2 == false)
            {
                picStationaryEnemy2.Location = new Point(-50, -50);
                Score += 12500;
                Bullet2.Location = new Point(-500, -500);
                Bullet2.Left += 0;
                Bullet2.Hide();
                picStationaryEnemy2.Hide();
                BeatCount++;
                EnemyTwo = false;

                //Checks if a coin should be dropped
                RandomDrop = Drop.Next(0, 3);
                if (RandomDrop == 0)
                {
                    if (picBonus.Location.X > 0)
                    {
                        picBonus2.Location = new Point(16, 268);
                    }
                    else if (picBonus.Location.X < 0)
                    {
                        picBonus.Location = new Point(16, 268);
                    }
                }

                blnHit2 = true;
            }

            //Checks Boss Death
            if (EnemyLives[2] == 0)
            {
                tmrWave.Enabled = false;
                tmrWalkTimer.Enabled = false;
                picBossBar.Hide();
                BossBullet.Hide();
                picBoss.Hide();
                TimeBonus = 15000;
                TotalScore = Score + TimeBonus + LivesBonus * Lives + LevelBonus + CoinBonus;
                MessageBox.Show("You win.");
                InputName_HighScore_ End = new InputName_HighScore_();
                this.Hide();
                End.Show();
            }
        }

        //Allows for the enemy to shoot
        private void EnemyShooting()
        {
            //Enemy1 Bullet
            Bullet.Left-= 15;
            if (Bullet.Location.X < 0)
            {
                Bullet.Location = new Point(365, 356);
            }
            
            if (Bullet.Bounds.IntersectsWith(picChar.Bounds) && EnemyOne == true)
            {
                CharacterHit();
                Bullet.Location = new Point(365, 356);
            }

            //Enemy2 Bullet
            Bullet2.Left += 9;  
            if (Bullet2.Location.X > GameLevel1.ActiveForm.Size.Width - 40)
            {
                Bullet2.Location = new Point(45, 278);
            }

            if (Bullet2.Bounds.IntersectsWith(picChar.Bounds) && EnemyTwo == true)
            {
                CharacterHit();
                Bullet2.Location = new Point(45, 278);
            }

            //Boss Bullet
            if (Boss == true)
            {
                BossBullet.Left -= 32;
                if (BossBullet.Location.X < 0)
                {
                    BossBullet.Location = new Point(448, 188);
                }

                if (BossBullet.Bounds.IntersectsWith(picChar.Bounds))
                {
                    CharacterHit();
                    if (Lives > 0)
                    {
                        prgHealth.Value--;
                        Lives--;
                    }
                    BossBullet.Location = new Point(448, 188);
                    Angle = 180;
                    tmrJump.Enabled = false;
                    tmrFalling.Enabled = true;
                }
                if (BossBullet.Bounds.IntersectsWith(B1.Bounds))
                {
                    B1.BackColor = Color.CadetBlue;
                    B1.Location = new Point(x, yTrack + 30);
                    ZPressed = false;
                    B1.Left += 0;
                }
            }
        }

        //Checks Score and Health
        private void ScoreCheck()
        {
            //Score Count
            lblScore.Text = Score.ToString();
            Score += 250;
            TimeBonus -= 500;
            TotalScore = Score + TimeBonus + CoinBonus;

            //Checks if Character died...
            if (Lives == 0)
            {
                if (PowerUp == true && TotalScore > 50000)
                {
                    this.Hide();
                    InputName_HighScore_ High = new InputName_HighScore_();
                    High.Show();
                    tmrWave.Enabled = false;
                    tmrWalkTimer.Enabled = false;
                    tmrJump.Enabled = false;
                    tmrFalling.Enabled = false;
                    Bullet.Location = new Point(-50, -50);
                    Bullet2.Location = new Point(-50, -50);
                }
                else
                {
                    this.Hide();
                    HighScores Show = new HighScores();
                    Show.Show();
                    tmrWave.Enabled = false;
                    tmrWalkTimer.Enabled = false;
                    tmrJump.Enabled = false;
                    tmrFalling.Enabled = false;
                    Bullet.Location = new Point(-50, -50);
                    Bullet2.Location = new Point(-50, -50);
                }
            }
        }
    }
}
