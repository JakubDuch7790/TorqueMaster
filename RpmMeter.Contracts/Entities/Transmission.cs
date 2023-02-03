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

        public Gear CurrentGear { get; set; }

        //Tieto dve metody ma privadzaju ku otazke moze sa NextGear definovat v uz classe Gear resp moze mat Gear ref na propertu vlastneho typu?
        public int UpshiftGear() => CurrentGear.N;

        public int DownshiftGear() => CurrentGear.PreviousGear;

        public bool ShiftIntoNeutral() => IsInNeutral = true;





    }
}
