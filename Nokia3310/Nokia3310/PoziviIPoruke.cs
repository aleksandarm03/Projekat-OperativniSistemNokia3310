using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;
using WMPLib;

namespace Nokia3310
{
    public partial class PoziviIPoruke : Form
    {
        public PoziviIPoruke()
        {
            InitializeComponent();
            tabPage1.Text = "Pozivi";
            tabPage2.Text = "Poruke";
            tabPage3.Text = "Kontakti";
            textBoxBroj.Text = "";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox1.AcceptsTab = true;
            textBox1.WordWrap = true;
            KontaktLista();
            Sortiraj(listBoxPoruke);
            Sortiraj(listBoxKontakti);
            Sortiraj(listBoxKontakt3);
        }
        WMPLib.WindowsMediaPlayer player = new WindowsMediaPlayer();//Koristi se za nokia sound 
        bool proveraPozivi,proveraPoruke,proveraKontakta,ponavljanjeKontakta;//proveravaju da li je regex ispravan

        private void Sortiraj(ListBox l)
        {
            ArrayList q = new ArrayList();
            foreach (object o in l.Items)
                q.Add(o);
            q.Sort();
            l.Items.Clear();
            foreach (object o in q)
            {
                l.Items.Add(o);
            }       

        }

        Kontakti[] k = new Kontakti[1000];


        private void KontaktLista()
        {
            listBoxKontakti.Items.Clear();
            listBoxPoruke.Items.Clear();
            listBoxKontakt3.Items.Clear();
            int duzina = 0;
            using (StreamReader stream = File.OpenText("Kontakti.txt"))
            {
                String s = "";
                while ((s = stream.ReadLine()) != null)
                {
                    string ime = s;
                    string prezime = stream.ReadLine();
                    string broj = stream.ReadLine();
                    k[duzina] = new Kontakti(ime, prezime, broj);
                    duzina++;

                }

                
                for (int i = 0; i < duzina; i++)
                {
                    
                    string s1 = k[i].Ispis();
                    listBoxKontakti.Items.Add(s1);
                    listBoxPoruke.Items.Add(s1);
                    listBoxKontakt3.Items.Add(s1);
                }
                Sortiraj(listBoxPoruke);
                Sortiraj(listBoxKontakti);
                Sortiraj(listBoxKontakt3);

            }
        }

        private void OdabirBroja(object sender, EventArgs e)
        {
            string lokacijaZvuka = Path.GetFullPath("key_sound.mp4");//Lokacija sound-a
            player.URL = lokacijaZvuka;
            player.controls.play();
            Button b = (Button)sender;
            textBoxBroj.Text += b.Text;
        }



        private void ObrisiBroj(object sender, EventArgs e)
        {
            textBoxBroj.Text = "";
        }

        private void OdabIrKontakta(object sender, EventArgs e)
        {
            textBoxBroj.Text = "";

            using (StreamReader stream = File.OpenText("Kontakti.txt"))
            {
                String s;
                while ((s = stream.ReadLine()) != null)
                {
                    string ime = s;
                    string prezime = stream.ReadLine();
                    string broj = stream.ReadLine();
                    if (ime+" "+prezime == listBoxKontakti.SelectedItem.ToString())
                    {
                        textBoxBroj.Text = broj;
                    }

                }

            }
        }
        
        private void Pozovi(object sender, EventArgs e)
        {
            if(textBoxBroj.Text!="")
             proveraPozivi=Regexp(@"^(\0)?06(([0-6]|[8-9])\d{7}|(77|78)\d{7}){1}$", textBoxBroj);
            if(proveraPozivi)
            {
                 string lokacijaZvuka = Path.GetFullPath("broj_nije_dostupan.mp3");//Lokacija sound-a
                player.URL = lokacijaZvuka;
                player.controls.play();
            }
            else
            {
                 string lokacijaZvuka = Path.GetFullPath("nepostojeci_broj.3gp");//Lokacija sound-a
                player.URL = lokacijaZvuka;
            }
        }


        public bool Regexp(string re, TextBox tb)
        {
            Regex regex = new Regex(re);
            if (regex.IsMatch(tb.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        private void OdabranCet(object sender, EventArgs e)
        {
            textBox2.Text = "";
            groupBox1.Text = listBoxPoruke.SelectedItem.ToString();
            groupBox1.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                proveraPoruke = Regexp(@"^(\0)?06(([0-6]|[8-9])\d{7}|(77|78)\d{7}){1}$", textBox1);
                if (proveraPoruke)
                {
                    textBox2.Text = "";
                    groupBox1.Text = textBox1.Text;
                    groupBox1.Visible = true;
                }
                else
                {
                    string lokacijaZvuka = Path.GetFullPath("nepostojeci_broj.3gp");//Lokacija sound-a
                    player.URL = lokacijaZvuka;
                }
            }
        }

        private void Posalji(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                textBox2.Text += textBox3.Text+"\r\n\n" ;


            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string kontakt = textBox4.Text+" "+textBox5.Text;
            ponavljanjeKontakta = provera(kontakt);
            if (ponavljanjeKontakta)
            {
                MessageBox.Show("Kontakt sa unetim imenom i prezimenom vec postoji.");
            }
            else
            {
                proveraKontakta = Regexp(@"^(\0)?06(([0-6]|[8-9])\d{7}|(77|78)\d{7}){1}$", textBox6);
                if (proveraKontakta)
                {
                    using (StreamWriter sr = File.AppendText("Kontakti.txt"))
                    {
                        if (textBox4.Text.Equals(string.Empty))
                        {
                            MessageBox.Show("Morate uneti ime");

                        }
                        else if (textBox5.Text.Equals(string.Empty))
                        {
                            MessageBox.Show("Morate uneseti prezime");

                        }
                        else
                        {
                            button1.Enabled = false;
                            sr.WriteLine(textBox4.Text);
                            sr.WriteLine(textBox5.Text);
                            sr.WriteLine(textBox6.Text);
                            sr.Close();
                            KontaktLista();
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Uneli ste neispravan broj telefona\n\nZelenji format broja telefona je:\n06XXXXXXXX");
                }
            }
        }

        private bool provera(string kontakt)
        {
            using (StreamReader stream = File.OpenText("Kontakti.txt"))
            {
                string ime;
                while ((ime = stream.ReadLine()) != null)
                {
                    string prezime = stream.ReadLine();
                    stream.ReadLine();
                    if (kontakt == ime+" "+prezime)
                        return true;

                }
                return false;
            }
        }

        private void PromenaLokacije(object sender, EventArgs e)
        {
          
            this.Location = new Point(260, 273);//fiksna lokacija
            this.BringToFront();
        

        }

       

       
    }
}
