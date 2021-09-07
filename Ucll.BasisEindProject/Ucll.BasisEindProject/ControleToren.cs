using System;
using System.Collections.Generic;
using System.Text;

namespace Ucll.BasisEindProject
{
    class ControleToren
    {
        public List<Vliegtuig> Vliegtuigen { get; private set; } = new List<Vliegtuig>();

        public string MeldVliegtuigAan(string vluchtCode)
        {
            if (ZoekVliegtuig(vluchtCode) != null)
            {
                return "Vluchtcode werd reeds toegewezen.";
            }
            else
            {
                Vliegtuigen.Add(new Vliegtuig { Airborn = true, OnderhoudNodig = OnderhoudType.Geen, VluchtCode = vluchtCode });
                return "Vliegtuig met code " + vluchtCode + " werd aangemeld.";
            }
            
        }

        public string ToestemmingTotLanden(string vluchtCode)
        {
            Vliegtuig vliegtuig = ZoekVliegtuig(vluchtCode);

            if (vliegtuig == null)
            {
                return "Vliegtuig " + vluchtCode + " is niet gekend in het systeem.";
            }
            else
            {
                
                if (vliegtuig.Airborn)
                {
                    vliegtuig.Land();
                    return "Vliegtuig " + vluchtCode + " is geland.";
                }
                else
                {
                    return "Vliegtuig " + vluchtCode + " was reeds geland.";
                }
            }
        }
        public string ToestemmingTotOpstijgen(string vluchtCode)
        {
            Vliegtuig vliegtuig = ZoekVliegtuig(vluchtCode);

            if (vliegtuig == null)
            {
                return "Vliegtuig " + vluchtCode + " is niet gekend in het systeem.";
            }
            else
            {
                
                if (vliegtuig.Airborn)
                {
                    return "Vliegtuig " + vluchtCode + " was reeds opgestegen.";
                }
                else
                {
                    TechnischeDienst technischeDienst = new TechnischeDienst();
                    bool reparatieUitgevoerd = technischeDienst.VoerOnderhoudUit(vliegtuig);
                    return "Vliegtuig " + vluchtCode + " is opgestegen." + (reparatieUitgevoerd ? " (+ reparatie uitgevoerd)" : "");
                }
            } 
        }

        public string VerwijderUitLuchtruim(string vluchtCode)
        {
            Vliegtuig vliegtuig = ZoekVliegtuig(vluchtCode);
            if (vliegtuig != null)
            {
                Vliegtuigen.Remove(vliegtuig);
                return "Vliegtuig " + vluchtCode + " verliet het luchtruim.";
            }
            return "Vliegtuig " + vluchtCode + " is niet gekend in het systeem.";
        }

        private Vliegtuig ZoekVliegtuig(string vluchtCode)
        {
            foreach (var vliegtuig in Vliegtuigen)
            {
                if (vliegtuig.VluchtCode == vluchtCode)
                {
                    return vliegtuig;
                }
            }
            return null;
        }

        public int RepareerVliegtuigen()
        {
            TechnischeDienst technischeDienst = new TechnischeDienst();
            List<Vliegtuig> vliegtuigenOpGrond = new List<Vliegtuig>();
            foreach (var vliegtuig in Vliegtuigen)
            {
                vliegtuigenOpGrond.Add(vliegtuig);
            }
            return technischeDienst.VoerOnderhoudUit(vliegtuigenOpGrond);
        }

    }
}
