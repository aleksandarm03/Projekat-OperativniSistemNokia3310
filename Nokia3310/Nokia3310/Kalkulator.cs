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
    public partial class Kalkulator : Form
    {
         string operacija = ""; //koristi se za pamcenje trenutn operacije
        double prviBroj, drugiBroj;//koristi se za pamcenje 2 uneta broja
        public Kalkulator()
        {
            InitializeComponent();
        }
        //Kada kliknemo na dugme za unos broja
        private void UnosBroja(object sender, EventArgs e)
        {
            Button b = (Button)sender;//pravljenje varijable  

            //Ako je tekst textBox-a "0"
            if (textBoxRezultat.Text == "0")
            {
                textBoxRezultat.Clear();//Brisanje teksta u textBox-a
            }

            //Ako je odabran zarez
            if (b.Text == ",")
            {
                textBoxRezultat.Text += b.Text;//Ispis zareza na textBox-u
                b.Enabled = false;  //Onemoguceno ponovni klik na dugme             
            }
            else
                textBoxRezultat.Text += b.Text; //Ispis zareza na textBox-u
        }

        //Ako korisnik zeli da obrise ceo rezultat
        private void ObrisiSve(object sender, EventArgs e)
        {
            buttonZarez.Enabled = true;//Dozvoljen ponovni klik zareza
            textBoxRezultat.Text = "0";//Brisanje teksta sa textBox-a

            //pravljenje stringa p i d
            string p, d;
            p = Convert.ToString(prviBroj);
            d = Convert.ToString(drugiBroj);
            p = "";
            d = "";
        }

        //Ako korisnik zeli da obrise jedan karakter
        private void Obrisi(object sender, EventArgs e)
        {
           buttonZarez.Enabled = true;//dozvoljen ponovni klik zareza

            //Ako je duzina texta veca od 0
            if (textBoxRezultat.Text.Length > 0)
                textBoxRezultat.Text = textBoxRezultat.Text.Remove(textBoxRezultat.Text.Length - 1, 1);//Brisanje poslednjeg karaktera
            if (textBoxRezultat.Text == " ")
                textBoxRezultat.Text = "0";//ispis "0" na textBox-u
        }

        //Ako korisnik odabere neku od operacija
        private void OPeracija(object sender, EventArgs e)
        {
            buttonZarez.Enabled = true;//Omogucen ponovni klik zareza
            Button b = (Button)sender;
            prviBroj = double.Parse(textBoxRezultat.Text);// varijabla prviBroj dobija vrednost textBox-a
            operacija = b.Text;// varijabla operacija dobija vrednost teksta dugmeta
            labelPrikazTrenutneRadnje.Text = prviBroj + " " + operacija;
            textBoxRezultat.Text = "";//Brisanje ispisa sa textBoxa
        }

        private void PrikaziRezulta(object sender, EventArgs e)
        {
            labelPrikazTrenutneRadnje.Text = "";//Brisanje teksta iz label-e
            buttonZarez.Enabled = true;//Omogucen ponovni klik zareza
            drugiBroj = double.Parse(textBoxRezultat.Text);// varijabla drugiBroj dobija vrednost textBox-a

            // provera vrednosti varijable operacija
            switch (operacija)
            {
                //Ako je operacija +
                case "+":
                    textBoxRezultat.Text = Convert.ToString(prviBroj + drugiBroj);//sabiranje varijabli prviBroj i drugiBroj i ispis na textBox
                    break;
                //Ako je operacija -
                case "-":
                    textBoxRezultat.Text = Convert.ToString(prviBroj - drugiBroj);//oduzimanje varijabli prviBroj i drugiBroj i ispis na textBox
                    break;
                //Ako je operacija *
                case "*":
                    textBoxRezultat.Text = Convert.ToString(prviBroj * drugiBroj);//mnozenje varijabli prviBroj i drugiBroj i ispis na textBox
                    break;
                //Ako je operacija /
                case "/":
                    textBoxRezultat.Text = Convert.ToString(prviBroj / drugiBroj);//deljenje varijabli prviBroj i drugiBroj i ispis na textBox
                    break;
                default:
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
