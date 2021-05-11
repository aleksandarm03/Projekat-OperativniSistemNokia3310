using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Nokia3310
{
    public partial class Galerija : Form
    {
        public Galerija()
        {
            InitializeComponent();
        }
        string direktorijum = "";//pravljenje varijable direktorijuma
        private void PromenaLokacije(object sender, EventArgs e)
        {
            this.Location = new Point(260, 273);//fiksna lokacija
            this.BringToFront();
        }

        //Ako je kliknuto dugme za izlaz iz galerije
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();//zatvaranje form-a
        }

        //Ako je kliknuto dugme za otvaranje direktorijuma
        private void buttonOtvoriFolder_Click(object sender, EventArgs e)
        {
            try {
                listBoxSlike.Items.Clear();
                pictureBoxPrikaz.Image = null;
                var folder = new FolderBrowserDialog();//pravljenje varijable folder
                if (folder.ShowDialog() == System.Windows.Forms.DialogResult.OK)//Otvaranje DialogResult-a,ako je odgovor "OK" ulazi se u if petlju
                {
                    direktorijum = folder.SelectedPath;//direktorijum dobija vrednost putanje izabranog foldera
                    textBoxFolder.Text = direktorijum;//Tekst TextBox-a dobija vrednost izabranog foldera
                    var difolder = new DirectoryInfo(direktorijum);//pravljenje varijable sa podacima iz putanje odabranog direktorijuma
                    var fajlovi = difolder.GetFiles().Where(a=>(a.Extension.Equals(".jpg")||(a.Extension.Equals(".png"))||(a.Extension.Equals(".jepg"))||(a.Extension.Equals(".bmp"))));//prebacivanje podataka sa ekstenzijom jpg, png,jepg i bmp u varijablu fajlovi
                   

                    //Za svaku sliku u fajlovima
                    foreach (var slika in fajlovi)
                    {
                        listBoxSlike.Items.Add(slika.Name);//U listBox upisi naziv slike iz fajla
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Doslo je do nepoznate greske.Nismo uspeli da otvorimo odabranu sliku.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);//Poruka u slucaju da dodje do greske pri ucitavanju slike
            }
        }


        //Ako korisnik odabere drugu sliku
        private void IzborSlike(object sender, EventArgs e)
        {
            try
            {
                var izabranaSlika = listBoxSlike.SelectedItems[0].ToString();
                if (!string.IsNullOrEmpty(izabranaSlika))
                {
                    var putanja = Path.Combine(direktorijum,izabranaSlika);
                    pictureBoxPrikaz.Image = Image.FromFile(putanja);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Doslo je do nepoznate greske.Nismo uspeli da otvorimo odabranu sliku.",ex.Message,MessageBoxButtons.OK,MessageBoxIcon.Error);//Poruka u slucaju da dodje do greske pri ucitavanju slike
            }
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Ako je odabrana prva slika u listi
            if (listBoxSlike.SelectedIndex == 0)
            {
                listBoxSlike.SelectedIndex = listBoxSlike.Items.Count - 1;//Predji na poslednju sliku
            }
            else
            {
                listBoxSlike.SelectedIndex--;//Predji na sliku pre izabrane
            }
            IzborSlike( sender,  e);//Poziv dogadaja
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Ako je odabrana poslednja slika u listi
            if (listBoxSlike.SelectedIndex == listBoxSlike.Items.Count-1)
            {
                listBoxSlike.SelectedIndex = 0;//Predji na prvu sliku
            }
            else
            {
                listBoxSlike.SelectedIndex++;//Predji na sliku posle izabrane
            }
            IzborSlike(sender, e);//Poziv dogadaja
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBoxPrikaz.Image.RotateFlip(RotateFlipType.Rotate270FlipXY);//rotiranje slike
            pictureBoxPrikaz.Refresh();
        }

        

        

       

        
    }
    

        
    }
       
        
    

