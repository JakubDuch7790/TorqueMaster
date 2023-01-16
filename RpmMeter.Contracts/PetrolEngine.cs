using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpmMeter.Contracts;

public class PetrolEngine
{
    public int Rpm;
    public bool isRunning;
    public bool isGasPedalPressed;
    public decimal torque;
    public decimal aggregatedForce;
    public const int idleRpm = 1200;
    public int maxRpm;
    public int maxRpmBeforeUpshift;

   
}