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
    public partial class Kokoska : Form
    {
        public Kokoska()
        {
            InitializeComponent();
        }
        bool levo; //varijabla ce se koristiti za kretanje igraca levo
        bool desno; //varijabla ce se koristiti za kretanje igraca desno
        int brzina = 3; // postavljanje brzine padanja jaja na 10
        int rezultat = 0; // rezultat
        int razbijenaJaja = 0; //razbijena jaja
        Random rndY = new Random(); //random Y koordinata
        Random rndX = new Random(); //random X koordinata
        PictureBox razbijenoJaje = new PictureBox();// kreiranje pictureBox-a koji ce se dinamicki dodavati

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Broj uhvacenih jaja: " + rezultat; // prikaz rezultata
            label2.Text = "Broj razbijenih jaja: " + razbijenaJaja; // prikaz broja razbijenih jaja

            // ako je uslov zadovoljen i pozicija X koordinate igraca je veca od 0
            if (levo == true && chicken.Left > 0)
            {
                // pomeranje slike 15 piksela levo
                chicken.Left -= 15;
                //animacija za kretanje levo
                chicken.Image = Properties.Resources.chicken_normal2;
            }

            // ako je uslov zadovoljen i pozicija X koordinate igraca je manja od sirine form-a
            if (desno == true && chicken.Left + chicken.Width < this.ClientSize.Width)
            {
                // pomeranje slike 15 piksela desno
                chicken.Left += 15;
                //animacija za kretanje desno
                chicken.Image = Properties.Resources.chicken_normal;
            }

            // provera da li je jaje dodirnulo y koordinatu koja je jednaka visini form-a
            foreach (Control X in this.Controls)
            {
                // ako je X pictureBox sa tagom "jaje"
                if (X is PictureBox && X.Tag == "jaje")
                {
                    // pomeri sliku prema dole
                    X.Top += brzina;

                    // ako je jaje dodirnulo y koordinatu koja je jednaka visini form-a
                    if (X.Top + X.Height > this.ClientSize.Height)
                    {
                        // prikaz razbijenog jajeta
                        razbijenoJaje.Image = Properties.Resources.splash; //postavljanje slike razbijenog jajeta
                        razbijenoJaje.Location = X.Location; // slika razbijenog jajeta se pojavljuje na poziciji gde je jaje dodirnulo pod
                        razbijenoJaje.Height = 59; // postavljanje visine slike
                        razbijenoJaje.Width = 60; // postavljanje sirine slike
                        razbijenoJaje.BackColor = System.Drawing.Color.Transparent; // transparentna pozadina slike

                        this.Controls.Add(razbijenoJaje); // dodavanje slike razbijenog jaja na form

                        X.Top = rndY.Next(80, 300) * -1; // pozicija jaja je random y koordinata
                        X.Left = rndX.Next(5, this.ClientSize.Width - X.Width);  // pozicija jaja je random X koordinata
                        razbijenaJaja++; // razbijeno jaje++
                        chicken.Image = Properties.Resources.chicken_hurt; // animacija kokoske
                    }

                    //ako kokoska dodirne jaje
                    if (X.Bounds.IntersectsWith(chicken.Bounds))
                    {
                        X.Top = rndY.Next(100, 300) * -1; // pozicija jaja je random Y koordinata
                        X.Left = rndX.Next(5, this.ClientSize.Width - X.Width); // pozicija jaja je random X koordinata
                        rezultat++; //dodaj 1 na rezultat
                    }

                    // ako je rezultat veci od 20
                    if (rezultat >= 10)
                    {

                        brzina = 12; // brzina je random
                    }

                    //ako je broj razbijenih jaja veci od 5
                    if (razbijenaJaja > 5)
                    {
                        timer1.Stop(); //zaustavi timer
                        //prikaz poruke 
                        Poruka p = new Poruka("Kraj igre. Vas rezultat je " + rezultat + ".\nDa li zelite da igrate ponovo?");
                        p.Prikazi(this, "kokoska");
                        razbijenaJaja = 0;
                    }

                }
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                //ako je korisnik pritisnuo strelicu "->" vrednost varijable levo je true
                levo = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                //ako je korisnik pritisnuo strelicu "<-" vrednost varijable desno je true
                desno = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                //ako je korisnik prnije itisnuo strelicu "->" vrednost varijable levo je false
                levo = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                //ako je korisnik nije pritisnuo strelicu "<-" vrednost varijable desno je false
                desno = false;
            }
        }

        private void PromenaLokacije(object sender, EventArgs e)
        {
            this.Location = new Point(260, 273);//fiksna lokacija
            this.BringToFront();
        }  
       
    }
}
