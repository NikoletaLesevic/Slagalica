using System;
using System.Collections.Generic;
using System.Text;

namespace Slagalica_79_2018
{
    public class Rezultat
    {
        public string ime;
        public int brPoteza;
        public int vreme;

        public Rezultat(string ime, int brPoteza, int vreme)
        {
            this.ime = ime;
            this.brPoteza = brPoteza;
            this.vreme = vreme;
        }
    }
}
