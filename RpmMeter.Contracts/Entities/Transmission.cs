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
        public Gear NextGear { get; init; }
        public Gear PreviousGear { get; init; }

        public bool IsInNeutral { get; set; } 

        public int CurrentGear { get; set; }

        public int UpshiftGear() => CurrentGear + 1;

        public int DownshiftGear() => CurrentGear - 1;

        public bool ShiftIntoNeutral() => IsInNeutral = true;




    }
}
