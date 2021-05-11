using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Nokia3310
{
    public partial class InternetExplorer : Form
    {
        public InternetExplorer()
        {
            InitializeComponent();
            resetGame(); //Restart igre
            label3.Visible = false; 
        }


        bool skok = false; // boolean varijabla koja proverava da li je igrac pritisnuo taster za skok
        int brzinaSkoka; // varijabla koja odredjuje brzinu igraca
        int force = 12; // skok
        int rezultat = 0; // pocetna vrednost rezultata
        int brzinaprepreki = 10; // pocetna vrednost prepreka
        Random rnd = new Random(); // kreira random broj
        

        private void keyisdown(object sender, KeyEventArgs e)
        {
            //ako je igrac pritisnuo space i varijabla za skok je false

            if (e.KeyCode == Keys.Space && !skok)
            {
                skok = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                resetGame();//Restart igre
            }

            //ako varijabla skok ima vrednost true
            if (skok)
            {
                skok = false;//varijabla dobija vrednost false
            }
        }


        private void Pokretanje(object sender, EventArgs e)
        {
            // pomeranje igraca na gore
            trex.Top += brzinaSkoka;

            // prikaz rezultats
            scoreText.Text = "Rezultat: " + rezultat;

            // ako varijabla skok ima vrednost true i force je manji od 0
            if (skok && force < 0)
            {
                skok = false; //varijabla dobija vrednost false
            }

            //Ako varijabla skok ima vrednost true
            if (skok)
            {
                brzinaSkoka = -12; //brzina skoka je jednaka -12
                force -= 1;//force se smanjuje za 1
            }
           
            else
            {
                // postavi brzinu skoka na 12
                brzinaSkoka = 12;
            }

            foreach (Control x in this.Controls)
            {
                // Ako PictureBox ima tag "obstacle"
                if (x is PictureBox && x.Tag == "obstacle")
                {
                    x.Left -= brzinaprepreki; //pomeranje prepreke u levo

                    //Ako su prepreke nestale sa forma
                    if (x.Left + x.Width < -120)
                    {
                        
                        x.Left = this.ClientSize.Width + rnd.Next(200, 800);//Premesti prepreku
                       
                        rezultat++;//povecaj rezultat
                    }

                    // Ako je trex dodirnuo prepreku
                    if (trex.Bounds.IntersectsWith(x.Bounds))
                    {
                        // zaustavi timer
                        timer1.Stop();
                        //promena slike trexa
                        trex.Image = Properties.Resources.dead;
                        // prikaz poruke za restart
                        scoreText.Text += "  Pritisni R za restart";
                    }
                }
            }

            //Ako je y pozicija trexa 381 i varijabla skok ima vrednost true
            if (trex.Top >= 301 && !skok)
            {

                force = 12; // postavi force na 12
                trex.Top = floor.Top - trex.Height; // postavljanje trax-a na pictureBox "floor"
                brzinaSkoka = 0; // brzina skoka je 0
            }

            // ako je rezultat veci od 10
            if (rezultat >= 10)
            {
                
                floor.BackColor = Color.White;//promena boje PictureBox-a "floor"
                brzinaprepreki = 15;// povecaj brzinu prepreka
            }
        }

        //Restart igre
        private void resetGame()
        {

            force = 12;
            trex.Top = floor.Top - trex.Height;
            brzinaSkoka = 0;
            skok = false;
            rezultat = 0;
            brzinaprepreki = 10;
            scoreText.Text = "Rezultat: " + rezultat;
            trex.Image = Properties.Resources.running;

            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && x.Tag == "obstacle")
                {

                    int position = rnd.Next(600, 1000);

                    x.Left = 640 + (x.Left + position + x.Width * 3);
                }
            }

            timer1.Start();
        }

        int i = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            i++;            
            progressBar1.Value = i;
            if (i == 89)
            {
                label3.Visible = true;
                timer2.Stop();
            }
            
        }

        private void PromenaLokacije(object sender, EventArgs e)
        {
            this.Location = new Point(260, 273);//fiksna lokacija
            this.BringToFront();
        }
    }
}
