using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RpmMeter.Contracts.PetrolEngine;

namespace RpmMeter.Contracts;

public class Cylinder
{
    private decimal force;
    private int volumeInCubicCentimetres;

    public int VolumeInCubicCentimetres
    {
        get
        {
            return volumeInCubicCentimetres;
        }
        private set 
        {
            volumeInCubicCentimetres = value;
        }
    }

    public decimal Force
    {
        get 
        {
            return force;
        }

        private set
        {
            force = value;
        }
    }

}
