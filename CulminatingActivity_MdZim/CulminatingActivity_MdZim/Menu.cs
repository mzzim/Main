//Name: Md Zim
//Date: June 18, 2012
//Title: Ninja Gaiden.EXE
//Purpose: Allow to play culminating assignment, NINJA GAIDEN.EXE
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace CulminatingActivity_MdZim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Outputs immediately while the form is loading
        private void Menu_Load(object sender, EventArgs e)
        {
        }

        //Start Button
        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();

            //Brings Player to Level 1
            GameLevel1 Game = new GameLevel1();
            Game.Show();
        }

        //Instructions Button
        private void btnInstructions_Click(object sender, EventArgs e)
        {
            this.Hide();

            Instructions Instruct = new Instructions();
            Instruct.Show();
        }

        //High Scores Button
        private void btnHighScores_Click(object sender, EventArgs e)
        {
            this.Hide();

            //Brings Players to High Score Form
            HighScores ScoresVeryHigh = new HighScores();
            ScoresVeryHigh.Show();
        }

        //Exit Button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
