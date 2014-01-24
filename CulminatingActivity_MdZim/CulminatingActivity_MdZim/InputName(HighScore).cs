//Title: Input Name for HighScore
//Purpose: To allow the user to input name for highscore table
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CulminatingActivity_MdZim
{
    public partial class InputName_HighScore_ : Form
    {
        //Global Variable Declaration
        public static string strNameInput;

        public InputName_HighScore_()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtNameInput.Text != "")
            {
                strNameInput = txtNameInput.Text;

                HighScores Scores = new HighScores();
                Scores.Show();
                this.Hide();
            }
            else
            {
                //messagebox that tells user to enter name
                MessageBox.Show("Please enter your name");
            }
        }
    }
}
