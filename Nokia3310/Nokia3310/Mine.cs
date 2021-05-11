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
    public partial class Mine : Form
    {
        public Mine()
        {
            InitializeComponent();
        }
        int rezultat = 0;//postavljanje rezultata na 0  

        //Ako je dugme kliknuto
        private void Odabrano_polje(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Text = "";//Brisanje teksta na dugmetu
            btn.Enabled = false; //Nije dozvoljen ponovni klik na dugme
            bool tag = (bool)btn.Tag; //Postavljanje taga u zavisnosti da li je na dugmetu mina

            ////Ako se na dugmetu nalazi mina
            if (tag)
            {
                btn.BackColor = Color.Red; //Promena pozadine dugmeta u crvenu boju
                //Poziv klase za ispis rezultata
                Poruka p = new Poruka("Izgubili ste\nVas rezultat je: " + rezultat + "\nDa li zelite da igrate ponovo?");
                p.Prikazi(this, "mine");

            }
            //Ako se na dugmetu ne nalazi mina
            else
            {
                rezultat++; //povecanje rezultata za 1
                label2.Text = rezultat.ToString(); //update rezultata
                btn.BackColor = Color.SkyBlue; //Promena pozadine dugmeta u plavu boju

                //Ako je rezultat dostigao maksimalnu vrednost (22)
                if (rezultat == 22)
                {
                    //Poziv klase za ispis rezultata
                    Poruka p = new Poruka("Pobedili ste!!!\nDa li zelite da igrate ponovo?");
                    p.Prikazi(this, "mine");
                }
            }
        }
        private void Ucitavanje(object sender, EventArgs e)
        {
            int x = this.Width;
            int y = this.Height;
            Random r = new Random(); //Formiranje random varijable

            //Formiranje random brojeva koji oznacavaju lokaciju mine
            int mina1 = r.Next(1, 12);
            int mina2 = r.Next(13, 18);
            int mina3 = r.Next(19, 25);

            //Ulazak u petlju
            for (int i = 1; i <= 25; i++)
            {
                //Formiranje dugmeta
                Button buttonTemp = new Button();
                buttonTemp.Name = "buttonTemp" + i.ToString();
                buttonTemp.Size = new System.Drawing.Size(80, 75);
                buttonTemp.TabIndex = 1;
                Font font = new System.Drawing.Font(Font.Name, 43);//Deklarisanje fonta
                buttonTemp.Text = "🙂";
                buttonTemp.Font = font;//postavljanje fonta na dugme
                buttonTemp.UseVisualStyleBackColor = true;

                //Postavljanje taga dugmeta koji ima istu poziciju kao neka od mine
                if (mina1 == i || mina2 == i || mina3 == i) buttonTemp.Tag = true;
                else buttonTemp.Tag = false;


                buttonTemp.Click += new EventHandler(Odabrano_polje);//Fromiranje dogadjaja kada se klikne na neko dugme
                flowLayoutPanel1.Controls.Add(buttonTemp);//Dodavanje dugmeta na flowLayoutPanel
            }

        }

        private void Promenalokacije(object sender, EventArgs e)
        {
            this.Location = new Point(260, 273);//fiksna lokacija
            this.BringToFront();
        }

        
    }
}
