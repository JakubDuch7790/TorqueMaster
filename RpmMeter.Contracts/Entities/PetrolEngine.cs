using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpmMeter.Contracts.Entities;

public class PetrolEngine : IEngine
{

    Transmission Transmission { get; set; } = new Transmission();
    public int Rpm { get; set; }

    public int TotalRpm
    {
        get
        {
            return Rpm + Transmission.CurrentGear.ShiftedGearRpmRise;
        }
    }
    public bool IsRunning { get; set; }
    public bool IsGasPedalPressed { get; set; }
    public decimal Torque { get; set; }
    public decimal AggregatedForce { get; set; }

    public int NumberOfCylinders { get; set; }
    public int Pressure { get; set; }

    public bool PressGasPedal()
    {
        return IsGasPedalPressed = true;
    }

    public bool ReleaseGasPedal()
    {
        return IsGasPedalPressed = false;
    }

    public void StartEngine()
    {
        IsRunning = true;

        Rpm = RpmConstants.IdleRpm;

        Transmission.IsInNeutral = true;
    }

    public void TurnOffEngine()
    {
        IsRunning = false;
        Rpm = 0;
    }

    public decimal CalculateAggregatedForce(Cylinder cylinder)
    {
        AggregatedForce = cylinder.Force * NumberOfCylinders;

        return  AggregatedForce;

    }

    public decimal CalculateTorque(Gear gear)
    {
        return AggregatedForce * (gear.GearRadius / 2);
    }

}
