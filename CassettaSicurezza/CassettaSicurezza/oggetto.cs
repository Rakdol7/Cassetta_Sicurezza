using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassettaSicurezza
{
    internal class Oggetto
    {
        private string id;
        private double valoreDichiarato;
        private double valoreAssicurato;

        public string Id
        {
            get { return id; }
        }

        public double ValoreDichiarato
        {
            get { return valoreDichiarato; }
        }

        public double ValoreAssicurato
        {
            get { return valoreAssicurato; }
            set { valoreAssicurato = value; }
        }

        public Oggetto(string id, double valoreDichiarato)
        {
            this.id = id;
            this.valoreDichiarato = valoreDichiarato;
            this.valoreAssicurato = 0;
        }
    }
}
