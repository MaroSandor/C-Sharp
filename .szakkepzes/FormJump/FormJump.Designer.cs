
namespace FormJump
{
    partial class FormJump
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
            this.balfel = new System.Windows.Forms.Button();
            this.jobbfel = new System.Windows.Forms.Button();
            this.balle = new System.Windows.Forms.Button();
            this.jobble = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // balfel
            // 
            this.balfel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.balfel.Location = new System.Drawing.Point(13, 12);
            this.balfel.Name = "balfel";
            this.balfel.Size = new System.Drawing.Size(91, 40);
            this.balfel.TabIndex = 0;
            this.balfel.Text = "Balra fel";
            this.balfel.UseVisualStyleBackColor = true;
            this.balfel.Click += new System.EventHandler(this.balfel_Click);
            // 
            // jobbfel
            // 
            this.jobbfel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jobbfel.Location = new System.Drawing.Point(697, 12);
            this.jobbfel.Name = "jobbfel";
            this.jobbfel.Size = new System.Drawing.Size(91, 40);
            this.jobbfel.TabIndex = 1;
            this.jobbfel.Text = "Jobbra fel";
            this.jobbfel.UseVisualStyleBackColor = true;
            this.jobbfel.Click += new System.EventHandler(this.jobbfel_Click);
            // 
            // balle
            // 
            this.balle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.balle.Location = new System.Drawing.Point(12, 398);
            this.balle.Name = "balle";
            this.balle.Size = new System.Drawing.Size(91, 40);
            this.balle.TabIndex = 2;
            this.balle.Text = "Balra le";
            this.balle.UseVisualStyleBackColor = true;
            this.balle.Click += new System.EventHandler(this.balle_Click);
            // 
            // jobble
            // 
            this.jobble.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jobble.Location = new System.Drawing.Point(697, 398);
            this.jobble.Name = "jobble";
            this.jobble.Size = new System.Drawing.Size(91, 40);
            this.jobble.TabIndex = 3;
            this.jobble.Text = "Jobbra le";
            this.jobble.UseVisualStyleBackColor = true;
            this.jobble.Click += new System.EventHandler(this.jobble_Click);
            // 
            // FormJump
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.jobble);
            this.Controls.Add(this.balle);
            this.Controls.Add(this.jobbfel);
            this.Controls.Add(this.balfel);
            this.Name = "FormJump";
            this.Text = "FormJump";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button balfel;
        private System.Windows.Forms.Button jobbfel;
        private System.Windows.Forms.Button balle;
        private System.Windows.Forms.Button jobble;
    }
}

