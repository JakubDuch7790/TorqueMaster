using RpmMeter.Contracts.Entities;
using RpmMeter.Contracts.Services;

namespace RpmMeter.Funcionality;

public class PetrolEngineService : IPetrolEngineService
{
    

    public bool PressGasPedal(PetrolEngine petrolEngine)
    {
        return petrolEngine.IsGasPedalPressed = true;
    }

    public bool ReleaseGasPedal(PetrolEngine petrolEngine)
    {
        return petrolEngine.IsGasPedalPressed = false;
    }

    public void StartEngineAndSetIdleRpm(PetrolEngine petrolEngine)
    {
        petrolEngine.IsRunning = true;

        petrolEngine.Rpm = RpmConstants.IdleRpm;
    }

    public void TurnOffEngine(PetrolEngine petrolEngine)
    {
        petrolEngine.IsRunning = false;
    }

    public decimal CalculateAggregatedForce(PetrolEngine petrolEngine)
    {
        petrolEngine.AggregatedForce = Cylinder.Force * Cylinder.numberOfCylinders;

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