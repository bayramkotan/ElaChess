using System;
using System.Drawing;
using System.Windows.Forms;

namespace ElaChess
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void cbShowCoord_CheckedChanged(object sender, EventArgs e)
        {
            //if(cbShowCoord.Checked==true)
            //    MainForm.ActiveForm.Controls["pbNumberSide"].Visible = true;
            //else
            //    MainForm.ActiveForm.Controls["pbNumberSide"].Visible = false;
        }

        private void cbAnimation_CheckedChanged(object sender, EventArgs e)
        {
            tbAnimationSpeed.Enabled =!(tbAnimationSpeed.Enabled);

        }
    }
}
