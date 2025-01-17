using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassetta_Sicurezza
{
    public class Oggetto
    {
        private string identificatore;
        public string Identificatore
        {
            get { return identificatore; }
        }
        private double valoreDichiarato;
        public double ValoreDichiarato
        {
            get { return valoreDichiarato; }
        }
        virtual public double CalcolaValoreAss()
        { return valoreDichiarato; }
        public Oggetto(string identificatore, double valoreDichiarato)
        {
            this.identificatore = identificatore;
            this.valoreDichiarato = valoreDichiarato;
        }
    }
}
