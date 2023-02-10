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

        public LinkedList<Gear> Gears { get; } = new LinkedList<Gear>();

        public bool IsInNeutral { get; set; } 

        public Gear CurrentGear { get; set; }

        public void UpshiftGear()
        {
            if (CurrentGear.GearLabel < Gears.Count)
            {
                CurrentGear = Gears.ElementAt(CurrentGear!.GearLabel + 1);
            }
            CurrentGear = CurrentGear;

        }
        public void DownshiftGear()
        {
            if (CurrentGear.GearLabel > 0)
            {
                CurrentGear = Gears.ElementAt(CurrentGear!.GearLabel - 1);
            }
            CurrentGear = CurrentGear;
        }

        public void ShiftIntoNeutral()
         {
            if(CurrentGear.GearLabel == 1 && Gears != null)
            {
                IsInNeutral = true;
                DownshiftGear();
            }
         }

    }
}
