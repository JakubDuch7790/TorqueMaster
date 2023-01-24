using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RpmMeter.Contracts.Entities.PetrolEngine;

namespace RpmMeter.Contracts.Entities;

public class Cylinder
{

    public int VolumeInCubicCentimetres { get; set; }
    
    public decimal Force { get; set; }
  
}
