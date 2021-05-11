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
    public partial class XO : Form
    {
        public XO()
        {
            InitializeComponent();
        }
        bool potez = true;//ako je vrednost true na potezu je igrac X, ako je vrednost false na potezu je igrac O 
        int brojPoteza = 0;//broj napravljenih poteza
        private void odabranoPolje(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (potez) b.Text = "X";
            else b.Text = "O";
            potez = !potez;
            b.Enabled = false;
            brojPoteza++;
            Pobednik();
        }

        private void Pobednik()
        {

            bool pobednik = false;

            if (A1.Text == A2.Text && A2.Text == A3.Text && !A1.Enabled)
            {
                A1.BackColor = Color.Blue;
                A2.BackColor = Color.Blue;
                A3.BackColor = Color.Blue;
                pobednik = true;
            }
            else if (B1.Text == B2.Text && B2.Text == B3.Text && !B1.Enabled)
            {
                B1.BackColor = Color.Blue;
                B2.BackColor = Color.Blue;
                B3.BackColor = Color.Blue;
                pobednik = true;
            }
            else if (C1.Text == C2.Text && C2.Text == C3.Text && !C1.Enabled)
            {
                C1.BackColor = Color.Blue;
                C2.BackColor = Color.Blue;
                C3.BackColor = Color.Blue;
                pobednik = true;
            }

            else if (A1.Text == B1.Text && A1.Text == C1.Text && !A1.Enabled)
            {
                A1.BackColor = Color.Blue;
                B1.BackColor = Color.Blue;
                C1.BackColor = Color.Blue;
                pobednik = true;
            }
            else if (A2.Text == B2.Text && A2.Text == C2.Text && !A2.Enabled)
            {
                A2.BackColor = Color.Blue;
                B2.BackColor = Color.Blue;
                C2.BackColor = Color.Blue;
                pobednik = true;
            }
            else if (A3.Text == B3.Text && A3.Text == C3.Text && !A3.Enabled)
            {
                A3.BackColor = Color.Blue;
                B3.BackColor = Color.Blue;
                C3.BackColor = Color.Blue;
                pobednik = true;
            }

            else if (A1.Text == B2.Text && A1.Text == C3.Text && !A1.Enabled)
            {
                A1.BackColor = Color.Blue;
                B2.BackColor = Color.Blue;
                C3.BackColor = Color.Blue;
                pobednik = true;
            }
            else if (A3.Text == B2.Text && A3.Text == C1.Text && !C1.Enabled)
            {
                A3.BackColor = Color.Blue;
                B2.BackColor = Color.Blue;
                C1.BackColor = Color.Blue;
                pobednik = true;
            }

            if (pobednik)
            {
                OnemoguciDugmad();
                String poruka = "";
                if (potez)
                    poruka = "Pobednik je O";
                else
                    poruka = "Pobednik je X";
                MessageBox.Show(poruka);
            }
            else
            {
                if (brojPoteza == 9)
                    MessageBox.Show("Nema pobednika", "Nereseno");
            }
        }

        private void OnemoguciDugmad()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }

        private void igrajPonovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            potez = true;
            brojPoteza = 0;
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                    b.BackColor = Color.Transparent;
                }
            }
            catch { }
        }

        private void PromenaLokacije(object sender, EventArgs e)
        {
            this.Location = new Point(260, 273);//fiksna lokacija
            this.BringToFront();
        }
    }
}
