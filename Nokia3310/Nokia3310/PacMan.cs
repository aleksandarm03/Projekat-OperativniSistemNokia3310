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
    public partial class PacMan : Form
    {
        public PacMan()
        {
            InitializeComponent();
            label2.Visible = false;
        }

        int pobeda = 30;
        bool gore;
        bool dole;
        bool levo;
        bool desno;


        int brzina = 5;

        //ghost 1 and 2 variables. These guys are sane well sort of
        int duh1 = 8;
        int duh2 = 8;

        //ghost 3 crazy variables
        int duh3x = 8;
        int duh3y = 8;

        int rezultat = 0; //ako je kliknuto neko dugme

        private void keyisdown(object sender, KeyEventArgs e)
        {
            //ako je kliknuta strelica "<-"
            if (e.KeyCode == Keys.Left)
            {
                levo = true;//postavljanje vrednosti varijable na vrednost true
                igrac.Image = Properties.Resources.left;//animacija pokreta
            }
            //ako je kliknuta strelica "->"
            if (e.KeyCode == Keys.Right)
            {
                desno = true;//postavljanje vrednosti varijable na vrednost true
                igrac.Image = Properties.Resources.right;//animacija pokreta
            }
            //ako je kliknuta strelica "^"
            if (e.KeyCode == Keys.Up)
            {
                gore = true;//postavljanje vrednosti varijable na vrednost true
                igrac.Image = Properties.Resources.Up;//animacija pokreta
            }
            //ako je kliknuta strelica "v"
            if (e.KeyCode == Keys.Down)
            {
                dole = true;//postavljanje vrednosti varijable na vrednost true
                igrac.Image = Properties.Resources.down;//animacija pokreta
            }
        }

        //Ako taster nije pritisnut
        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                levo = false;//postavljanje vrednosti varijable na vrednost true
            }

            if (e.KeyCode == Keys.Right)
            {
                desno = false;//postavljanje vrednosti varijable na vrednost true
            }
            if (e.KeyCode == Keys.Up)
            {
                gore = false;//postavljanje vrednosti varijable na vrednost true
            }
            if (e.KeyCode == Keys.Down)
            {
                dole = false;//postavljanje vrednosti varijable na vrednost true
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Rezultat: " + rezultat; // show the score on the board


            if (levo)
            {
                igrac.Left -= brzina;
                //kretanje igraca levo 
            }
            if (desno)
            {
                igrac.Left += brzina;
                //kretanje igraca desno
            }
            if (gore)
            {
                igrac.Top -= brzina;
                //kretanje igraca prema gore
            }

            if (dole)
            {
                igrac.Top += brzina;
                //kretanje igraca prema dole

            }

            //pomeranje duhova i odbijanje od zidova
            redGhost.Left += duh1;
            yellowGhost.Left += duh2;

            // ako duh dodirne zid menja smer kretanja
            if (redGhost.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                duh1 = -duh1;
            }
            // ako duh dodirne zid menja smer kretanja
            else if (redGhost.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                duh1 = -duh1;
            }
            // ako duh dodirne zid menja smer kretanja
            if (yellowGhost.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                duh2 = -duh2;
            }
            // ako duh dodirne zid menja smer kretanja
            else if (yellowGhost.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                duh2 = -duh2;
            }



            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "wall" || x.Tag == "ghost")
                {
                    //provera da li je igrac dodirnuo zid ili duha, ako jeste kraj igre
                    if (((PictureBox)x).Bounds.IntersectsWith(igrac.Bounds))
                    {
                        igrac.Left = 0;
                        igrac.Top = 25;
                        label2.Text = "KRAJ IGRE";
                        label2.ForeColor = Color.Red;
                        label2.Visible = true;
                        timer1.Stop();
                        Restart();

                    }
                }
                if (x is PictureBox && x.Tag == "coins")
                {
                    //provera da li je igrac dodirnuo novcic, ako jeste onda se rezultat poveca
                    if (((PictureBox)x).Bounds.IntersectsWith(igrac.Bounds))
                    {
                        this.Controls.Remove(x); //brisanje novcica sa ekrana
                        rezultat++; // povecanje rezultata
                        pobeda--;
                        if (pobeda == 0)
                        {
                            timer1.Stop();
                            MessageBox.Show("Pobeda");
                            Restart();
                        }
                    }
                }
            }



            pinkGhost.Left += duh3x;
            pinkGhost.Top += duh3y;

            if (pinkGhost.Left < 1 ||
                pinkGhost.Left + pinkGhost.Width > ClientSize.Width - 2 ||
                (pinkGhost.Bounds.IntersectsWith(pictureBox4.Bounds)) ||
                (pinkGhost.Bounds.IntersectsWith(pictureBox3.Bounds)) ||
                (pinkGhost.Bounds.IntersectsWith(pictureBox1.Bounds)) ||
                (pinkGhost.Bounds.IntersectsWith(pictureBox2.Bounds))
                )
            {
                duh3x = -duh3x;
            }
            if (pinkGhost.Top < 1 || pinkGhost.Top + pinkGhost.Height > ClientSize.Height - 2)
            {
                duh3y = -duh3y;
            }
            
        }
        private void Restart()
        {
            Poruka p = new Poruka("Da li zelite da igrate ponovo");
            p.Prikazi(this, "pacman");
        }

        private void igrac_LocationChanged(object sender, EventArgs e)
        {
            OgraniciKretanje(ClientRectangle.Width - 40, ClientRectangle.Height - 40);
        }

        private void OgraniciKretanje(int duzina, int sirina)
        {
            if (igrac.Location.X >= duzina) igrac.Location = new Point(duzina, igrac.Location.Y);
            if (igrac.Location.X <= 0) igrac.Location = new Point(0, igrac.Location.Y);
            if (igrac.Location.Y >= sirina) igrac.Location = new Point(igrac.Location.X, sirina);
            if (igrac.Location.Y <= 0) igrac.Location = new Point(igrac.Location.X, 0);
        }

        private void PromenaLokacije(object sender, EventArgs e)
        {
            this.Location = new Point(260, 273);//fiksna lokacija
            this.BringToFront();
        }

      

        
    }
}
