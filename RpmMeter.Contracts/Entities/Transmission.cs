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

        public Gear? CurrentGear { get; set; }

        public Gear FirstGear { get; set; }

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

        public Gear DownshiftGear()
        {
            return FirstGear;
        }








    }
}
