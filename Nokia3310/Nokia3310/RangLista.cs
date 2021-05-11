using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nokia3310
{
    class RangLista
    {
        private string ime, prezime;
        public int rezultat;

        public RangLista(string ime, string prezime, int rezultat)
        {
            if (ime.Equals(String.Empty))
                throw new Exception("Mora sadrzati ime");
            else
            this.ime = ime;
            if(prezime.Equals(String.Empty))
                throw new Exception("Mora sadrzati prezime");
            else
            this.prezime = prezime;
            this.rezultat = rezultat;
        }

        public string Ispis()
        {
            return ime+" "+prezime+"-"+rezultat;
        }
    }
}
