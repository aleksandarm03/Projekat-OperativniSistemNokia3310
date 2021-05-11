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
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
        }

        int brojac = 0; //broj beleski
        TextBox t;//textBox koji se dinamicki dodaje
        Random r = new Random();//koristo se za boju textBoxa
        Beleske[] b = new Beleske[1000];//Niz klase Beleske

        //Kreiranje beleske
        private void KreirajBelesku(string s)
        {
            t = new TextBox();
            t.Size = new Size(533, 402);
            t.Location = new Point(230, 17);
            t.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
            t.AcceptsReturn = true;
            t.Multiline = true;
            t.ScrollBars = ScrollBars.Vertical;
            t.Text = s;
            Controls.Add(t);
            t.BringToFront();
           

        }

        //Dodavanje nove beleske
        private void DodajBelesku(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button1.Enabled = false;
            KreirajBelesku("");
        }

        //Cuvanje beleske
        private void Sacuvaj(object sender, EventArgs e)
        {
            try
            {
               
              
                if (!string.IsNullOrEmpty(t.Text))
                {
                    b[brojac] = new Beleske(listBox1, t.Text, brojac + 1);
                    b[brojac].Sacuvaj();
                    brojac++;
                    Controls.Remove(t);
                    button1.Enabled = true;
                }
                else {
                    MessageBox.Show("Morate uneti belesku!!!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Selektovanje beleske
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = true;
                for (int j = 0; j < brojac; j++)
                {
                    bool provera = b[j].Uporedi(listBox1.SelectedItem.ToString());
                    if (provera)
                    {
                        KreirajBelesku(b[j].text);
                        break;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PromenaLokacije(object sender, EventArgs e)
        {
            this.Location = new Point(260, 273);//fiksna lokacija
            this.BringToFront();
        }

       


       
    }
}
