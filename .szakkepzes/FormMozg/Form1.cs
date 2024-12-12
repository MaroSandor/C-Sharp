using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMozg
{
    public partial class FormMozgatas : Form
    {
        public FormMozgatas()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void atlNo_Click(object sender, EventArgs e)
        {
            if (Opacity >= 0.1)
            {
                Opacity -= 1;
            }
        }
    }
}
