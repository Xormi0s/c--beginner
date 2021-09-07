using System;
using System.Collections.Generic;
using System.Text;

namespace Ucll.BasisEindProject
{
    enum OnderhoudType
    {
        Geen,
        Klein,
        Groot
    }
    class Vliegtuig
    {
        private string vluchtCode;

        public string VluchtCode
        {
            get { return vluchtCode; }
            set
            {
                if (value.Length > 10)
                {
                    vluchtCode = value.Substring(0, 10);
                }
                else
                {
                    vluchtCode = value;
                }
            }
        }

        public bool Airborn { get; set; }
        public OnderhoudType OnderhoudNodig { get; set; }
        public void Land()
        {
            int random = new Random().Next(0, 11);
            if (random > 7)
            {
                OnderhoudNodig = OnderhoudType.Groot;
            }
            else if (random > 3)
            {
                OnderhoudNodig = OnderhoudType.Klein;
            }
            else
            {
                OnderhoudNodig = OnderhoudType.Geen;
            }
            Airborn = false;
        }

        public void StijgOp()
        {
            Airborn = true;
        }

        public string GeefOmschrijving()
        {
            return "Vliegtuig - " + VluchtCode.PadRight(10, ' ') + " Onderhoudnodig: " + (OnderhoudNodig.ToString().PadRight(5, ' ')) + " Airborn: " + (Airborn ? "Ja" : "Nee");
        }
    }
}
