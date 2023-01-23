using RpmMeter.Contracts;

namespace RpmMeter.Funcionality;

public class PetrolEngineService : IPetrolEngineService
{
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

    public bool PressedGasPedal(PetrolEngine petrolEngine)
    {
        return petrolEngine.IsGasPedalPressed = true;
    }

    public void SetIdleRpm(PetrolEngine petrolEngine)
    {
        throw new NotImplementedException();
    }

    public void StartEngine(PetrolEngine petrolEngine)
    {
        throw new NotImplementedException();
    }
}