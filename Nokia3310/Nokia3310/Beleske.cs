using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Nokia3310
{
    class Beleske : IBeleske
    {
        ListBox l;
        public string naziv;
        public string text;
        public Beleske(ListBox l, string text, int broj)
        {
            this.l = l;
            naziv = "Beleska br." + broj + " / " + DateTime.Now ;
            this.text = text;
        }


        public void Sacuvaj()
        {
            l.Items.Add(naziv);
        }


        public bool Uporedi(string s)
        {
            if (s == naziv)
                return true;
            else return false;
        }
    }
}
