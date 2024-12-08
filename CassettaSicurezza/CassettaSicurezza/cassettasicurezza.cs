using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassettaSicurezza
{
    internal class CassettaSicurezza
    {
        private string codiceSeriale;
        private string produttore;
        private bool stato;
        private string pin;
        private Oggetto oggetto;

        public CassettaSicurezza(string codiceSeriale, string produttore, bool stato, string pin)
        {
            this.codiceSeriale = codiceSeriale;
            this.produttore = produttore;
            this.stato = stato;
            this.pin = pin;
            this.oggetto = null;
        }

        public string CodiceSeriale
        {
            get { return codiceSeriale; }
        }

        private string Produttore
        {
            get { return produttore; }
        }

        private bool Stato
        {
            get { return stato; }
        }
        
        public string Pin 
        { 
            set { pin = value; }
        }

        public Oggetto Oggetto
        {
            get { return oggetto; }
        }

        public void InserisciOggetto(Oggetto oggetto, string pin)
        {
            if (oggetto == null) return;
            if (this.pin == pin)
            {
                this.oggetto = oggetto;
            }
            return;
        }

        public void RimuoviOggetto(string pin)
        {
            if (this.pin == pin)
            {
                this.oggetto = null;
            }
            return;
        }
    }
}
