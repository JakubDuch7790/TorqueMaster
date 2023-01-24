using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpmMeter.Contracts.Entities;

public class PetrolEngine
{


    private int Rpm { get; set; }
    private bool IsRunning { get; set; }
    private bool IsGasPedalPressed { get; set; }
    private decimal Torque { get; set; }
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