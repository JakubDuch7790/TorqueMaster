using RpmMeter.Contracts;

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

    public void SetIdleRpm(PetrolEngine petrolEngine)
    {
       while (petrolEngine.IsRunning && !petrolEngine.IsGasPedalPressed)
        {
            petrolEngine.Rpm = Constants.idleRpm;
        }
    }

    public void StartEngine(PetrolEngine petrolEngine)
    {
        petrolEngine.IsRunning = true;
    }

    public void TurnOffEngine(PetrolEngine petrolEngine)
    {
        petrolEngine.IsRunning = false;
    }

    public decimal CalculateAggregatedForce(PetrolEngine petrolEngine)
    {
        throw new NotImplementedException();
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