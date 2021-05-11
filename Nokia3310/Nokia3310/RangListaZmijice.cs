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
    public partial class RangListaZmijice : Form
    {
        public RangListaZmijice()
        {
            InitializeComponent();
            Lista();
            Init();
        }

        private void Init()
        {            
            label3.Text = "Igra je zavrsena. Ako zelite da igrate ponovo kliknite dugme \"Igraj ponovo\" ";
        }
        int duzina = 0;
        RangLista[] rang = new RangLista[1000];

    

        private void Lista()
        {

            listBox1.Items.Clear();
            duzina = 0;
            using (StreamReader stream = File.OpenText("Zmijice.txt"))
            {
                String s = "";
                while ((s = stream.ReadLine()) != null)
                {
                    string ime = s;
                    string prezime = stream.ReadLine();
                    int rezultat = Convert.ToInt32(stream.ReadLine());
                    rang[duzina] = new RangLista(ime, prezime, rezultat);
                    duzina++;

                }
                for (int i = 0; i < duzina - 1; i++)
                {
                    for (int j = i; j < duzina; j++)
                    {
                        if (rang[i].rezultat < rang[j].rezultat)
                        {
                            RangLista pomocna = rang[i];
                            rang[i] = rang[j];
                            rang[j] = pomocna;
                        }
                    }
                }
                for (int i = 0; i < duzina; i++)
                {
                    string s1 = rang[i].Ispis();
                    listBox1.Items.Add(s1);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter sr = File.AppendText("Zmijice.txt"))
            {
                if (textBox1.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Morate uneti ime");

                }
                else if (textBox2.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Morate uneseti prezime");

                }
                else
                {
                    button1.Enabled = false;
                    sr.WriteLine(textBox1.Text);
                    sr.WriteLine(textBox2.Text);
                    sr.WriteLine(Convert.ToString(this.Tag.ToString()));
                    sr.Close();
                    Lista();
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new Zmijice();
            OtvoriNoviForm zmijice = new OtvoriNoviForm(form);
            zmijice.Otvori();
            this.Close();
        }

        private void PromenaLokacije(object sender, EventArgs e)
        {
            this.Location = new Point(260, 273);//fiksna lokacija
            this.BringToFront();
        }       

       

    }
}
