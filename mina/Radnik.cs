using System;
using System.Collections.Generic;
using System.Text;

namespace mina
{
    class Radnik
    {
        public string ime;
        public string prezime;
        public string jmbg;
        public double zarada;

        public Radnik(string ime, string prezime, string jmbg, double zarada)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.jmbg = jmbg;
            this.zarada = zarada;
        }

        public virtual double godisnjaZ()
        {
            return zarada * 12;
        }

    }
}
