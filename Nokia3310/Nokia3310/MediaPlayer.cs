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
    public partial class MediaPlayer : Form
    {
        public MediaPlayer()
        {
            InitializeComponent();
        }


        //Ako je kliknuto dugme za otvaranje novog fajla
        private void buttonOtvoriFajl_Click(object sender, EventArgs e)
        {
            //Koristimo Open Fajl dijalog za izbor fajlova
            using (OpenFileDialog opf = new OpenFileDialog() { Multiselect = true, ValidateNames = true, Filter = "WMV|*.wmv|WAV|*.wav|MP3|*.mp3|MP4|*.mp4|MKV|*.mkv|3GP|*.3gp|All files|*.*"}) 
            {
                //Ako odaberemo datoteku
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    List<MediaFile>fajlovi =new List<MediaFile>();//Pravljenje liste

                    //Za svaki string u listi
                    foreach (string imeFajla in opf.FileNames)
                    {
                        FileInfo fi = new FileInfo(imeFajla);//upisivanje imena fajla u objekat tipa FileInfo
                        fajlovi.Add(new MediaFile() { ImeFajla = Path.GetFileNameWithoutExtension(fi.FullName), Putanja = fi.FullName });//Dodavanje informacija o fajlu u listu

                    }
                    listBoxLista.DataSource = fajlovi;//Dodavanje item-a u listu
                    listBoxLista.ValueMember = "Putanja";
                    listBoxLista.DisplayMember = "Ime fajla";
                }
            }
        }

        //Ako je odabran neki item iz listBoxa
        private void listBoxLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            MediaFile file = listBoxLista.SelectedItem as MediaFile;// kreiranje Media Fajla (klasa)
            //Ako je odabran item koji ne sadrzi podatke
            if (file != null)
            {
                //Pustanje odabranog fajla
                axWindowsMediaPlayer.URL = file.Putanja;
                axWindowsMediaPlayer.Ctlcontrols.play();
            }
        }

        private void MediaPlayer_Load(object sender, EventArgs e)
        {
            listBoxLista.ValueMember = "Putanja";
            listBoxLista.DisplayMember = "Ime fajla";
        }

        private void PromenaLokacije(object sender, EventArgs e)
        {
            this.Location = new Point(260, 273);//fiksna lokacija
            this.BringToFront();
        }
    }
}
