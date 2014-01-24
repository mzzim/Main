//Title: HighScore Chart
//Purpose: To output the top 5 high scores
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
    public partial class HighScores : Form
    {
        //Sound Variable Declaration
        static SoundPlayer Sound = new SoundPlayer();

        //Global Variable Declaration
        static int Points = GameLevel1.TotalScore;
        string UserName = InputName_HighScore_.strNameInput;
        static string[] strNames = new string[5];
        static int[] intScores = new int[5];
        int intTemp; 
        string strTemp;
        

        public HighScores()
        {
            InitializeComponent();
        }

        private void bntLeave_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void HighScores_Load(object sender, EventArgs e)
        {
            Points = GameLevel1.TotalScore;
            UserName = InputName_HighScore_.strNameInput;

            Sort();
            Output();
        }

        private void Sort()
        {
            StreamReader re = File.OpenText("highscores.txt");
            for (int i = 0; i < 5; i++)
            {
                ///writes the info into strNames and intScores
                strNames[i] = re.ReadLine();
                intScores[i] = Int32.Parse(re.ReadLine());
            }
            re.Close();

            //if the current score is greater than the lowest
            if (Points >= intScores[4])
            {
                //replace
                intScores[4] = Points;
                strNames[4] = UserName;

                ///bubble sort
                for (int i = 0; i < intScores.Length; i++)
                {
                    for (int n = 0; n < intScores.Length - 1; n++)
                    {
                        if (intScores[n] < intScores[n + 1])
                        {
                            intTemp = intScores[n];
                            intScores[n] = intScores[n + 1];
                            intScores[n + 1] = intTemp;

                            strTemp = strNames[n];
                            strNames[n] = strNames[n + 1];
                            strNames[n + 1] = strTemp;
                        }
                    }
                }

                FileInfo t = new FileInfo("highscores.txt");
                StreamWriter Tex = t.CreateText();
                for (int i = 0; i < 5; i++)
                {
                    Tex.WriteLine(strNames[i]);
                    Tex.WriteLine(intScores[i]);
                }
                Tex.Close();
            }
        }

        private void Output()
        {
            StreamReader res = File.OpenText("highscores.txt");
            for (int i = 0; i < 5; i++)
            {
                /////put info into strNames and intScores
                strNames[i] = res.ReadLine();
                intScores[i] = Int32.Parse(res.ReadLine());
            }
            res.Close();

            //make lblscore = intscores
            lblScore1.Text = intScores[0].ToString();
            lblScore2.Text = intScores[1].ToString();
            lblScore3.Text = intScores[2].ToString();
            lblScore4.Text = intScores[3].ToString();
            lblScore5.Text = intScores[4].ToString();

            //make lblname = strnames
            lblName1.Text = strNames[0];
            lblName2.Text = strNames[1];
            lblName3.Text = strNames[2];
            lblName4.Text = strNames[3];
            lblName5.Text = strNames[4];
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
