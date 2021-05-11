namespace Nokia3310
{
    partial class Zmijice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zmijice));
            this.labelRezultat = new System.Windows.Forms.Label();
            this.pictureBoxHrana = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHrana)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRezultat
            // 
            this.labelRezultat.AutoSize = true;
            this.labelRezultat.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Italic);
            this.labelRezultat.Location = new System.Drawing.Point(12, 9);
            this.labelRezultat.Name = "labelRezultat";
            this.labelRezultat.Size = new System.Drawing.Size(99, 22);
            this.labelRezultat.TabIndex = 1;
            this.labelRezultat.Text = "SCORE:  0";
            // 
            // pictureBoxHrana
            // 
            this.pictureBoxHrana.BackColor = System.Drawing.Color.LimeGreen;
            this.pictureBoxHrana.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxHrana.BackgroundImage")));
            this.pictureBoxHrana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxHrana.Image = global::Nokia3310.Properties.Resources.iphoneLogo;
            this.pictureBoxHrana.Location = new System.Drawing.Point(275, 65);
            this.pictureBoxHrana.Name = "pictureBoxHrana";
            this.pictureBoxHrana.Size = new System.Drawing.Size(21, 21);
            this.pictureBoxHrana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHrana.TabIndex = 0;
            this.pictureBoxHrana.TabStop = false;
            // 
            // Zmijice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(784, 431);
            this.Controls.Add(this.labelRezultat);
            this.Controls.Add(this.pictureBoxHrana);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 470);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 470);
            this.Name = "Zmijice";
            this.Text = "Zmijice";
            this.LocationChanged += new System.EventHandler(this.PromenaLokacije);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PritisakTastera);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHrana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHrana;
        private System.Windows.Forms.Label labelRezultat;
    }
}