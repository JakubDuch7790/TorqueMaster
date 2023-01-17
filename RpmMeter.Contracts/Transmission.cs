using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RpmMeter.Contracts.PetrolEngine;

namespace RpmMeter.Contracts
{
    public class Transmission
    {
        private bool isInNeutral;
        private int currentGear;

        public bool IsInNeutral
        {
            get
            {
                return isInNeutral;
            }

            set
            { 
                isInNeutral = value;
            }
        }

        public int CurrentGear
        {
            get
            {
                return currentGear;
            }

            set
            {
                currentGear = value;
            }
        }

    }
}
