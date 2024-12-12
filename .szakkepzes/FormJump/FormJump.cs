using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormJump
{
    public partial class FormJump : Form
    {
        public FormJump()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void jobbfel_Click(object sender, EventArgs e)
        {
            Top = 0;
            Left = Screen.PrimaryScreen.Bounds.Width - Width;
        }

        private void balfel_Click(object sender, EventArgs e)
        {
            Left = 0;
            Top = 0;
        }

        private void balle_Click(object sender, EventArgs e)
        {
            Left = 0;
            Top = Screen.PrimaryScreen.Bounds.Height - Height;
        }

        private void jobble_Click(object sender, EventArgs e)
        {
            Left = Screen.PrimaryScreen.Bounds.Width - Width;
            Top = Screen.PrimaryScreen.Bounds.Height - Height;
        }
    }
}
