using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMozgatas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void middle_Click(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void up_Click(object sender, EventArgs e)
        {
            if (Top > 0)
            {
                Top -= 10;
            }
        }

        private void down_Click(object sender, EventArgs e)
        {
            if (Top < Screen.PrimaryScreen.Bounds.Height - Height)
            {
                Top += 10;
            }
        }

        private void left_Click(object sender, EventArgs e)
        {
            if (Left > 0)
            {
                Left -= 10;
            }
        }

        private void leftSide_Click(object sender, EventArgs e)
        {
            Left = 0;
        }

        private void upSide_Click(object sender, EventArgs e)
        {
            Top = 0;
        }

        private void meretNo_Click(object sender, EventArgs e)
        {
            Height += 10;
            Width += 10;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void downSide_Click(object sender, EventArgs e)
        {
            Top = Screen.PrimaryScreen.Bounds.Height - Height;
        }

        private void right_Click(object sender, EventArgs e)
        {
            if (Left < Screen.PrimaryScreen.Bounds.Width - Width)
            {
                Left += 10;
            }
        }

        private void rightSide_Click(object sender, EventArgs e)
        {
            Left = Screen.PrimaryScreen.Bounds.Width - Width;
        }

        private void meretCsok_Click(object sender, EventArgs e)
        {
            Height -= 10;
            Width -= 10;
        }

        private void meret_Enter(object sender, EventArgs e)
        {

        }

        private void atlatszosag_Enter(object sender, EventArgs e)
        {

        }

        private void atlNo_Click(object sender, EventArgs e)
        {
            Opacity += 0.1;
        }

        private void atlCsok_Click(object sender, EventArgs e)
        {
            if (Opacity > 0.2)
            {
                Opacity -= 0.1;
            }
        }
    }
}
