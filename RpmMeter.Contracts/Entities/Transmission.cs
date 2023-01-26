using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RpmMeter.Contracts.Entities.PetrolEngine;

namespace RpmMeter.Contracts.Entities
{
    public class Transmission
    {

        public bool IsInNeutral { get; set; } 

        public int CurrentGear { get; set; }

        public struct GearRatios
        {
            public GearRatios()
            {
                double FirstGear = 3.308;
                double SecondGear = 1.913;
                double ThirdGear = 1.267;
                double FourthGear = 0.927;
                double FifthGear = 0.717;

            }

            
        }

    }
}
