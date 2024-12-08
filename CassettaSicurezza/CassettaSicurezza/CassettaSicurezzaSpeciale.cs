using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassettaSicurezza
{
    internal class CassettaSicurezzaSpeciale: CassettaSicurezza
    {
        private double valoreAssicurato;

        public double ValoreAssicurato
        {
            get { return valoreAssicurato; }
        }

        public CassettaSicurezzaSpeciale(string codiceSeriale, string produttore, bool stato, string pin) : base(codiceSeriale, produttore, stato, pin)
        { }

        public void CalcolaValore()
        {
            Oggetto oggetto = Oggetto;

            if (oggetto is Gioiello)
            {
                valoreAssicurato = oggetto.ValoreAssicurato * 0.9;
            }
            else if (oggetto is Documento)
            {
                valoreAssicurato = oggetto.ValoreAssicurato * 0.8;
            }
            else if (oggetto is Chiave)
            {
                valoreAssicurato = oggetto.ValoreAssicurato * 0.7;
            }
            else
            {
                valoreAssicurato = 0;
            }
        }
    }
}
