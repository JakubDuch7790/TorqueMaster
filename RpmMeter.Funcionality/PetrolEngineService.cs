using RpmMeter.Contracts;
using static RpmMeter.Contracts.PetrolEngine;

namespace RpmMeter.Funcionality;

public class PetrolEngineService : IPetrolEngineService
{
    public bool StartEngine()
    {
        return IsRunning = true;
    }

    public void SetIdleRpm()
    {
        while(IsRunning)
        {
            Rpm = idleRpm;
        }
    }

    public bool PressedGasPedal()
    {
        return IsGasPedalPressed = true;
    }


    public PetrolEngineService()
    {
        IsRunning = false;
        IsGasPedalPressed = false;
        Rpm = 0;
        Torque = 0;
        //aggregatedForce = force * numberofcylinders;
    }
}