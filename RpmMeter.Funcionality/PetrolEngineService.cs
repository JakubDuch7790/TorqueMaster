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