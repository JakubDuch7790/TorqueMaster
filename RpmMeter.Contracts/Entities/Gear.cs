namespace RpmMeter.Contracts.Entities;

public class Gear
{


    public decimal GearRadius { get; set; }
    public int GearLabel { get; set; }
    public bool NeutralGear { get; set; }
    public int ShiftedGearRpmRise { get; init; }

    public decimal InputOutputShaftFirstGearRatio = 3.308M;

    public decimal InputOutputShaftSecondGearRatio = 1.913M;

    public decimal InputOutputShaftThirdGearRatio = 1.267M;

    public decimal InputOutputShaftFourthGearRatio = 0.927M;

    public decimal InputOutputShaftFifthGearRatio = 0.717M;



    public Gear(int gearLabel, int shiftedGearRpmRise)
    {
        GearLabel = gearLabel;
        ShiftedGearRpmRise = shiftedGearRpmRise;
        
    }
}

  