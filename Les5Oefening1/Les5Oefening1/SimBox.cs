using System;
using System.Collections.Generic;
using System.Text;

namespace Les5Oefening1
{
    class SimBox
    { 
        private SimKaart simkaart1;
        private SimKaart simkaart2;

        public SimKaart Simkaart1
        {
            get
            {
                return this.simkaart1;
            }
            set
            {
                this.simkaart1 = value;
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
            }
        }
    }
}
