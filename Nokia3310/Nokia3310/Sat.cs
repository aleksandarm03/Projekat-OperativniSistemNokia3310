using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Nokia3310
{
    public partial class Sat : Form
    {
        public Sat()
        {
            InitializeComponent();
        }
        SoundPlayer player;//Zvuk alarma
        System.Timers.Timer timerAlarm;
        Timer timerSat=new Timer();
        int DUZINA = 300, VISINA = 300, kazaljkaS = 140, kazaljkaM = 140, kazaljkaHr = 80;
        int x, y;
        Bitmap bmp;
        Graphics g;
        int stopericamin = 0, stopericasek = 0, stopericamsek = 0;
        bool pokrenutaStoperica=false;
        
        private void Sat_Load(object sender, EventArgs e)
        {
            //Podesavanje timera ~ alarm
            timerAlarm=new System.Timers.Timer();
            timerAlarm.Interval = 1000;
            timerAlarm.Elapsed+=new System.Timers.ElapsedEventHandler(timer_Elapsed);
            //kreiranje bitmap-a
            bmp = new Bitmap(DUZINA + 1, VISINA + 1);

            //centar
            x = DUZINA / 2;
            y = VISINA / 2;

            //boja pozadine
            this.BackColor = Color.White;

            //timer
            timerSat.Interval = 1000;      //1000= 1 sekunda
            timerSat.Tick += new EventHandler(this.t_Tick);
            timerSat.Start();
        }

        //ALARM
        private void timer_Elapsed(object sender, EventArgs e)
        {
            DateTime trenutnoVreme = DateTime.Now;//Ucitavanje trenutnog vremena
            DateTime odabranoVreme = dateTimePicker.Value;//Ucitavanje odabranog vremena pomocu DateTime pickera

            //Uporedjivanje vremena
            if(trenutnoVreme.Hour==odabranoVreme.Hour&&odabranoVreme.Minute==trenutnoVreme.Minute&&odabranoVreme.Second==trenutnoVreme.Second)
            {
                timerAlarm.Stop();
                try {
                    //Aktiviranje alarma
                    player = new SoundPlayer();
                    player.SoundLocation = "Alarm01.wav";
                    player.PlayLooping();
                }
                catch (Exception ex )
                {
                    MessageBox.Show(ex.Message,"Poruka",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }


        private void t_Tick(object sender, EventArgs e)
        {
            //kreiranje graphics-a
            g = Graphics.FromImage(bmp);

            //trenutno vreme
            int ss = DateTime.Now.Second;
            int mm = DateTime.Now.Minute;
            int hh = DateTime.Now.Hour;

            int[] handCoord = new int[2];

            //obrisi
            g.Clear(Color.White);

            //nacrtaj krug
            g.DrawEllipse(new Pen(Color.SaddleBrown, 1f), 0, 0, DUZINA, VISINA);

            //nacrtaj brojeve
            g.DrawString("12", new Font("Arial", 12), Brushes.Black, new PointF(140, 2));
            g.DrawString("3", new Font("Arial", 12), Brushes.Black, new PointF(286, 140));
            g.DrawString("6", new Font("Arial", 12), Brushes.Black, new PointF(142, 282));
            g.DrawString("9", new Font("Arial", 12), Brushes.Black, new PointF(0, 140));

            //kazaljka za sekunde
            handCoord = msCoord(ss, kazaljkaS);
            g.DrawLine(new Pen(Color.Red, 1f), new Point(x, y), new Point(handCoord[0], handCoord[1]));

            //kazaljka za minute
            handCoord = msCoord(mm, kazaljkaM);
            g.DrawLine(new Pen(Color.Black, 2f), new Point(x, y), new Point(handCoord[0], handCoord[1]));

            //kazaljka za sate
            handCoord = hrCoord(hh % 12, mm, kazaljkaHr);
            g.DrawLine(new Pen(Color.Gray, 3f), new Point(x, y), new Point(handCoord[0], handCoord[1]));

            //ucitavanje bmp-a u pictureBox
            pictureBox1.Image = bmp;

            //ispis vremena
            this.Text = "Analogni sat -  " + hh + ":" + mm + ":" + ss;

            //dispose (oslobodjivanje memorije)
            g.Dispose();
        }
        private int[] msCoord(int val, int hlen)
        {
            int[] coord = new int[2];
            val *= 6;   //svaka minuta i sekunda pomera kazaljku za 6 stepeni

            if (val >= 0 && val <= 180)
            {
                coord[0] = x + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = y - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = x - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = y - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }

        //koordinate kazalke za sate
        private int[] hrCoord(int hval, int mval, int hlen)
        {
            int[] coord = new int[2];

            //svaki sat pomera kazaljku za 30 stepeni
            //svaki minut pomera kazaljku za 0.5 stepeni
            int val = (int)((hval * 30) + (mval * 0.5));

            if (val >= 0 && val <= 180)
            {
                coord[0] = x + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = y - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = x - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = y - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }


        
        private void buttonStart_Click(object sender, EventArgs e)
        {
            //Aktiviranje alarma
            timerAlarm.Start();
            label1.Text = "Alarm je ukljucen";
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            //zaustavljanje alarma
            timerAlarm.Stop();
            player.Stop();
            label1.Text = "Alarm je iskljucen";
            
        }


        //STOPERICA
        private void PokreniStopericu(object sender, EventArgs e)
        {
            pokrenutaStoperica = true;
        }

        private void ZaustaviStopericu(object sender, EventArgs e)
        {
            pokrenutaStoperica = false;
        }

        private void RestartStoperice(object sender, EventArgs e)
        {
            pokrenutaStoperica = false;
            RestartVremena();

        }

        private void RestartVremena()
        {
            stopericamin = 0;
            stopericasek = 0;
            stopericamsek = 0;
        }

        private void timerStoperica_Tick(object sender, EventArgs e)
        {
            if (pokrenutaStoperica)
            {
                stopericamsek++;

                if (stopericamsek == 100)
                {
                    stopericasek++;
                    stopericamsek = 0;
                }

                if (stopericasek == 60)
                {
                    stopericamin++;
                    stopericasek = 0;
                }
            }
            PrikaziVreme();
        }

        private void PrikaziVreme()
        {
            labelMilisekunde.Text=String.Format("{0:00}",stopericamsek);
            labelSekunde.Text = String.Format("{0:00}", stopericasek);
            labelMinuti.Text = String.Format("{0:00}", stopericamin);
        }

        private void PromenaLOkacije(object sender, EventArgs e)
        {
            this.Location = new Point(260, 273);//fiksna lokacija
            this.BringToFront();
        }
     
    }
}
