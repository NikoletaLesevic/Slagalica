using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Serialization;
using System.Text;

namespace Slagalica_79_2018
{
    [Serializable]
    public class Sacuvano 
    {
        public int brPoteza;
        public int sekunde;
        public int minuti;
        public int sati;
        public List<int> slicice;

        public Sacuvano(int brPoteza, int sekunde, int minuti, int sati, List<int> slicice)
        {
            this.brPoteza = brPoteza;
            this.sekunde = sekunde;
            this.minuti = minuti;
            this.sati = sati;
            this.slicice = slicice;
        }

    }
}
