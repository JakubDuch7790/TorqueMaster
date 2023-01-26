using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpmMeter.Contracts.Entities;

namespace RpmMeter.Contracts.Services;

public interface IPetrolEngineService
{
    void StartEngineAndSetIdleRpm(PetrolEngine petrolEngine);

    void TurnOffEngine(PetrolEngine petrolEngine);

    bool PressGasPedal(PetrolEngine petrolEngine);

    bool ReleaseGasPedal(PetrolEngine petrolEngine);

    decimal CalculateTorque(PetrolEngine petrolEngine);

    int CalculateRpm(PetrolEngine petrolEngine);

    decimal CalculateAggregatedForce(PetrolEngine petrolEngine, Cylinder cylinder);


}
