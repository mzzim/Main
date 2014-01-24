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
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 Page2 = new Form1();
            Page2.Show();
        }
    }
}
