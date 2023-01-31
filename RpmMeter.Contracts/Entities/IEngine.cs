using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpmMeter.Contracts.Entities;

public interface IEngine

{
    int Rpm { get; set; }
    bool IsRunning { get; set; }
    bool IsGasPedalPressed { get; set; }
    decimal Torque { get; set; }
    decimal AggregatedForce { get; set; }

    int NumberOfCylinders { get; set; }

    int Pressure { get; set; }



    void StartEngine(IEngine engine);

    void TurnOffEngine(IEngine engine);

    bool PressGasPedal(IEngine engine);

    bool ReleaseGasPedal(IEngine engine);

    decimal CalculateTorque(IEngine engine, Gear gear);

    int CalculateRpm(IEngine engine);

    decimal CalculateAggregatedForce(IEngine engine, Cylinder cylinder);


}
