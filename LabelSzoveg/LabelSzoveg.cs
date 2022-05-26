using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelSzoveg
{
    public partial class LabelSzoveg : Form
    {
        public LabelSzoveg()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFull.Text = "Kattints a képernyőn valahova.";
        }

        private void lblFullClick_Click(object sender, EventArgs e)
        {

        }

        private void lblFull_MouseClick(object sender, MouseEventArgs e)
        {
            int o = (int)e.X / (lblFull.Width / 3); // oszlop
            int s = (int)e.Y / (lblFull.Height / 3); // sor

            switch (s * 3 + o)
            {
                case 0:
                    lblFull.TextAlign = ContentAlignment.TopLeft; break;
                case 1:
                    lblFull.TextAlign = ContentAlignment.TopCenter; break;
                case 2:
                    lblFull.TextAlign = ContentAlignment.TopRight; break;
                case 3:
                    lblFull.TextAlign = ContentAlignment.MiddleLeft; break;
                case 4:
                    lblFull.TextAlign = ContentAlignment.MiddleCenter; break;
                case 5:
                    lblFull.TextAlign = ContentAlignment.MiddleRight; break;
                case 6:
                    lblFull.TextAlign = ContentAlignment.BottomLeft; break;
                case 7:
                    lblFull.TextAlign = ContentAlignment.BottomCenter; break;
                case 8:
                    lblFull.TextAlign = ContentAlignment.BottomRight; break;
            }
        }
    }
}
