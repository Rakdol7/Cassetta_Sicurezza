using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassettaSicurezza
{
    internal class Documento: Oggetto
    {
        private string tipo;
        public Documento(string id, double valoreDichiarato, string tipo) : base(id, valoreDichiarato)
        {
            this.tipo = tipo;
            CalcolaValore();
        }

        public void CalcolaValore()
        {
            if (ValoreDichiarato >= 100)
            {
                ValoreAssicurato = ValoreDichiarato;
            }
            else
            {
                ValoreAssicurato = 50;
            }
        }

        public string Tipo
        {
            get { return tipo; }
        }
    }
}
