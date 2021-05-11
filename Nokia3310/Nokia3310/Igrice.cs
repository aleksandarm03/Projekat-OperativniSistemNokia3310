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
    public partial class Igrice : Form
    {
        public Igrice()
        {
            InitializeComponent();
        }

        //ako je korisnik odabrao igricu "Zmijice"
        private void PokretanjeZmijice(object sender, EventArgs e)
        {
            //otvaranje igrice u novom form-u
            Form form = new Zmijice();
            OtvoriNoviForm zmijice = new OtvoriNoviForm(form);
            zmijice.Otvori();
        }

        private void PokretanjeMina(object sender, EventArgs e)
        {
            //otvaranje igrice u novom form-u
            Form form = new Mine();
            OtvoriNoviForm mw = new OtvoriNoviForm(form);
            mw.Otvori();
        }

        private void PokretanjeHelikoptera(object sender, EventArgs e)
        {
            //otvaranje igrice u novom form-u
            Form form = new Helikopter();
            OtvoriNoviForm helikopter = new OtvoriNoviForm(form);
            helikopter.Otvori();
        }

        private void PokreniKokosku(object sender, EventArgs e)
        {
            //otvaranje igrice u novom form-u
            Form form = new Kokoska();
            OtvoriNoviForm kokoska = new OtvoriNoviForm(form);
            kokoska.Otvori();
        }

        private void PokretanjeXO(object sender, EventArgs e)
        {
            //otvaranje igrice u novom form-u
            Form form = new XO();
            OtvoriNoviForm xo = new OtvoriNoviForm(form);
            xo.Otvori();
        }

        private void PokretanjePacMan(object sender, EventArgs e)
        {
            //otvaranje igrice u novom form-u
            Form form = new PacMan();
            OtvoriNoviForm pm = new OtvoriNoviForm(form);
            pm.Otvori();
        }

        private void PormenaLokacije(object sender, EventArgs e)
        {
            this.Location = new Point(260, 273);//fiksna lokacija
            this.BringToFront();
        }
    }
}
