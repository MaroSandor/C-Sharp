
namespace datetime
{
    partial class foblokk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtp_naptar = new System.Windows.Forms.DateTimePicker();
            this.mtb_perces = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_ev = new System.Windows.Forms.NumericUpDown();
            this.nud_nap = new System.Windows.Forms.NumericUpDown();
            this.nud_honap = new System.Windows.Forms.NumericUpDown();
            this.nud_masodperc = new System.Windows.Forms.NumericUpDown();
            this.nud_perc = new System.Windows.Forms.NumericUpDown();
            this.nud_ora = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_nap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_honap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_masodperc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_perc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ora)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_naptar
            // 
            this.dtp_naptar.Location = new System.Drawing.Point(128, 100);
            this.dtp_naptar.Name = "dtp_naptar";
            this.dtp_naptar.Size = new System.Drawing.Size(215, 20);
            this.dtp_naptar.TabIndex = 0;
            // 
            // mtb_perces
            // 
            this.mtb_perces.Location = new System.Drawing.Point(401, 100);
            this.mtb_perces.Name = "mtb_perces";
            this.mtb_perces.Size = new System.Drawing.Size(100, 20);
            this.mtb_perces.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 68);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // nud_ev
            // 
            this.nud_ev.Location = new System.Drawing.Point(128, 171);
            this.nud_ev.Name = "nud_ev";
            this.nud_ev.Size = new System.Drawing.Size(51, 20);
            this.nud_ev.TabIndex = 4;
            this.nud_ev.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // nud_nap
            // 
            this.nud_nap.Location = new System.Drawing.Point(242, 171);
            this.nud_nap.Name = "nud_nap";
            this.nud_nap.Size = new System.Drawing.Size(51, 20);
            this.nud_nap.TabIndex = 5;
            // 
            // nud_honap
            // 
            this.nud_honap.Location = new System.Drawing.Point(185, 171);
            this.nud_honap.Name = "nud_honap";
            this.nud_honap.Size = new System.Drawing.Size(51, 20);
            this.nud_honap.TabIndex = 6;
            // 
            // nud_masodperc
            // 
            this.nud_masodperc.Location = new System.Drawing.Point(458, 171);
            this.nud_masodperc.Name = "nud_masodperc";
            this.nud_masodperc.Size = new System.Drawing.Size(51, 20);
            this.nud_masodperc.TabIndex = 7;
            // 
            // nud_perc
            // 
            this.nud_perc.Location = new System.Drawing.Point(401, 171);
            this.nud_perc.Name = "nud_perc";
            this.nud_perc.Size = new System.Drawing.Size(51, 20);
            this.nud_perc.TabIndex = 8;
            // 
            // nud_ora
            // 
            this.nud_ora.Location = new System.Drawing.Point(344, 171);
            this.nud_ora.Name = "nud_ora";
            this.nud_ora.Size = new System.Drawing.Size(51, 20);
            this.nud_ora.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(344, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 68);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // foblokk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 497);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.nud_ora);
            this.Controls.Add(this.nud_perc);
            this.Controls.Add(this.nud_masodperc);
            this.Controls.Add(this.nud_honap);
            this.Controls.Add(this.nud_nap);
            this.Controls.Add(this.nud_ev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mtb_perces);
            this.Controls.Add(this.dtp_naptar);
            this.Name = "foblokk";
            this.Text = "DateTimePicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_ev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_nap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_honap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_masodperc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_perc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_naptar;
        private System.Windows.Forms.MaskedTextBox mtb_perces;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_ev;
        private System.Windows.Forms.NumericUpDown nud_nap;
        private System.Windows.Forms.NumericUpDown nud_honap;
        private System.Windows.Forms.NumericUpDown nud_masodperc;
        private System.Windows.Forms.NumericUpDown nud_perc;
        private System.Windows.Forms.NumericUpDown nud_ora;
        private System.Windows.Forms.Button button2;
    }
}

