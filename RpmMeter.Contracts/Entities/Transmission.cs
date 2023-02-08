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
        private class GearNode
        {
            public Gear Gear { get; set; }
            public GearNode Next { get; set; }

            public GearNode Previous { get; set; }

            public GearNode(Gear gear, GearNode next = null, GearNode previous = null)
            {
                Gear = gear;
                Next = next;
                Previous = previous;
            }
        }

        List<Gear> gears = new();

        public bool IsInNeutral { get; set; } 

        public Gear? CurrentGear { get; set; }

        public Gear FirstGear { get; set; }

        public Gear LastGear { get; set; }

        public Gear UpshiftGear() => CurrentGear.NextGear;
        public Gear DownshiftGear() => CurrentGear.PreviousGear;

        //public bool ShiftIntoNeutral() => IsInNeutral = true
        
         public void ShiftIntoNeutral()
         {
            CurrentGear = null;

            IsInNeutral = true;
         }

        public Gear Upshift()
        {
            if (CurrentGear == null)
            {
                return CurrentGear = FirstGear;
            }

            return CurrentGear.NextGear;


        }

        public Gear Downshift()
        {
            return FirstGear;
        }

        public Gear Upshift1()
        {
            if (IsInNeutral == true)
            {
                return CurrentGear;
            }
            return CurrentGear;
        }








    }
}
