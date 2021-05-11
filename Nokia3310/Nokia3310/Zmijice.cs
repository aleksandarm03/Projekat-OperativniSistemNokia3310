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
    public partial class Zmijice : Form
    {
        public Zmijice()
        {
            InitializeComponent();
            Init();
        }

        private int brojKolona = 40;
        private int brojVrsta = 23;
        private int score = 0;
        private int dx = 0;
        private int dy = 0;
        private int napred = 0;
        private int nazad = 0;
        Polje[] Zmija = new Polje[920];
        List<int> slobodnaPolja = new List<int>();
        bool[,] posecenoPolje;

        Random r = new Random();

        Timer timer = new Timer();

        private void PokreniTimer()
        {
            timer.Enabled = true;
            timer.Interval = 50;
            timer.Tick += pokret;
            timer.Start();
        }

        private void Init()
        {
            PokreniTimer();
            posecenoPolje = new bool[brojVrsta, brojKolona];
            Polje glavaZmije
                = new Polje((r.Next() % brojKolona) * 20, (r.Next() % brojVrsta) * 20);
            pictureBoxHrana.Location = new Point(r.Next(0, brojKolona) * 20, r.Next(0, brojVrsta) * 20);
            for (int i = 0; i < brojVrsta; i++)
                for (int j = 0; j < brojKolona; j++)
                {
                    posecenoPolje[i, j] = false;
                    slobodnaPolja.Add(i * brojKolona + j);
                }
            posecenoPolje[glavaZmije.Location.Y / 20, glavaZmije.Location.X / 20] = true;
            slobodnaPolja.Remove(glavaZmije.Location.Y / 20 * brojKolona + glavaZmije.Location.X / 20);
            Controls.Add(glavaZmije); Zmija[napred] = glavaZmije;
        }



        private void pokret(object sender, EventArgs e)
        {
            int x = Zmija[napred].Location.X, y = Zmija[napred].Location.Y;
            if (dx == 0 && dy == 0) return;
            if (game_over(x + dx, y + dy))
            {
                timer.Stop();
                RangLista();
                MessageBox.Show("Kraj igre. Vas rezultat je " + score);
                this.Close();

                return;
            }
            if (collisionFood(x + dx, y + dy))
            {
                score += 1;
                labelRezultat.Text = "Score: " + score.ToString();
                if (hits((y + dy) / 20, (x + dx) / 20)) return;
                Polje head = new Polje(x + dx, y + dy);
                napred = (napred - 1 + 920) % 920;
                Zmija[napred] = head;
                posecenoPolje[head.Location.Y / 20, head.Location.X / 20] = true;
                Controls.Add(head);
                koordinateHrane();
            }
            else
            {
                if (hits((y + dy) / 20, (x + dx) / 20)) return;
                posecenoPolje[Zmija[nazad].Location.Y / 20, Zmija[nazad].Location.X / 20] = false;
                napred = (napred - 1 + 920) % 920;
                Zmija[napred] = Zmija[nazad];
                Zmija[napred].Location = new Point(x + dx, y + dy);
                nazad = (nazad - 1 + 920) % 920;
                posecenoPolje[(y + dy) / 20, (x + dx) / 20] = true;
            }
        }
        private bool game_over(int x, int y)
        {
            return x < 0 || y < 0 || x > 775 || y > 400;
        }

        private bool collisionFood(int x, int y)
        {
            return x == pictureBoxHrana.Location.X && y == pictureBoxHrana.Location.Y;
        }


        private bool hits(int x, int y)
        {
            if (posecenoPolje[x, y])
            {
                timer.Stop();
                RangLista();
                MessageBox.Show("Zmija je udarila u sopstveno telo.Vas rezultat je " + score);
                this.Close();
                return true;
            }
            return false;
        }

        private void RangLista()
        {
            Form noviForm = new RangListaZmijice();
            noviForm.Text = "Rang lista Zmijice";
            noviForm.Show();
            this.Close();
            noviForm.BackColor = Color.LimeGreen;
            noviForm.Size = new Size(800, 470);
            noviForm.Location = new Point(260, 273);
            noviForm.Tag = Convert.ToString(score);
            
        }

        private void koordinateHrane()
        {
            pictureBoxHrana.Location = new Point(r.Next(0, (brojKolona - 6) % brojKolona) * 20, r.Next(0, (brojVrsta - 5) % brojVrsta) * 20);
        }

        private void PritisakTastera(object sender, KeyEventArgs e)
        {
            dx = dy = 0;
            switch (e.KeyCode)
            {
                case Keys.Right:
                    dx = 20;
                    break;
                
                case Keys.Left:
                    dx = -20;
                    break;
                case Keys.Up:
                    dy = -20;
                    break;
                case Keys.Down:
                    dy = 20;
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
