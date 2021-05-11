namespace Nokia3310
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxDisplay = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBoxIgrice = new System.Windows.Forms.PictureBox();
            this.pictureBoxCalculator = new System.Windows.Forms.PictureBox();
            this.progressBarBaterija = new System.Windows.Forms.ProgressBar();
            this.labelBaterija = new System.Windows.Forms.Label();
            this.timerBaterija = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.timer8 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.labelSati = new System.Windows.Forms.Label();
            this.labelMinuti = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timerVreme = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIgrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCalculator)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDisplay
            // 
            this.pictureBoxDisplay.BackColor = System.Drawing.Color.LimeGreen;
            this.pictureBoxDisplay.Location = new System.Drawing.Point(271, 273);
            this.pictureBoxDisplay.Name = "pictureBoxDisplay";
            this.pictureBoxDisplay.Size = new System.Drawing.Size(782, 464);
            this.pictureBoxDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDisplay.TabIndex = 0;
            this.pictureBoxDisplay.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(13, 13);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            // 
            // pictureBoxIgrice
            // 
            this.pictureBoxIgrice.BackColor = System.Drawing.Color.LimeGreen;
            this.pictureBoxIgrice.Image = global::Nokia3310.Properties.Resources.games;
            this.pictureBoxIgrice.Location = new System.Drawing.Point(293, 318);
            this.pictureBoxIgrice.Name = "pictureBoxIgrice";
            this.pictureBoxIgrice.Size = new System.Drawing.Size(111, 110);
            this.pictureBoxIgrice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIgrice.TabIndex = 2;
            this.pictureBoxIgrice.TabStop = false;
            this.pictureBoxIgrice.Click += new System.EventHandler(this.OdabirAplikacijeZaIgrice);
            // 
            // pictureBoxCalculator
            // 
            this.pictureBoxCalculator.BackColor = System.Drawing.Color.Orange;
            this.pictureBoxCalculator.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCalculator.Image")));
            this.pictureBoxCalculator.Location = new System.Drawing.Point(518, 318);
            this.pictureBoxCalculator.Name = "pictureBoxCalculator";
            this.pictureBoxCalculator.Size = new System.Drawing.Size(111, 110);
            this.pictureBoxCalculator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCalculator.TabIndex = 2;
            this.pictureBoxCalculator.TabStop = false;
            this.pictureBoxCalculator.Click += new System.EventHandler(this.PokretanjeKalkulatora);
            // 
            // progressBarBaterija
            // 
            this.progressBarBaterija.Location = new System.Drawing.Point(977, 262);
            this.progressBarBaterija.Name = "progressBarBaterija";
            this.progressBarBaterija.Size = new System.Drawing.Size(24, 10);
            this.progressBarBaterija.TabIndex = 3;
            // 
            // labelBaterija
            // 
            this.labelBaterija.AutoSize = true;
            this.labelBaterija.BackColor = System.Drawing.Color.Transparent;
            this.labelBaterija.ForeColor = System.Drawing.Color.White;
            this.labelBaterija.Location = new System.Drawing.Point(1007, 260);
            this.labelBaterija.Name = "labelBaterija";
            this.labelBaterija.Size = new System.Drawing.Size(36, 13);
            this.labelBaterija.TabIndex = 4;
            this.labelBaterija.Text = "100 %";
            // 
            // timerBaterija
            // 
            this.timerBaterija.Enabled = true;
            this.timerBaterija.Interval = 100000;
            this.timerBaterija.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 1;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 1;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Interval = 1;
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // timer7
            // 
            this.timer7.Interval = 1;
            this.timer7.Tick += new System.EventHandler(this.timer7_Tick);
            // 
            // timer8
            // 
            this.timer8.Interval = 1;
            this.timer8.Tick += new System.EventHandler(this.timer8_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(39, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(36, 317);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Brush Script MT", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(508, 117);
            this.label2.TabIndex = 7;
            this.label2.Text = "AM Company";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Image = global::Nokia3310.Properties.Resources.gallery;
            this.pictureBox1.Location = new System.Drawing.Point(727, 318);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PokretanjeGalerije);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox2.Image = global::Nokia3310.Properties.Resources.Phone_ico;
            this.pictureBox2.Location = new System.Drawing.Point(918, 318);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.OtvaranjeAplikacijeZaPoruke);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LimeGreen;
            this.pictureBox3.Image = global::Nokia3310.Properties.Resources.Notes_icon;
            this.pictureBox3.Location = new System.Drawing.Point(918, 528);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(111, 110);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.OtvoriBeleznicu);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.LimeGreen;
            this.pictureBox4.Image = global::Nokia3310.Properties.Resources.clock;
            this.pictureBox4.Location = new System.Drawing.Point(727, 528);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(111, 110);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.PokretanjeSata);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.LimeGreen;
            this.pictureBox5.Image = global::Nokia3310.Properties.Resources.play1hot;
            this.pictureBox5.Location = new System.Drawing.Point(518, 528);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(111, 110);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.OtvaranjeMediaPlayera);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.LimeGreen;
            this.pictureBox6.Image = global::Nokia3310.Properties.Resources.Internet_Explorer_icon;
            this.pictureBox6.Location = new System.Drawing.Point(293, 528);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(111, 110);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.PokretanjeInternetExplorera);
            // 
            // labelSati
            // 
            this.labelSati.AutoSize = true;
            this.labelSati.BackColor = System.Drawing.Color.Black;
            this.labelSati.ForeColor = System.Drawing.Color.White;
            this.labelSati.Location = new System.Drawing.Point(927, 260);
            this.labelSati.Name = "labelSati";
            this.labelSati.Size = new System.Drawing.Size(19, 13);
            this.labelSati.TabIndex = 12;
            this.labelSati.Text = "00";
            // 
            // labelMinuti
            // 
            this.labelMinuti.AutoSize = true;
            this.labelMinuti.BackColor = System.Drawing.Color.Black;
            this.labelMinuti.ForeColor = System.Drawing.Color.White;
            this.labelMinuti.Location = new System.Drawing.Point(952, 260);
            this.labelMinuti.Name = "labelMinuti";
            this.labelMinuti.Size = new System.Drawing.Size(19, 13);
            this.labelMinuti.TabIndex = 12;
            this.labelMinuti.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(944, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = ":";
            // 
            // timerVreme
            // 
            this.timerVreme.Enabled = true;
            this.timerVreme.Interval = 1000;
            this.timerVreme.Tick += new System.EventHandler(this.timerVreme_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LimeGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(322, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Igrice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LimeGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(536, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kalkulator";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LimeGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(752, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Galerija";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LimeGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(943, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Telefon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LimeGreen;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(316, 674);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Internet";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LimeGreen;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(525, 674);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Video player";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LimeGreen;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(766, 674);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Sat";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LimeGreen;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(942, 674);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Beleske";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1369, 749);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMinuti);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelSati);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelBaterija);
            this.Controls.Add(this.progressBarBaterija);
            this.Controls.Add(this.pictureBoxCalculator);
            this.Controls.Add(this.pictureBoxIgrice);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.pictureBoxDisplay);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "AM Company";
            this.Load += new System.EventHandler(this.UcitavanjeAplikacije);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIgrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCalculator)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDisplay;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox pictureBoxIgrice;
        private System.Windows.Forms.PictureBox pictureBoxCalculator;
        private System.Windows.Forms.ProgressBar progressBarBaterija;
        private System.Windows.Forms.Label labelBaterija;
        private System.Windows.Forms.Timer timerBaterija;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Timer timer7;
        private System.Windows.Forms.Timer timer8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label labelSati;
        private System.Windows.Forms.Label labelMinuti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timerVreme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

