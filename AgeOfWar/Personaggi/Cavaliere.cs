using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfWar.Personaggi
{
    public class Cavaliere:Personaggio
    {
        public Cavaliere(int puntiForza)
        {
            PuntiVita = 1000;
            PuntiForza += puntiForza;
        }

    }
}
