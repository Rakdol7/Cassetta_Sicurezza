using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassetta_Sicurezza
{
    public class Gioiello : Oggetto
    {
        public Gioiello(string identificatore, double valoreDichiarato) : base(identificatore, valoreDichiarato)
        {
        }

        override public double CalcolaValoreAss()
        {
            return base.CalcolaValoreAss() * 5;
        }
    }
}
