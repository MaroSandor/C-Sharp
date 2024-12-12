
namespace ScrollBar
{
    partial class Form1
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
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.pirosszin = new System.Windows.Forms.HScrollBar();
            this.kekszin = new System.Windows.Forms.HScrollBar();
            this.zoldszin = new System.Windows.Forms.HScrollBar();
            this.bgcolor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(145, 9);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(424, 23);
            this.hScrollBar1.TabIndex = 0;
            // 
            // pirosszin
            // 
            this.pirosszin.Location = new System.Drawing.Point(145, 327);
            this.pirosszin.Name = "pirosszin";
            this.pirosszin.Size = new System.Drawing.Size(424, 23);
            this.pirosszin.TabIndex = 1;
            // 
            // kekszin
            // 
            this.kekszin.Location = new System.Drawing.Point(145, 359);
            this.kekszin.Name = "kekszin";
            this.kekszin.Size = new System.Drawing.Size(424, 23);
            this.kekszin.TabIndex = 2;
            // 
            // zoldszin
            // 
            this.zoldszin.Location = new System.Drawing.Point(145, 391);
            this.zoldszin.Name = "zoldszin";
            this.zoldszin.Size = new System.Drawing.Size(424, 23);
            this.zoldszin.TabIndex = 3;
            // 
            // bgcolor
            // 
            this.bgcolor.AutoSize = true;
            this.bgcolor.Location = new System.Drawing.Point(294, 146);
            this.bgcolor.Name = "bgcolor";
            this.bgcolor.Size = new System.Drawing.Size(0, 13);
            this.bgcolor.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(35, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Piros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(35, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kék";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(35, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Zöld";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = " ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bgcolor);
            this.Controls.Add(this.zoldszin);
            this.Controls.Add(this.kekszin);
            this.Controls.Add(this.pirosszin);
            this.Controls.Add(this.hScrollBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.HScrollBar pirosszin;
        private System.Windows.Forms.HScrollBar kekszin;
        private System.Windows.Forms.HScrollBar zoldszin;
        private System.Windows.Forms.Label bgcolor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}

