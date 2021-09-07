using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening1
{
    class SimKaart
    {
        public string telefoonnummer;
        public DateTime creatiedatum;

        public SimKaart(string telefoonnummer)
        {
            this.telefoonnummer = telefoonnummer;
            this.creatiedatum = DateTime.Now;
        }

    }
}
