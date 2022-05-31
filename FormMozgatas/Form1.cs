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
            if (Top > Screen.PrimaryScreen.Bounds.Height - Height)
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
    }
}
