using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kepforog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void balraforog_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Image s = Lb_1.Image;
            Lb_1.Image = Lb_2.Image;
            Lb_2.Image = Lb_3.Image;
            Lb_3.Image = Lb_4.Image;
            Lb_4.Image = Lb_5.Image;
            Lb_5.Image = Lb_6.Image;
            Lb_6.Image = Lb_7.Image;
            Lb_7.Image = Lb_8.Image;
            Lb_8.Image = s;
        }
    }
}
