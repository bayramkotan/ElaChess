using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ElaChess
{
    public partial class newGame : Form
    {
        public newGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DestroyHandle();
        }



        private void newGame_Load(object sender, EventArgs e)
        {
            comboEngine1.SelectedIndex = 0;
            comboEngine2.SelectedIndex = 1;
        }
    }
}
