using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpmMeter.Contracts;

public interface IPetrolEngineService
{
    void StartEngine(PetrolEngine petrolEngine);

    void TurnOffEngine(PetrolEngine petrolEngine);

    void SetIdleRpm(PetrolEngine petrolEngine);

    bool PressGasPedal(PetrolEngine petrolEngine);

    bool ReleaseGasPedal(PetrolEngine petrolEngine);

    decimal CalculateTorque(PetrolEngine petrolEngine);

    int CalculateRpm(PetrolEngine petrolEngine);

    decimal CalculateAggregatedForce(PetrolEngine petrolEngine);


}
