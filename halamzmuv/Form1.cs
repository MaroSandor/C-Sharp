using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace halamzmuv
{
    public partial class Form1 : Form
    {
        Random szamok = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSzamitas_Click(object sender, EventArgs e)
        {
            listA.Items.Clear();
            listB.Items.Clear();

            int a = Convert.ToInt32(halmazAInput.Text);
            for (int i = 0; i < a; i++)
            {
                listA.Items.Add(szamok.Next(1, 101));
            }

            int b = Convert.ToInt32(halmazBInput.Text);
            for (int i = 0; i < b; i++)
            {
                listB.Items.Add(szamok.Next(1, 101));
            }
        }

        private void hozzaad_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(halmazAInput.Text);
            for (int i = 0; i < a; i++)
            {
                listA.Items.Add(szamok.Next(1, 101));
            }

            int b = Convert.ToInt32(halmazBInput.Text);
            for (int i = 0; i < b; i++)
            {
                listB.Items.Add(szamok.Next(1, 101));
            }
        }

        private void torles_Click(object sender, EventArgs e)
        {
            listA.Items.Clear();
            listB.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
