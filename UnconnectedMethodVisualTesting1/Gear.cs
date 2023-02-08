using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVisualTesting;
public class Gear
{

    private int myVar;

    public int MyProperty
    {
        get { return myVar; }
        set { myVar = value; }
    }


    public decimal GearRadius { get; set; }

    public int GearLabel { get; set; }
   
    public int ShiftedGearRpmRise { get; init; }
    public Gear NextGear { get; set; }
    public Gear PreviousGear { get; init; }

    public Gear FirstGear { get; set; }

    public Gear(int gearLabel, int shiftedGearRpmRise)
    {
        GearLabel = gearLabel;
        ShiftedGearRpmRise = shiftedGearRpmRise;

    }
}



