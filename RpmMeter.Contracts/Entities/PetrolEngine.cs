using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpmMeter.Contracts.Entities;

public class PetrolEngine
{


    public int Rpm { get; set; }
    public bool IsRunning { get; set; }
    public bool IsGasPedalPressed { get; set; }
    public decimal Torque { get; set; }
    public decimal AggregatedForce { get; set; }



    public PetrolEngine()
    {
        IsRunning = false;
        IsGasPedalPressed = false;
        Rpm = 0;
        Torque = 0;
        //aggregatedForce = 0;

    }








}