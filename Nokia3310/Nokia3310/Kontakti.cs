using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nokia3310
{
    class Kontakti
    {
        public string ime;
        public string prezime;
        public string brojTelefona;

        public Kontakti(string ime, string prezime, string brojTelefona)
        {
            if (ime.Equals(String.Empty))
                throw new Exception("Mora sadrzati ime");
            else
                this.ime = ime;
            if (prezime.Equals(String.Empty))
                throw new Exception("Mora sadrzati prezime");
            else
                this.prezime = prezime;
            this.brojTelefona = brojTelefona;
        }

        public string Ispis()
        {
            string s=ime+" "+prezime;
            return s;
        }
    }
}
