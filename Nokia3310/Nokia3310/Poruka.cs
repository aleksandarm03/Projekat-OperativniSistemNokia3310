using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Nokia3310
{
    class Poruka
    {
        private string poruka;
        public Poruka(string poruka)
        {
            this.poruka = poruka;
        }

        public void Prikazi(Form form, string naziv)
        {
            DialogResult opcija = MessageBox.Show(poruka, "", MessageBoxButtons.YesNo);
            if (opcija == DialogResult.Yes)
            {
                form.Close();
                switch (naziv)
                {
                  case "pacman":
                       form = new PacMan();
                      break;
                   case "zmijica":
                        form = new Zmijice();
                        break;
                   case "helikopter":
                        form = new Helikopter();
                        break;
                    case "kokoska":
                        form = new Kokoska();
                        break;
                 
                    case "mine":
                        form = new Mine();
                        break;
                }

                OtvoriNoviForm pacman = new OtvoriNoviForm(form);
                pacman.Otvori();

            }
            else form.Close();
        }
    }
}
