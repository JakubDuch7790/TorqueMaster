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
    public bool IsRunning { get; set; }
    public bool IsGasPedalPressed { get; set; }
    public decimal Torque { get; set; }
    public decimal AggregatedForce { get; set; }

    public int NumberOfCylinders { get; set; }
    public int Pressure { get; set; }

    public bool PressGasPedal(IEngine engine)
    {
        return engine.IsGasPedalPressed = true;
    }

    public bool ReleaseGasPedal(IEngine engine)
    {
        return engine.IsGasPedalPressed = false;
    }

    public void StartEngine(IEngine engine)
    {
        engine.IsRunning = true;

        engine.Rpm = RpmConstants.IdleRpm;

        Transmission.IsInNeutral = true;
    }

    public void TurnOffEngine(IEngine engine)
    {
        engine.IsRunning = false;
        engine.Rpm = 0;
    }

    public decimal CalculateAggregatedForce(IEngine engine, Cylinder cylinder)
    {
        engine.AggregatedForce = cylinder.Force * numberOfCylinders;

        return  engine.AggregatedForce;

    }

    public decimal CalculateTorque(IEngine engine, Gear gear)
    {
        return engine.AggregatedForce * (gear.GearRadius / 2);
    }

    public int CalculateRpm(IEngine engine)
    {
        throw new NotImplementedException();
    }
}
