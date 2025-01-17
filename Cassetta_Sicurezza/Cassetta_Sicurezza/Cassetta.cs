using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassetta_Sicurezza
{
    public class Cassetta
    {
        private string? codiceSeriale;
        public string? CodiceSeriale
        {
            get { return codiceSeriale; }
            protected set { codiceSeriale = value; }
        }
        private Oggetto oggetto;
        public Oggetto Oggetto
        {
            get { return oggetto; }
        }
        private string pin;
        protected string Pin
        {
            get { return pin; }
        }

        public Cassetta(string codiceSeriale, string pin, Oggetto oggetto)
        {
            this.codiceSeriale = codiceSeriale;
            this.pin = pin;
            this.oggetto = oggetto;
        }

        public Cassetta(string codiceSeriale, string pin) : this(codiceSeriale, pin, null)
        {
        }




        public void InserisciOggetto(Oggetto oggetto, string pin)
        {
            if (this.pin == pin && oggetto != null)
            {
                this.oggetto = oggetto;
            }
        }
        public string getTipologia()
        {
            if (this.oggetto != null)
                return oggetto.GetType().ToString();
            else
                return "nessun oggetto presente ";
        }
        //oggetto is GioielloPrezioso
        //oggetto is OggettoSegreto
        //typeof oggetto 




        public Oggetto RimuoviOggetto(string pin)
        {
            Oggetto o = null;
            if (this.pin == pin && this.oggetto != null)
            {
                o = this.oggetto;
                this.oggetto = null;
            }
            return o;
        }
        public double getValoreDichiarato()
        {
            if (this.oggetto != null)
                return oggetto.ValoreDichiarato;
            else
                return 0;
        }
        public double getValoreAssicurato()
        {
            if (this.oggetto != null)
                return oggetto.CalcolaValoreAss();
            else
                return 0;

        }
    }
}
