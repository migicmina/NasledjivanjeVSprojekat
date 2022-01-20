using System;
using System.Collections.Generic;
using System.Text;

namespace mina
{
    class Programer:Radnik
    {
        public double bonus;
       public Programer(string ime, string prezime, string jmbg, double zarada, double bonus):base(ime,prezime,jmbg,zarada)
        {
            this.bonus = bonus;
        }

        public override double godisnjaZ()
        {
            return base.godisnjaZ() + bonus / 100 * base.godisnjaZ();
        }
    }
}
