namespace Nokia3310
{
    partial class MediaPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaPlayer));
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonOtvoriFajl = new System.Windows.Forms.Button();
            this.listBoxLista = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Dock = System.Windows.Forms.DockStyle.Left;
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(557, 431);
            this.axWindowsMediaPlayer.TabIndex = 0;
            // 
            // buttonOtvoriFajl
            // 
            this.buttonOtvoriFajl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonOtvoriFajl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOtvoriFajl.Location = new System.Drawing.Point(557, 402);
            this.buttonOtvoriFajl.Name = "buttonOtvoriFajl";
            this.buttonOtvoriFajl.Size = new System.Drawing.Size(227, 29);
            this.buttonOtvoriFajl.TabIndex = 1;
            this.buttonOtvoriFajl.Text = "Otvori";
            this.buttonOtvoriFajl.UseVisualStyleBackColor = true;
            this.buttonOtvoriFajl.Click += new System.EventHandler(this.buttonOtvoriFajl_Click);
            // 
            // listBoxLista
            // 
            this.listBoxLista.BackColor = System.Drawing.SystemColors.Menu;
            this.listBoxLista.FormattingEnabled = true;
            this.listBoxLista.Location = new System.Drawing.Point(557, 0);
            this.listBoxLista.Name = "listBoxLista";
            this.listBoxLista.Size = new System.Drawing.Size(229, 433);
            this.listBoxLista.TabIndex = 2;
            this.listBoxLista.SelectedIndexChanged += new System.EventHandler(this.listBoxLista_SelectedIndexChanged);
            // 
            // MediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 431);
            this.Controls.Add(this.buttonOtvoriFajl);
            this.Controls.Add(this.axWindowsMediaPlayer);
            this.Controls.Add(this.listBoxLista);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 470);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 470);
            this.Name = "MediaPlayer";
            this.Text = "Media Player";
            this.Load += new System.EventHandler(this.MediaPlayer_Load);
            this.LocationChanged += new System.EventHandler(this.PromenaLokacije);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.Button buttonOtvoriFajl;
        private System.Windows.Forms.ListBox listBoxLista;
    }
}