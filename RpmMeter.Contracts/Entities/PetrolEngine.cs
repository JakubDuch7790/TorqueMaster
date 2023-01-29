using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpmMeter.Contracts.Services;

namespace RpmMeter.Contracts.Entities;

public class PetrolEngine : IEngine
{


    public int Rpm { get; set; }
    public bool IsRunning { get; set; }
    public bool IsGasPedalPressed { get; set; }
    public decimal Torque { get; set; }
    public decimal AggregatedForce { get; set; }



    public PetrolEngine()
    {
        IsRunning = false;
        IsGasPedalPressed = false;
        Rpm = 0;
        Torque = 0;
        AggregatedForce = 0;
    }

    public bool PressGasPedal(PetrolEngine petrolEngine)
    {
        return petrolEngine.IsGasPedalPressed = true;
    }

    public bool ReleaseGasPedal(PetrolEngine petrolEngine)
    {
        return petrolEngine.IsGasPedalPressed = false;
    }

    public void StartEngine(PetrolEngine petrolEngine)
    {
        petrolEngine.IsRunning = true;

        petrolEngine.Rpm = RpmConstants.IdleRpm;
    }

    public void TurnOffEngine(PetrolEngine petrolEngine)
    {
        petrolEngine.IsRunning = false;
    }

    public decimal CalculateAggregatedForce(PetrolEngine petrolEngine, Cylinder cylinder)
    {
        petrolEngine.AggregatedForce = cylinder.Force * Cylinder.numberOfCylinders;

        return petrolEngine.AggregatedForce;

    }


    public int CalculateRpm(PetrolEngine petrolEngine)
    {
        throw new NotImplementedException();
    }

    public decimal CalculateTorque(PetrolEngine petrolEngine)
    {
        throw new NotImplementedException();
    }
}