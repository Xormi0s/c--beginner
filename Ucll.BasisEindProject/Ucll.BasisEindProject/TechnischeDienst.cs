using System;
using System.Collections.Generic;
using System.Text;

namespace Ucll.BasisEindProject
{
    class TechnischeDienst
    {
        public bool VoerOnderhoudUit(Vliegtuig vliegtuig)
        {
            if (vliegtuig.OnderhoudNodig != OnderhoudType.Geen)
            {
                vliegtuig.OnderhoudNodig = OnderhoudType.Geen;
                return true;
            }
            else
            {
                return false;
            }
        }

        public int VoerOnderhoudUit(List<Vliegtuig> vliegtuigen)
        {
            int aantal = 0;
            foreach (var vliegtuig in vliegtuigen)
            {
                if (vliegtuig.OnderhoudNodig != OnderhoudType.Geen)
                {
                    vliegtuig.OnderhoudNodig = OnderhoudType.Geen;
                    aantal++;
                }
            }
            return aantal;
        }
    }
}
