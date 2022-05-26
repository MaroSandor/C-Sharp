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
        }
    }
}
