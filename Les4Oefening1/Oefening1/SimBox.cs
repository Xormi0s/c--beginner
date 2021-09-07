using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening1
{

    class SimBox
    {
        private int aantalkaarten = 0;

        private SimKaart simkaart1;
        private SimKaart simkaart2;
        private SimKaart simkaart3;

        public int Aantalkaarten
        {
            get { return this.aantalkaarten; }
            set { this.aantalkaarten = value; }
        }

        public SimKaart Simkaart1
        {
            get
            {
                return this.simkaart1;
            }
            set
            {
                this.simkaart1 = value;
                Aantalkaarten = 1;
            }
        }

        public SimKaart Simkaart2
        {
            get
            {
                return this.simkaart2;
            }
            set
            {
                this.simkaart2 = value;
                Aantalkaarten = 2;
            }
        }

        public SimKaart Simkaart3
        {
            get
            {
                return this.simkaart3;
            }
            set
            {
                this.simkaart3 = value;
                Aantalkaarten = 3;
            }
        }
    }
}
