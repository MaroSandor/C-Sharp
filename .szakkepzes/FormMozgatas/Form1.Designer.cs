
namespace FormMozgatas
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
            this.middle = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.up = new System.Windows.Forms.Button();
            this.upSide = new System.Windows.Forms.Button();
            this.downSide = new System.Windows.Forms.Button();
            this.leftSide = new System.Windows.Forms.Button();
            this.rightSide = new System.Windows.Forms.Button();
            this.meretCsok = new System.Windows.Forms.Button();
            this.meretNo = new System.Windows.Forms.Button();
            this.meret = new System.Windows.Forms.GroupBox();
            this.atlatszosag = new System.Windows.Forms.GroupBox();
            this.atlNo = new System.Windows.Forms.Button();
            this.atlCsok = new System.Windows.Forms.Button();
            this.meret.SuspendLayout();
            this.atlatszosag.SuspendLayout();
            this.SuspendLayout();
            // 
            // middle
            // 
            this.middle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.middle.Location = new System.Drawing.Point(340, 198);
            this.middle.Name = "middle";
            this.middle.Size = new System.Drawing.Size(100, 42);
            this.middle.TabIndex = 0;
            this.middle.Text = "Középre";
            this.middle.UseVisualStyleBackColor = true;
            this.middle.Click += new System.EventHandler(this.middle_Click);
            // 
            // down
            // 
            this.down.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.down.Location = new System.Drawing.Point(340, 246);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(100, 42);
            this.down.TabIndex = 1;
            this.down.Text = "Lefelé";
            this.down.UseVisualStyleBackColor = true;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // left
            // 
            this.left.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.left.Location = new System.Drawing.Point(234, 198);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(100, 42);
            this.left.TabIndex = 2;
            this.left.Text = "Balra";
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // right
            // 
            this.right.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.right.Location = new System.Drawing.Point(446, 198);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(100, 42);
            this.right.TabIndex = 3;
            this.right.Text = "Jobbra";
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // up
            // 
            this.up.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.up.Location = new System.Drawing.Point(340, 150);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(100, 42);
            this.up.TabIndex = 4;
            this.up.Text = "Felfelé";
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // upSide
            // 
            this.upSide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.upSide.Location = new System.Drawing.Point(340, 102);
            this.upSide.Name = "upSide";
            this.upSide.Size = new System.Drawing.Size(100, 42);
            this.upSide.TabIndex = 5;
            this.upSide.Text = "Fent";
            this.upSide.UseVisualStyleBackColor = true;
            this.upSide.Click += new System.EventHandler(this.upSide_Click);
            // 
            // downSide
            // 
            this.downSide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.downSide.Location = new System.Drawing.Point(340, 294);
            this.downSide.Name = "downSide";
            this.downSide.Size = new System.Drawing.Size(100, 42);
            this.downSide.TabIndex = 6;
            this.downSide.Text = "Lent";
            this.downSide.UseVisualStyleBackColor = true;
            this.downSide.Click += new System.EventHandler(this.downSide_Click);
            // 
            // leftSide
            // 
            this.leftSide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.leftSide.Location = new System.Drawing.Point(128, 198);
            this.leftSide.Name = "leftSide";
            this.leftSide.Size = new System.Drawing.Size(100, 42);
            this.leftSide.TabIndex = 7;
            this.leftSide.Text = "Bal szél";
            this.leftSide.UseVisualStyleBackColor = true;
            this.leftSide.Click += new System.EventHandler(this.leftSide_Click);
            // 
            // rightSide
            // 
            this.rightSide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rightSide.Location = new System.Drawing.Point(552, 198);
            this.rightSide.Name = "rightSide";
            this.rightSide.Size = new System.Drawing.Size(100, 42);
            this.rightSide.TabIndex = 8;
            this.rightSide.Text = "Jobb szél";
            this.rightSide.UseVisualStyleBackColor = true;
            this.rightSide.Click += new System.EventHandler(this.rightSide_Click);
            // 
            // meretCsok
            // 
            this.meretCsok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.meretCsok.Location = new System.Drawing.Point(112, 19);
            this.meretCsok.Name = "meretCsok";
            this.meretCsok.Size = new System.Drawing.Size(100, 42);
            this.meretCsok.TabIndex = 9;
            this.meretCsok.Text = "Csökken";
            this.meretCsok.UseVisualStyleBackColor = true;
            this.meretCsok.Click += new System.EventHandler(this.meretCsok_Click);
            // 
            // meretNo
            // 
            this.meretNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.meretNo.Location = new System.Drawing.Point(6, 19);
            this.meretNo.Name = "meretNo";
            this.meretNo.Size = new System.Drawing.Size(100, 42);
            this.meretNo.TabIndex = 10;
            this.meretNo.Text = "Növekszik";
            this.meretNo.UseVisualStyleBackColor = true;
            this.meretNo.Click += new System.EventHandler(this.meretNo_Click);
            // 
            // meret
            // 
            this.meret.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.meret.Controls.Add(this.meretNo);
            this.meret.Controls.Add(this.meretCsok);
            this.meret.Location = new System.Drawing.Point(284, 24);
            this.meret.Name = "meret";
            this.meret.Size = new System.Drawing.Size(219, 72);
            this.meret.TabIndex = 13;
            this.meret.TabStop = false;
            this.meret.Text = "Méret:";
            this.meret.Enter += new System.EventHandler(this.meret_Enter);
            // 
            // atlatszosag
            // 
            this.atlatszosag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.atlatszosag.Controls.Add(this.atlNo);
            this.atlatszosag.Controls.Add(this.atlCsok);
            this.atlatszosag.Location = new System.Drawing.Point(284, 342);
            this.atlatszosag.Name = "atlatszosag";
            this.atlatszosag.Size = new System.Drawing.Size(219, 72);
            this.atlatszosag.TabIndex = 14;
            this.atlatszosag.TabStop = false;
            this.atlatszosag.Text = "Átlátszóság:";
            this.atlatszosag.Enter += new System.EventHandler(this.atlatszosag_Enter);
            // 
            // atlNo
            // 
            this.atlNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.atlNo.Location = new System.Drawing.Point(6, 19);
            this.atlNo.Name = "atlNo";
            this.atlNo.Size = new System.Drawing.Size(100, 42);
            this.atlNo.TabIndex = 10;
            this.atlNo.Text = "Növekszik";
            this.atlNo.UseVisualStyleBackColor = true;
            this.atlNo.Click += new System.EventHandler(this.atlNo_Click);
            // 
            // atlCsok
            // 
            this.atlCsok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.atlCsok.Location = new System.Drawing.Point(112, 19);
            this.atlCsok.Name = "atlCsok";
            this.atlCsok.Size = new System.Drawing.Size(100, 42);
            this.atlCsok.TabIndex = 9;
            this.atlCsok.Text = "Csökken";
            this.atlCsok.UseVisualStyleBackColor = true;
            this.atlCsok.Click += new System.EventHandler(this.atlCsok_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.atlatszosag);
            this.Controls.Add(this.meret);
            this.Controls.Add(this.rightSide);
            this.Controls.Add(this.leftSide);
            this.Controls.Add(this.downSide);
            this.Controls.Add(this.upSide);
            this.Controls.Add(this.up);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.down);
            this.Controls.Add(this.middle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.meret.ResumeLayout(false);
            this.atlatszosag.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button middle;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button upSide;
        private System.Windows.Forms.Button downSide;
        private System.Windows.Forms.Button leftSide;
        private System.Windows.Forms.Button rightSide;
        private System.Windows.Forms.Button meretCsok;
        private System.Windows.Forms.Button meretNo;
        private System.Windows.Forms.GroupBox meret;
        private System.Windows.Forms.GroupBox atlatszosag;
        private System.Windows.Forms.Button atlNo;
        private System.Windows.Forms.Button atlCsok;
    }
}

