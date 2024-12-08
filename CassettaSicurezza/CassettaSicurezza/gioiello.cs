using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassettaSicurezza
{
    internal class Gioiello: Oggetto
    {
        private string tipo;
        public Gioiello(string id, double valoreDichiarato, string tipo) : base(id, valoreDichiarato)
        {
            this.tipo = tipo;
            CalcolaValore();
        }

        public void CalcolaValore()
        {
            ValoreAssicurato = ValoreDichiarato * 5;
        }

        public string Tipo
        {
            get { return tipo; }
        }
    }
}
