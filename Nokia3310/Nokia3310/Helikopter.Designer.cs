namespace Nokia3310
{
    partial class Helikopter
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
            this.components = new System.ComponentModel.Container();
            this.igrac = new System.Windows.Forms.PictureBox();
            this.prepreka1 = new System.Windows.Forms.PictureBox();
            this.prepreka2 = new System.Windows.Forms.PictureBox();
            this.ufo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.igrac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepreka1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepreka2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).BeginInit();
            this.SuspendLayout();
            // 
            // igrac
            // 
            this.igrac.BackColor = System.Drawing.Color.Transparent;
            this.igrac.Image = global::Nokia3310.Properties.Resources.Halicopter;
            this.igrac.Location = new System.Drawing.Point(1, 192);
            this.igrac.Name = "igrac";
            this.igrac.Size = new System.Drawing.Size(100, 54);
            this.igrac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.igrac.TabIndex = 1;
            this.igrac.TabStop = false;
            // 
            // prepreka1
            // 
            this.prepreka1.Image = global::Nokia3310.Properties.Resources.pillar;
            this.prepreka1.Location = new System.Drawing.Point(194, -9);
            this.prepreka1.Name = "prepreka1";
            this.prepreka1.Size = new System.Drawing.Size(56, 150);
            this.prepreka1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prepreka1.TabIndex = 2;
            this.prepreka1.TabStop = false;
            // 
            // prepreka2
            // 
            this.prepreka2.Image = global::Nokia3310.Properties.Resources.pillar;
            this.prepreka2.Location = new System.Drawing.Point(485, 290);
            this.prepreka2.Name = "prepreka2";
            this.prepreka2.Size = new System.Drawing.Size(56, 146);
            this.prepreka2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prepreka2.TabIndex = 3;
            this.prepreka2.TabStop = false;
            // 
            // ufo
            // 
            this.ufo.BackColor = System.Drawing.Color.Transparent;
            this.ufo.Image = global::Nokia3310.Properties.Resources.alien1;
            this.ufo.Location = new System.Drawing.Point(651, 174);
            this.ufo.Name = "ufo";
            this.ufo.Size = new System.Drawing.Size(68, 72);
            this.ufo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ufo.TabIndex = 4;
            this.ufo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "00";
            // 
            // Helikopter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 431);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ufo);
            this.Controls.Add(this.prepreka2);
            this.Controls.Add(this.prepreka1);
            this.Controls.Add(this.igrac);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 470);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 470);
            this.Name = "Helikopter";
            this.Text = "Helikopter";
            this.LocationChanged += new System.EventHandler(this.PromenaLokacije);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.igrac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepreka1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepreka2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox igrac;
        private System.Windows.Forms.PictureBox prepreka1;
        private System.Windows.Forms.PictureBox prepreka2;
        private System.Windows.Forms.PictureBox ufo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}