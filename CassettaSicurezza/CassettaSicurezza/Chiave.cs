using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassettaSicurezza
{
    internal class Chiave: Oggetto
    {
        private string tipo;
        public Chiave(string id, double valoreDichiarato, string tipo) : base(id, valoreDichiarato)
        {
            this.tipo = tipo;
            CalcolaValore();
        }

        public void CalcolaValore()
        {
            ValoreAssicurato = ValoreDichiarato * 1000;
        }

        public string Tipo
        {
            get { return tipo; }
        }
    }
}
