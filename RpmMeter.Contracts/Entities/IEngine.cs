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



    void StartEngine();

    void TurnOffEngine();

    bool PressGasPedal();

    bool ReleaseGasPedal();

    decimal CalculateTorque(Gear gear);

    int CalculateRpm();

    decimal CalculateAggregatedForce(Cylinder cylinder);


}
