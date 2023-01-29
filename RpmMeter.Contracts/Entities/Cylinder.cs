using RpmMeter.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RpmMeter.Contracts.Entities.PetrolEngine;

namespace RpmMeter.Contracts.Entities;

public class Cylinder
{

    public decimal VolumeInCubicCentimetres{ get; set; }
    
    public decimal Force
    {
        get
        {
            return VolumeInCubicCentimetres * RpmConstants.Acceleration;
        }
    }
  
}
