using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpmMeter.Contracts.Entities;

public class PetrolEngine : IEngine
{


    public int Rpm { get; set; }
    public bool IsRunning { get; set; }
    public bool IsGasPedalPressed { get; set; }
    public decimal Torque { get; set; }
    public decimal AggregatedForce { get; set; }

    public int numberOfCylinders { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
    }

    public void TurnOffEngine(IEngine engine)
    {
        engine.IsRunning = false;
    }

    public decimal CalculateAggregatedForce(IEngine engine, Cylinder cylinder)
    {
        engine.AggregatedForce = cylinder.Force * numberOfCylinders;

        return  engine.AggregatedForce;

    }

    public decimal CalculateTorque(IEngine engine)
    {
        throw new NotImplementedException();
    }

    public int CalculateRpm(IEngine engine)
    {
        throw new NotImplementedException();
    }
}
