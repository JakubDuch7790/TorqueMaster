using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpmMeter.Contracts;

public class PetrolEngine
{


    //nevytiahnut const do samostatnej classy?

    public const int idleRpm = 1200;
    public const int maxRpm = 12000;
    public const int maxRpmBeforeUpshift = 7500;
    public const int minRpmBeforeUpshift = 2200;
    public const int maxRpmBeforeDownshift = 2500;
    public const int minRpmBeforeDownshift = 1250;

    private int rpm;
    private bool isRunning;
    private bool isGasPedalPressed;
    private decimal torque;
    public decimal aggregatedForce;

    public int Rpm
    {
        get
        {
            return rpm;
        }
        set
        {
            rpm = value;
        }
    }

    public decimal Torque
    {
        get
        {
            return torque;
        }
        set
        {
            torque = value;
        }

    }

    public bool IsRunning
    {
        get
        {
            return isRunning;
        }

        set
        {
            isRunning = value;
        }
    }

    public bool IsGasPedalPressed
    {
        get
        {
            return isGasPedalPressed;
        }

        set
        {
            isRunning = value;
        }
    }








}