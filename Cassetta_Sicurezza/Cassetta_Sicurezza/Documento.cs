using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassetta_Sicurezza
{
    public class Documento : Oggetto
    {
        public Documento(string identificatore, double valoreDichiarato) : base(identificatore, valoreDichiarato)
        {
        }

        override public double CalcolaValoreAss()
        {
            if (ValoreDichiarato >= 100)
            {
                return ValoreDichiarato;
            }
            else
            {
                return 50;
            }
        }
    }
}
