using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassetta_Sicurezza
{
    public class Chiave : Oggetto
    {
        public Chiave(string identificativo, double valoreDichiarato) : base(identificativo, valoreDichiarato)
        {
        }

        override public double CalcolaValoreAss()
        {
            return base.CalcolaValoreAss() * 1000;
        }
    }
}
