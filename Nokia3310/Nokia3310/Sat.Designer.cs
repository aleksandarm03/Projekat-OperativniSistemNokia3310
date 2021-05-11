namespace Nokia3310
{
    partial class Sat
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelMilisekunde = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSekunde = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMinuti = new System.Windows.Forms.Label();
            this.buttonStopericaRestart = new System.Windows.Forms.Button();
            this.buttonStopericaStart = new System.Windows.Forms.Button();
            this.buttonStopericaStop = new System.Windows.Forms.Button();
            this.timerStoperica = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LimeGreen;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(384, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 431);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(122, 30);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(111, 31);
            this.dateTimePicker.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(6, 124);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(103, 37);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(234, 124);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(103, 37);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(49, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonStart);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonStop);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat Subrayada", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 180);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ALARM";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelMilisekunde);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.labelSekunde);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.labelMinuti);
            this.groupBox2.Controls.Add(this.buttonStopericaRestart);
            this.groupBox2.Controls.Add(this.buttonStopericaStart);
            this.groupBox2.Controls.Add(this.buttonStopericaStop);
            this.groupBox2.Font = new System.Drawing.Font("Montserrat Subrayada", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 180);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "STOPERICA";
            // 
            // labelMilisekunde
            // 
            this.labelMilisekunde.AutoSize = true;
            this.labelMilisekunde.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMilisekunde.Location = new System.Drawing.Point(228, 65);
            this.labelMilisekunde.Name = "labelMilisekunde";
            this.labelMilisekunde.Size = new System.Drawing.Size(51, 34);
            this.labelMilisekunde.TabIndex = 3;
            this.labelMilisekunde.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(201, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = ".";
            // 
            // labelSekunde
            // 
            this.labelSekunde.AutoSize = true;
            this.labelSekunde.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSekunde.Location = new System.Drawing.Point(138, 60);
            this.labelSekunde.Name = "labelSekunde";
            this.labelSekunde.Size = new System.Drawing.Size(61, 40);
            this.labelSekunde.TabIndex = 3;
            this.labelSekunde.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(111, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = ":";
            // 
            // labelMinuti
            // 
            this.labelMinuti.AutoSize = true;
            this.labelMinuti.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMinuti.Location = new System.Drawing.Point(48, 60);
            this.labelMinuti.Name = "labelMinuti";
            this.labelMinuti.Size = new System.Drawing.Size(61, 40);
            this.labelMinuti.TabIndex = 3;
            this.labelMinuti.Text = "00";
            // 
            // buttonStopericaRestart
            // 
            this.buttonStopericaRestart.Location = new System.Drawing.Point(224, 127);
            this.buttonStopericaRestart.Name = "buttonStopericaRestart";
            this.buttonStopericaRestart.Size = new System.Drawing.Size(124, 37);
            this.buttonStopericaRestart.TabIndex = 2;
            this.buttonStopericaRestart.Text = "Restart";
            this.buttonStopericaRestart.UseVisualStyleBackColor = true;
            this.buttonStopericaRestart.Click += new System.EventHandler(this.RestartStoperice);
            // 
            // buttonStopericaStart
            // 
            this.buttonStopericaStart.Location = new System.Drawing.Point(6, 127);
            this.buttonStopericaStart.Name = "buttonStopericaStart";
            this.buttonStopericaStart.Size = new System.Drawing.Size(103, 37);
            this.buttonStopericaStart.TabIndex = 2;
            this.buttonStopericaStart.Text = "Start";
            this.buttonStopericaStart.UseVisualStyleBackColor = true;
            this.buttonStopericaStart.Click += new System.EventHandler(this.PokreniStopericu);
            // 
            // buttonStopericaStop
            // 
            this.buttonStopericaStop.Location = new System.Drawing.Point(115, 127);
            this.buttonStopericaStop.Name = "buttonStopericaStop";
            this.buttonStopericaStop.Size = new System.Drawing.Size(103, 37);
            this.buttonStopericaStop.TabIndex = 2;
            this.buttonStopericaStop.Text = "Stop";
            this.buttonStopericaStop.UseVisualStyleBackColor = true;
            this.buttonStopericaStop.Click += new System.EventHandler(this.ZaustaviStopericu);
            // 
            // timerStoperica
            // 
            this.timerStoperica.Enabled = true;
            this.timerStoperica.Interval = 10;
            this.timerStoperica.Tick += new System.EventHandler(this.timerStoperica_Tick);
            // 
            // Sat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 431);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 470);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 470);
            this.Name = "Sat";
            this.Text = "Sat";
            this.Load += new System.EventHandler(this.Sat_Load);
            this.LocationChanged += new System.EventHandler(this.PromenaLOkacije);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelMilisekunde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSekunde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMinuti;
        private System.Windows.Forms.Button buttonStopericaRestart;
        private System.Windows.Forms.Button buttonStopericaStart;
        private System.Windows.Forms.Button buttonStopericaStop;
        private System.Windows.Forms.Timer timerStoperica;
    }
}