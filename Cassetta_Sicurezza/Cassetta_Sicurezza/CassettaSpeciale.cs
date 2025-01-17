using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassetta_Sicurezza
{
    public class CassettaSpeciale : Cassetta
    {
        public CassettaSpeciale(string codiceSeriale, string pin, Oggetto oggetto) : base(codiceSeriale, pin, oggetto)
        {

        }
        public CassettaSpeciale(string codiceSeriale, string pin) : this(codiceSeriale, pin, null)
        {
        }
    }
}
