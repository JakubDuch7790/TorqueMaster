namespace RpmMeter.Contracts.Entities;

public class Gear
{

    public decimal GearRadius { get; set; }
    public int ShiftedGear { get; set; }

    public decimal InputOutputShaftFirstGearRatio = 3.308M;

    public decimal InputOutputShaftSecondGearRatio = 1.913M;

    public decimal InputOutputShaftThirdGearRatio = 1.267M;

    public decimal InputOutputShaftFourthGearRatio = 0.927M;

    public decimal InputOutputShaftFifthGearRatio = 0.717M;

    public int FirstGearRpmRise { get; init; }
    public int SecondGearRpmRise { get; init; }

    public int ShiftedGearRpmRise { get; set; }

    // Tu skusam vytvorit konstruktor tak, aby som tu nemusel mat x property typu xGearRpmRise, ale aby kazdy Gear vedel ze o kolko zvysuje Rpm
    // Moze to tak byt?
    public Gear(int currentGear, int rpmIncreasment)
    {
        ShiftedGear = currentGear;
        ShiftedGearRpmRise = rpmIncreasment;
    }
}

  