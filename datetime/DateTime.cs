using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datetime
{
    public partial class foblokk : Form
    {
        int ev = 0,
            honap = 0,
            nap = 0,
            ora = 0,
            perc = 0,
            masodperc = 0,
            honapfordulo = 0;

        public foblokk()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nud_honap.Maximum = 12 - dtp_naptar.Value.Month;
            nud_honap.Minimum = - dtp_naptar.Value.Month;
            nud_nap.Maximum = 31 - dtp_naptar.Value.Day;
            nud_nap.Minimum = - dtp_naptar.Value.Day;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            idotFrissit();

            dtp_naptar.Value = dtp_naptar.Value.AddYears((int)nud_ev.Value);
            dtp_naptar.Value = dtp_naptar.Value.AddMonths((int)nud_honap.Value);
            dtp_naptar.Value = dtp_naptar.Value.AddDays((int)nud_nap.Value);
            dtp_naptar.Value = dtp_naptar.Value.AddHours((int)nud_ora.Value);
            dtp_naptar.Value = dtp_naptar.Value.AddMinutes((int)nud_perc.Value);
            dtp_naptar.Value = dtp_naptar.Value.AddSeconds((int)nud_masodperc.Value);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void idotFrissit()
        {
            mtb_perces.Text = String.Format("{0}:{1}:{2}", dtp_naptar.Value.Hour, dtp_naptar.Value.Minute, dtp_naptar.Value.Second);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ev = Convert.ToInt32(nud_ev.Value + dtp_naptar.Value.Year);

            honap = Convert.ToInt32(nud_honap.Value + dtp_naptar.Value.Month);

            nap = Convert.ToInt32(nud_nap.Value + dtp_naptar.Value.Day);

            ora = Convert.ToInt32(nud_ora.Value + dtp_naptar.Value.Hour);

            perc = Convert.ToInt32(nud_perc.Value+ dtp_naptar.Value.Minute);

            masodperc = Convert.ToInt32(nud_masodperc.Value + dtp_naptar.Value.Second);

            idotFrissit();

            label1.Text = String.Format("{0}. {1}. {2}. {3}:{4}:{5}", ev, honap, nap, ora, perc, masodperc);
        }
    }
}
