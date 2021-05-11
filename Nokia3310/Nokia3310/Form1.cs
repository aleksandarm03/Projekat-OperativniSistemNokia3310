using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMPLib;
using System.IO;

namespace Nokia3310
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timerBaterija.Start();
            timerVreme.Start();
            panel1.BringToFront();
            panel1.Location=new Point(263, 273);
            panel1.Size = new System.Drawing.Size(790, 475);
            axWindowsMediaPlayer1.Visible = false;
            Init(); //Pokrece se odmah pri ucitavanju programa
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            g = panel1.CreateGraphics();
        }

        private void Init()
        {
            progressBarBaterija.Value = 100;
            //pictureBox2.Location = new Point(268, 280); //postavljanje pictureBox-a na zadatu lokaciju
            //pictureBox2.BringToFront();
            //pictureBox2.Visible = false;
        }

        WMPLib.WindowsMediaPlayer player = new WindowsMediaPlayer();//Koristi se za nokia sound 
        string lokacijaZvuka = Path.GetFullPath("nokia.mp3");//Lokacija sound-a

        Graphics g;//Grafik koji ce se koristiti za izradu logo-a
        Pen o = new Pen(Color.SkyBlue); // Varijabla o sluzi za iscrtavanje logo-a
        int indikatorBaterije = 100;//postavljanje procenta baterije na 100

        private void UcitavanjeAplikacije(object sender, EventArgs e)
        {
            //FullScreen aplikacije
            WindowState = FormWindowState.Normal;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Bounds = Screen.PrimaryScreen.Bounds;
            //Kraj

            //Pokretanje nokia sound-a
            player.URL = lokacijaZvuka;
            player.controls.play();
            player.settings.setMode("loop", true);
            //Kraj
        }

        //Ako je korisnik kliknuo na igrice
        private void OdabirAplikacijeZaIgrice(object sender, EventArgs e)
        {
            //otvaranje aplikacije za igrice
            Form i = new Igrice();
            OtvoriNoviForm igrice = new OtvoriNoviForm(i);
            igrice.Otvori();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            indikatorBaterije--;//smanjivanje procenata za 1
            if (indikatorBaterije < 1) //kada je procenat baterije 0
            {
                timerBaterija.Enabled = false;//zaustavljanje timer-a
                MessageBox.Show("Baterija je prazna! Isklucivanje telefona.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);//ispis poruke                
                this.Close();//zatvaranje aplikacije
            }

            else  //kada je procenat baterije veci od 0
            {
                progressBarBaterija.Value = indikatorBaterije;//baterija dobija vrednost indikatora
                string procenat = progressBarBaterija.Value.ToString() + " %"; //pravljenje stringa "procenat" sa ispisom vrednosti indikatora i znakom "%"
                labelBaterija.Text = procenat;//ispis stringa procenat u label1
            }
        }

        private void PokretanjeKalkulatora(object sender, EventArgs e)
        {
            //otvaranje kalkulatora
            Form k = new Kalkulator();
            OtvoriNoviForm kalkulator = new OtvoriNoviForm(k);
            kalkulator.Otvori();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            int x, y;
            for (x = 160; x <= 200; x++)
            {
                for (y = 290; y > 10; y--)
                {
                    g.DrawLine(o, x, y, x + 1, y);
                    continue;
                }
            }
            timer1.Stop();
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int x, y;
            for (x = 350; x >= 310; x--)
            {
                for (y = 290; y > 10; y--)
                {
                    g.DrawLine(o, x, y, x + 1, y + 1);
                    continue;
                }
            }
            timer2.Stop();
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int x, y;
            for (y = 11; y < 51; y++)
            {
                for (x = 200; x <= 310; x++)
                {
                    g.DrawLine(o, x, y, x + 1, y);
                    continue;
                }
            }
            timer3.Stop();
            timer4.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            int x, y;
            for (y = 220; y > 180; y--)
            {
                for (x = 200; x <= 310; x++)
                {
                    g.DrawLine(o, x, y, x + 1, y);
                    continue;
                }
            }
            timer4.Stop();
            timer5.Start();
            o.Color = Color.YellowGreen;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            int x, y;
            for (x = 410; x <= 450; x++)
            {
                for (y = 290; y > 10; y--)
                {
                    g.DrawLine(o, x, y, x + 1, y);
                    continue;
                }
            }
            timer5.Stop();
            timer6.Start();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            int x, y;
            for (x = 650; x >= 610; x--)
            {
                for (y = 290; y > 10; y--)
                {
                    g.DrawLine(o, x, y, x + 1, y + 1);
                    continue;
                }
            }
            timer6.Stop();
            timer7.Start();
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            for (int y = 10; y <= 80; y++)
            {
                g.DrawLine(o, 290 + 160, y, 370 + 160, y + 170);
                g.DrawLine(o, 370 + 160, y + 170, 450 + 160, y);
            }
            timer7.Stop();
            timer8.Start();
        }
        int i = 100;

        private void timer8_Tick(object sender, EventArgs e)
        {
            i--;
            if (i == 65) label2.ForeColor = Color.Red;
            if (i == 33) label2.ForeColor = Color.Blue;
            if (i == 0)
            {
                label2.ForeColor = Color.White;


            }
            if (i == -100)
            {
                timer8.Stop();
                label2.Visible = false;
                panel1.Visible = false;
                player.URL = "";
            }
        }

        private void PokretanjeGalerije(object sender, EventArgs e)
        {
            //otvaranje galerije
            Form g = new Galerija();
            OtvoriNoviForm galerija = new OtvoriNoviForm(g);
            galerija.Otvori();
        }

        private void OtvaranjeAplikacijeZaPoruke(object sender, EventArgs e)
        {
            //otvaranje aplikacije za poruke i pozive
            Form form = new PoziviIPoruke();
            OtvoriNoviForm pIp = new OtvoriNoviForm(form);
            pIp.Otvori();
        }

        private void PokretanjeInternetExplorera(object sender, EventArgs e)
        {
            //otvaranje Internet Explorera
            Form form = new InternetExplorer();
            OtvoriNoviForm internet = new OtvoriNoviForm(form);
            internet.Otvori();
        }

        private void OtvaranjeMediaPlayera(object sender, EventArgs e)
        {
            //otvaranje Media player-a
            Form form = new MediaPlayer();
            OtvoriNoviForm mp = new OtvoriNoviForm(form);
            mp.Otvori();
        }

        private void PokretanjeSata(object sender, EventArgs e)
        {
            //otvaranje aplikacije sat
            Form form = new Sat();
            OtvoriNoviForm sat = new OtvoriNoviForm(form);
            sat.Otvori();
        }

        private void timerVreme_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            labelSati.Text = String.Format("{0:00}", hh);
            labelMinuti.Text = String.Format("{0:00}", mm);
        }

        private void OtvoriBeleznicu(object sender, EventArgs e)
        {
            //otvaranje aplikacije Beleznica
            Form form = new Notes();
            OtvoriNoviForm b = new OtvoriNoviForm(form);
            b.Otvori();
        }


    }
}
