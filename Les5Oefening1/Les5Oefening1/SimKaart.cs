using System;
using System.Collections.Generic;
using System.Text;

namespace Les5Oefening1
{
    class SimKaart
    {
        public string telefoonnummer;
        public DateTime creatiedatum;
        private int aantaloproepen = 0;
        private string laatstenummer = "";

        public SimKaart(string telefoonnummer)
        {
            this.telefoonnummer = telefoonnummer;
            this.creatiedatum = DateTime.Now;
        }

        public int Aantaloproepen
        {
            get
            {
                return this.aantaloproepen;
            }

            private set
            {
                this.aantaloproepen = this.aantaloproepen + value;
            }
        }

        public string Laatstenummer
        {
            get
            {
                return this.laatstenummer;
            }

            private set
            {
                this.laatstenummer = value;
            }
        }

        public void Bel(string tel)
        {
            this.Aantaloproepen = 1;
            this.Laatstenummer = tel;
        }

        public string GeefOmschrijving()
        {
            string resultaat;
            resultaat = "\tTelefoonnummer: " + this.telefoonnummer;
            resultaat = resultaat + "\n\tCreatiedatum: " + this.creatiedatum;
            resultaat = resultaat + "\n\tAantal oproepen: " + this.aantaloproepen;
            resultaat = resultaat + "\n\tLaatste oproep: " + this.laatstenummer;
            return resultaat;
        }
    }
}
