using RpmMeter.Contracts;
using static RpmMeter.Contracts.PetrolEngine;

namespace RpmMeter.Funcionality;

public class PetrolEngineService : PetrolEngine
{
    public bool StartEngine()
    {
        return isRunning = true;
    }

    public void SetIdleRpm()
    {
        while(isRunning)
        {
            Rpm = idleRpm;
        }
    }

    public bool PressedGasPedal()
    {
        return isGasPedalPressed = true;
    }


    public PetrolEngineService()
    {
        isRunning = false;
        isGasPedalPressed= false;
        Rpm = 0;
        torque = 0;
        //aggregatedForce = force * numberofcylinders;
    }
}