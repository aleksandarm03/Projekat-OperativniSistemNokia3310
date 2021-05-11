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
    public partial class Helikopter : Form
    {
        public Helikopter()
        {
            InitializeComponent();
        }
        //Deklarisanje varijabli
        bool gore;//kretanje igraca prema gore
        bool dole; // kretanje igraca prema dole
        bool pucaj = false; //kada se promeni vrednost igrac zeli da puca
        int rezultat = 0; // rezultat
        int brzinaUFO = 8; // brzina ufo-a
        Random r = new Random(); // generise random brojeve
        int brzinaIgraca = 7; // brzina igraca
        int index;//Kraj

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                gore = true;//Ako je korisnik pritisnuo strelicu "^" helikopter se pomera prema gore
            }
            if (e.KeyCode == Keys.Down)
            {
                dole = true; //Ako je korisnik pritisnuo strelicu "v" helikopter se pomera prema dole
            }

            if (e.KeyCode == Keys.Space && pucaj == false)
            {
                napraviMetak();//pozivanje funkcije napraviMetak()
                pucaj = true;//postavljanje  varijable pucaj na vrednost true
            }
        }

        private void napraviMetak()
        {

            PictureBox metak = new PictureBox();
            // kreiranje slike "metak" 

            metak.BackColor = System.Drawing.Color.DarkOrange;
            //postavljanje boje pozadine slike metak na tamno narandzastu

            metak.Height = 5;
            // postavljanje duzine slike metak na 5 piksela

            metak.Width = 10;
            // postavljanje sirine slike metak na 10 piksela

            metak.Left = igrac.Left + igrac.Width;
            // slika metak se pojavljuje levo od helikoptera

            metak.Top = igrac.Top + igrac.Height / 2;
            // slika metak se pojavljuje u horizontalnoj ravni sa helikopterom

            metak.Tag = "metak";
            // postavljanje tag-a na sliku metak

            this.Controls.Add(metak);
            // dodavanje slike metak na formu
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                gore = false; //kada je korisnik pustio strelicu "^" vrednost varijable se postavlja na false
            }
            if (e.KeyCode == Keys.Down)
            {
                dole = false; //kada je korisnik pustio strelicu "v" vrednost varijable se postavlja na false
            }

            if (pucaj == true)
            {
                pucaj = false; //ako je vrednost varijable true vracamo je posle pritiska na false kako bi korisnik 
                //mogao da puca ponovo
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            prepreka1.Left -= brzinaUFO;//pomeranje prepreke prema levo
            prepreka2.Left -= brzinaUFO;//pomeranje prepreke prema levo


            ufo.Left -= brzinaUFO;//pomeranje ufo-a prema levo

            label1.Text = "Rezultat: " + rezultat;//ispis rezultata


            if (gore)
            {

                igrac.Top -= brzinaIgraca;//pomeranje helikoptera prema gore
            }

            if (dole)
            {

                igrac.Top += brzinaIgraca;//pomeranje helikoptera prema dole
            }


            if (prepreka1.Left < -150)
            {
                prepreka1.Left = 800;//ako je prepreka levo otisla van forme pojavice se na x koordinati 800
            }

            if (prepreka2.Left < -150)
            {
                prepreka2.Left = 900;//ako je prepreka levo otisla van forme pojavice se na x koordinati 900
            }



            if (ufo.Left < -5 || igrac.Bounds.IntersectsWith(ufo.Bounds) || igrac.Bounds.IntersectsWith(prepreka1.Bounds) ||
                igrac.Bounds.IntersectsWith(prepreka2.Bounds)
                )
            {
                // ako je uslov zadovoljen igrica se zaustavlja
                timer1.Stop();
                // prikazivanje rezultata
                MessageBox.Show("Niste zavrsili misiju, ubili ste " + rezultat + " vanzemaljaca.");
                RangLista();
                this.Close();

            }



            foreach (Control X in this.Controls)
            {



                if (X is PictureBox && X.Tag == "metak")
                {
                    // pomeranje slike metka levo
                    X.Left += 15;


                    if (X.Left > 800)//ako je slika metak van forme
                    {
                        // ukloni sliku metka
                        this.Controls.Remove(X);
                        X.Dispose();
                    }


                    if (X.Bounds.IntersectsWith(ufo.Bounds))//ako slika metak dodiruje ufo
                    {

                        rezultat += 1;//povecavanje rezultata za 1
                        if (rezultat > 10)
                        {
                            brzinaUFO++;

                        }

                        this.Controls.Remove(X);// ukloni sliku metka
                        X.Dispose();


                        ufo.Left = 900;//pomeranje ufo/a

                        // generisanje random vertikalne lokacije ufo-a
                        ufo.Top = r.Next(25, 430) - ufo.Height;

                        // promena ufo funkcija da bi izgledao kao drugi ufo
                        changeUFO();
                    }
                }
            }
        }

        private void RangLista()
        {
            Form noviForm = new RangListaHelikopter();
            noviForm.Text = "Rang lista Helikopter";
            noviForm.Show();
            this.Close();
            noviForm.BackColor = Color.LimeGreen;
            noviForm.Size = new Size(800, 470);
            noviForm.Location = new Point(260, 273);
            noviForm.Tag = Convert.ToString(rezultat);
        }

        private void changeUFO()
        {
            index += 1; // povecanje index-a za 1

            if (index > 3)
            {
                // ako je index veci od 3 vrati ga na 1
                index = 1;
            }


            switch (index)
            {
                //ako je index 1 prikazi skin1
                case 1:
                    ufo.Image = Properties.Resources.alien1;
                    break;
                //ako je index 2 prikazi skin2
                case 2:
                    ufo.Image = Properties.Resources.alien2;
                    break;
                //ako je index 3 prikazi skin3
                case 3:
                    ufo.Image = Properties.Resources.alien3;
                    break;
            }
        }

        private void PromenaLokacije(object sender, EventArgs e)
        {
            this.Location = new Point(260, 273);//fiksna lokacija
            this.BringToFront();
        }

        
    }
}
