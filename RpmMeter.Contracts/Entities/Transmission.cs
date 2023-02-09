using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static RpmMeter.Contracts.Entities.PetrolEngine;

namespace RpmMeter.Contracts.Entities
{
    public class Transmission
    {

        public LinkedList<Gear> Gears { get; set; }

        public bool IsInNeutral { get; set; } 

        public Gear CurrentGear { get; set; }

        public void UpshiftGear()
        {
            CurrentGear = Gears.ElementAt(CurrentGear!.GearLabel + 1);
        }
        public void DownshiftGear()
        {
            CurrentGear = Gears.ElementAt(CurrentGear!.GearLabel - 1);
        }

        public void ShiftIntoNeutral()
         {
            if(CurrentGear.GearLabel == 1)
            {
                IsInNeutral = true;
                DownshiftGear();
            }
         }

    }
}
