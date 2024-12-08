using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassettaSicurezza
{
    class Program
    {
        static void Main()
        {
            CassettaSicurezza c1 = new CassettaSicurezza("12345", "Sony", false, "54321");
            CassettaSicurezza c2 = new CassettaSicurezza("67890", "Panasonic", false, "09876");
            CassettaSicurezza c3 = new CassettaSicurezza("13579", "Motorola", false, "97531");

            Gioiello gioiello = new Gioiello("11223", 100, "Collana");
            Documento documento = new Documento("44556", 50, "Contratto");
            Chiave chiave = new Chiave("77889", 200, "digitale");

            c1.InserisciOggetto(gioiello, "54321");
            c2.InserisciOggetto(documento, "09876");
            c3.InserisciOggetto(chiave, "97531");

            Console.WriteLine("Cassetta 1: " + gioiello.Id + ", " + gioiello.Tipo + ", " + gioiello.ValoreDichiarato + ", " + gioiello.ValoreAssicurato);
            Console.WriteLine("Cassetta 2: " + documento.Id + ", " + documento.Tipo + ", " + documento.ValoreDichiarato + ", " + documento.ValoreAssicurato);
            Console.WriteLine("Cassetta 3: " + chiave.Id + ", " + chiave.Tipo + ", " + chiave.ValoreDichiarato + ", " + chiave.ValoreAssicurato);

            CassettaSicurezzaSpeciale cs1 = new CassettaSicurezzaSpeciale("0012345", "Sony", false, "1154321");
            CassettaSicurezzaSpeciale cs2 = new CassettaSicurezzaSpeciale("0067890", "Panasonic", false, "119876");
            CassettaSicurezzaSpeciale cs3 = new CassettaSicurezzaSpeciale("0013579", "Motorola", false, "1197531");

            c1.RimuoviOggetto("54321");
            c2.RimuoviOggetto("09876");
            c3.RimuoviOggetto("97531");

            cs1.InserisciOggetto(gioiello, "54321");
            cs2.InserisciOggetto(documento, "09876");
            cs3.InserisciOggetto(chiave, "97531");

            Console.WriteLine("Cassetta speciale 1: " + gioiello.Id + ", " + gioiello.Tipo + ", " + gioiello.ValoreDichiarato + ", " + gioiello.ValoreAssicurato + ", " + cs1.ValoreAssicurato);
            Console.WriteLine("Cassetta speciale 2: " + documento.Id + ", " + documento.Tipo + ", " + documento.ValoreDichiarato + ", " + documento.ValoreAssicurato + ", " + cs2.ValoreAssicurato);
            Console.WriteLine("Cassetta speciale 3: " + chiave.Id + ", " + chiave.Tipo + ", " + chiave.ValoreDichiarato + ", " + chiave.ValoreAssicurato + ", " + cs3.ValoreAssicurato);
        }
    }
}