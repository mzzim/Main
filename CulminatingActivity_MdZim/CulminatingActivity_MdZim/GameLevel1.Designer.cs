namespace CulminatingActivity_MdZim
{
    partial class GameLevel1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameLevel1));
            this.grpBottom = new System.Windows.Forms.GroupBox();
            this.prgHealth = new System.Windows.Forms.ProgressBar();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.tmrWalkTimer = new System.Windows.Forms.Timer(this.components);
            this.tmrJump = new System.Windows.Forms.Timer(this.components);
            this.tmrWave = new System.Windows.Forms.Timer(this.components);
            this.tmrFalling = new System.Windows.Forms.Timer(this.components);
            this.Bullet2 = new System.Windows.Forms.PictureBox();
            this.Bullet = new System.Windows.Forms.PictureBox();
            this.picStationaryEnemy2 = new System.Windows.Forms.PictureBox();
            this.picStationaryEnemy1 = new System.Windows.Forms.PictureBox();
            this.BottomPlat = new System.Windows.Forms.PictureBox();
            this.picPlat4Bot = new System.Windows.Forms.PictureBox();
            this.picPlat4Top = new System.Windows.Forms.PictureBox();
            this.picPlat3Bot = new System.Windows.Forms.PictureBox();
            this.picPlat2Bottom = new System.Windows.Forms.PictureBox();
            this.picChar = new System.Windows.Forms.PictureBox();
            this.picFinTop = new System.Windows.Forms.PictureBox();
            this.FinalBotPlat = new System.Windows.Forms.PictureBox();
            this.picPlat2 = new System.Windows.Forms.PictureBox();
            this.picPlat3Top = new System.Windows.Forms.PictureBox();
            this.picBonus = new System.Windows.Forms.PictureBox();
            this.picEHealth1 = new System.Windows.Forms.PictureBox();
            this.picEHealth2 = new System.Windows.Forms.PictureBox();
            this.B1 = new System.Windows.Forms.PictureBox();
            this.lblBonus = new System.Windows.Forms.Label();
            this.picBoss = new System.Windows.Forms.PictureBox();
            this.picBossBar = new System.Windows.Forms.PictureBox();
            this.BossBullet = new System.Windows.Forms.PictureBox();
            this.picBonus2 = new System.Windows.Forms.PictureBox();
            this.grpBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStationaryEnemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStationaryEnemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomPlat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlat4Bot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlat4Top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlat3Bot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlat2Bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFinTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalBotPlat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlat2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlat3Top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEHealth1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEHealth2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BossBullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBonus2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBottom
            // 
            this.grpBottom.BackColor = System.Drawing.Color.SaddleBrown;
            this.grpBottom.Controls.Add(this.prgHealth);
            this.grpBottom.Controls.Add(this.lblScore);
            this.grpBottom.Controls.Add(this.lblHealth);
            this.grpBottom.Location = new System.Drawing.Point(0, -4);
            this.grpBottom.Name = "grpBottom";
            this.grpBottom.Size = new System.Drawing.Size(540, 67);
            this.grpBottom.TabIndex = 0;
            this.grpBottom.TabStop = false;
            // 
            // prgHealth
            // 
            this.prgHealth.Location = new System.Drawing.Point(16, 37);
            this.prgHealth.Name = "prgHealth";
            this.prgHealth.Size = new System.Drawing.Size(149, 20);
            this.prgHealth.TabIndex = 3;
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(425, 18);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(101, 25);
            this.lblScore.TabIndex = 2;
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.Location = new System.Drawing.Point(12, 16);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(67, 18);
            this.lblHealth.TabIndex = 0;
            this.lblHealth.Text = "Health:";
            // 
            // tmrWalkTimer
            // 
            this.tmrWalkTimer.Interval = 25;
            this.tmrWalkTimer.Tick += new System.EventHandler(this.tmrWalkTimer_Tick);
            // 
            // tmrJump
            // 
            this.tmrJump.Interval = 1;
            this.tmrJump.Tick += new System.EventHandler(this.tmrJump_Tick);
            // 
            // tmrWave
            // 
            this.tmrWave.Tick += new System.EventHandler(this.tmrWave_Tick);
            // 
            // tmrFalling
            // 
            this.tmrFalling.Interval = 50;
            this.tmrFalling.Tick += new System.EventHandler(this.tmrFalling_Tick);
            // 
            // Bullet2
            // 
            this.Bullet2.BackColor = System.Drawing.Color.Cyan;
            this.Bullet2.Location = new System.Drawing.Point(45, 278);
            this.Bullet2.Name = "Bullet2";
            this.Bullet2.Size = new System.Drawing.Size(10, 10);
            this.Bullet2.TabIndex = 13;
            this.Bullet2.TabStop = false;
            // 
            // Bullet
            // 
            this.Bullet.BackColor = System.Drawing.Color.Cyan;
            this.Bullet.Location = new System.Drawing.Point(365, 355);
            this.Bullet.Name = "Bullet";
            this.Bullet.Size = new System.Drawing.Size(10, 10);
            this.Bullet.TabIndex = 12;
            this.Bullet.TabStop = false;
            // 
            // picStationaryEnemy2
            // 
            this.picStationaryEnemy2.Location = new System.Drawing.Point(16, 268);
            this.picStationaryEnemy2.Name = "picStationaryEnemy2";
            this.picStationaryEnemy2.Size = new System.Drawing.Size(39, 35);
            this.picStationaryEnemy2.TabIndex = 11;
            this.picStationaryEnemy2.TabStop = false;
            // 
            // picStationaryEnemy1
            // 
            this.picStationaryEnemy1.Location = new System.Drawing.Point(365, 346);
            this.picStationaryEnemy1.Name = "picStationaryEnemy1";
            this.picStationaryEnemy1.Size = new System.Drawing.Size(39, 35);
            this.picStationaryEnemy1.TabIndex = 9;
            this.picStationaryEnemy1.TabStop = false;
            // 
            // BottomPlat
            // 
            this.BottomPlat.Location = new System.Drawing.Point(0, 544);
            this.BottomPlat.Name = "BottomPlat";
            this.BottomPlat.Size = new System.Drawing.Size(540, 10);
            this.BottomPlat.TabIndex = 8;
            this.BottomPlat.TabStop = false;
            // 
            // picPlat4Bot
            // 
            this.picPlat4Bot.Location = new System.Drawing.Point(264, 240);
            this.picPlat4Bot.Name = "picPlat4Bot";
            this.picPlat4Bot.Size = new System.Drawing.Size(290, 5);
            this.picPlat4Bot.TabIndex = 7;
            this.picPlat4Bot.TabStop = false;
            // 
            // picPlat4Top
            // 
            this.picPlat4Top.Location = new System.Drawing.Point(249, 230);
            this.picPlat4Top.Name = "picPlat4Top";
            this.picPlat4Top.Size = new System.Drawing.Size(300, 10);
            this.picPlat4Top.TabIndex = 6;
            this.picPlat4Top.TabStop = false;
            // 
            // picPlat3Bot
            // 
            this.picPlat3Bot.Location = new System.Drawing.Point(15, 313);
            this.picPlat3Bot.Name = "picPlat3Bot";
            this.picPlat3Bot.Size = new System.Drawing.Size(150, 5);
            this.picPlat3Bot.TabIndex = 4;
            this.picPlat3Bot.TabStop = false;
            // 
            // picPlat2Bottom
            // 
            this.picPlat2Bottom.Location = new System.Drawing.Point(246, 391);
            this.picPlat2Bottom.Name = "picPlat2Bottom";
            this.picPlat2Bottom.Size = new System.Drawing.Size(160, 5);
            this.picPlat2Bottom.TabIndex = 3;
            this.picPlat2Bottom.TabStop = false;
            // 
            // picChar
            // 
            this.picChar.Image = ((System.Drawing.Image)(resources.GetObject("picChar.Image")));
            this.picChar.Location = new System.Drawing.Point(502, 481);
            this.picChar.Name = "picChar";
            this.picChar.Size = new System.Drawing.Size(51, 65);
            this.picChar.TabIndex = 1;
            this.picChar.TabStop = false;
            // 
            // picFinTop
            // 
            this.picFinTop.Location = new System.Drawing.Point(0, 152);
            this.picFinTop.Name = "picFinTop";
            this.picFinTop.Size = new System.Drawing.Size(212, 10);
            this.picFinTop.TabIndex = 14;
            this.picFinTop.TabStop = false;
            // 
            // FinalBotPlat
            // 
            this.FinalBotPlat.Location = new System.Drawing.Point(0, 162);
            this.FinalBotPlat.Name = "FinalBotPlat";
            this.FinalBotPlat.Size = new System.Drawing.Size(179, 5);
            this.FinalBotPlat.TabIndex = 15;
            this.FinalBotPlat.TabStop = false;
            // 
            // picPlat2
            // 
            this.picPlat2.Location = new System.Drawing.Point(231, 381);
            this.picPlat2.Name = "picPlat2";
            this.picPlat2.Size = new System.Drawing.Size(175, 10);
            this.picPlat2.TabIndex = 16;
            this.picPlat2.TabStop = false;
            // 
            // picPlat3Top
            // 
            this.picPlat3Top.Location = new System.Drawing.Point(15, 303);
            this.picPlat3Top.Name = "picPlat3Top";
            this.picPlat3Top.Size = new System.Drawing.Size(175, 10);
            this.picPlat3Top.TabIndex = 17;
            this.picPlat3Top.TabStop = false;
            // 
            // picBonus
            // 
            this.picBonus.Image = ((System.Drawing.Image)(resources.GetObject("picBonus.Image")));
            this.picBonus.Location = new System.Drawing.Point(487, 346);
            this.picBonus.Name = "picBonus";
            this.picBonus.Size = new System.Drawing.Size(30, 30);
            this.picBonus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBonus.TabIndex = 18;
            this.picBonus.TabStop = false;
            this.picBonus.Tag = "";
            // 
            // picEHealth1
            // 
            this.picEHealth1.Location = new System.Drawing.Point(364, 330);
            this.picEHealth1.Name = "picEHealth1";
            this.picEHealth1.Size = new System.Drawing.Size(40, 10);
            this.picEHealth1.TabIndex = 19;
            this.picEHealth1.TabStop = false;
            // 
            // picEHealth2
            // 
            this.picEHealth2.BackColor = System.Drawing.Color.CadetBlue;
            this.picEHealth2.Location = new System.Drawing.Point(15, 252);
            this.picEHealth2.Name = "picEHealth2";
            this.picEHealth2.Size = new System.Drawing.Size(40, 10);
            this.picEHealth2.TabIndex = 20;
            this.picEHealth2.TabStop = false;
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.Cyan;
            this.B1.Location = new System.Drawing.Point(555, 429);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(10, 10);
            this.B1.TabIndex = 21;
            this.B1.TabStop = false;
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.BackColor = System.Drawing.Color.Teal;
            this.lblBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonus.Location = new System.Drawing.Point(12, 122);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(92, 18);
            this.lblBonus.TabIndex = 22;
            this.lblBonus.Text = "POWER-UP";
            // 
            // picBoss
            // 
            this.picBoss.Location = new System.Drawing.Point(464, 158);
            this.picBoss.Name = "picBoss";
            this.picBoss.Size = new System.Drawing.Size(71, 72);
            this.picBoss.TabIndex = 23;
            this.picBoss.TabStop = false;
            // 
            // picBossBar
            // 
            this.picBossBar.BackColor = System.Drawing.Color.CadetBlue;
            this.picBossBar.Location = new System.Drawing.Point(457, 132);
            this.picBossBar.Name = "picBossBar";
            this.picBossBar.Size = new System.Drawing.Size(80, 20);
            this.picBossBar.TabIndex = 24;
            this.picBossBar.TabStop = false;
            // 
            // BossBullet
            // 
            this.BossBullet.Location = new System.Drawing.Point(448, 188);
            this.BossBullet.Name = "BossBullet";
            this.BossBullet.Size = new System.Drawing.Size(52, 23);
            this.BossBullet.TabIndex = 25;
            this.BossBullet.TabStop = false;
            // 
            // picBonus2
            // 
            this.picBonus2.Image = ((System.Drawing.Image)(resources.GetObject("picBonus2.Image")));
            this.picBonus2.Location = new System.Drawing.Point(487, 303);
            this.picBonus2.Name = "picBonus2";
            this.picBonus2.Size = new System.Drawing.Size(30, 30);
            this.picBonus2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBonus2.TabIndex = 26;
            this.picBonus2.TabStop = false;
            this.picBonus2.Tag = "";
            // 
            // GameLevel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(540, 546);
            this.Controls.Add(this.picBonus2);
            this.Controls.Add(this.BossBullet);
            this.Controls.Add(this.picBossBar);
            this.Controls.Add(this.picBoss);
            this.Controls.Add(this.lblBonus);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.picEHealth2);
            this.Controls.Add(this.picEHealth1);
            this.Controls.Add(this.picBonus);
            this.Controls.Add(this.picPlat3Top);
            this.Controls.Add(this.picPlat2);
            this.Controls.Add(this.FinalBotPlat);
            this.Controls.Add(this.picFinTop);
            this.Controls.Add(this.Bullet2);
            this.Controls.Add(this.Bullet);
            this.Controls.Add(this.picStationaryEnemy2);
            this.Controls.Add(this.picStationaryEnemy1);
            this.Controls.Add(this.BottomPlat);
            this.Controls.Add(this.picPlat4Bot);
            this.Controls.Add(this.picPlat4Top);
            this.Controls.Add(this.picPlat3Bot);
            this.Controls.Add(this.picPlat2Bottom);
            this.Controls.Add(this.picChar);
            this.Controls.Add(this.grpBottom);
            this.Name = "GameLevel1";
            this.Text = "Ninja Gaiden.EXE = Level 1";
            this.Load += new System.EventHandler(this.GameLevel1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameLevel1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameLevel1_KeyUp);
            this.grpBottom.ResumeLayout(false);
            this.grpBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStationaryEnemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStationaryEnemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomPlat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlat4Bot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlat4Top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlat3Bot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlat2Bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFinTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalBotPlat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlat2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlat3Top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEHealth1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEHealth2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BossBullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBonus2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBottom;
        private System.Windows.Forms.PictureBox picChar;
        private System.Windows.Forms.Timer tmrWalkTimer;
        private System.Windows.Forms.Timer tmrJump;
        private System.Windows.Forms.Timer tmrWave;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.PictureBox picPlat2Bottom;
        private System.Windows.Forms.PictureBox picPlat3Bot;
        private System.Windows.Forms.PictureBox picPlat4Top;
        private System.Windows.Forms.PictureBox picPlat4Bot;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.ProgressBar prgHealth;
        private System.Windows.Forms.PictureBox BottomPlat;
        private System.Windows.Forms.PictureBox picStationaryEnemy1;
        private System.Windows.Forms.Timer tmrFalling;
        private System.Windows.Forms.PictureBox picStationaryEnemy2;
        private System.Windows.Forms.PictureBox Bullet;
        private System.Windows.Forms.PictureBox Bullet2;
        private System.Windows.Forms.PictureBox picFinTop;
        private System.Windows.Forms.PictureBox FinalBotPlat;
        private System.Windows.Forms.PictureBox picPlat2;
        private System.Windows.Forms.PictureBox picPlat3Top;
        private System.Windows.Forms.PictureBox picBonus;
        private System.Windows.Forms.PictureBox picEHealth1;
        private System.Windows.Forms.PictureBox picEHealth2;
        private System.Windows.Forms.PictureBox B1;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.PictureBox picBoss;
        private System.Windows.Forms.PictureBox picBossBar;
        private System.Windows.Forms.PictureBox BossBullet;
        private System.Windows.Forms.PictureBox picBonus2;
    }
}