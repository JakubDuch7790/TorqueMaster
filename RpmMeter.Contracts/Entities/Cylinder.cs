using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RpmMeter.Contracts.Entities.PetrolEngine;

namespace RpmMeter.Contracts.Entities;

public class Cylinder
{
    public static int numberOfCylinders = 0;

    public decimal VolumeInCubicCentimetres{ get; set; }
    
    public decimal Force { get; set; }

    public Cylinder()
    {
        VolumeInCubicCentimetres = 399.5M;
        numberOfCylinders++;
    }
  
}
