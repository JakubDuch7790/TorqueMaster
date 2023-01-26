using RpmMeter.Contracts.Entities;
using RpmMeter.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpmMeter.Domain
{
    internal class CylinderService : ICylinder
    {
        public decimal CalculateForce(Cylinder cylinder)
        {
            cylinder.Force = cylinder.VolumeInCubicCentimetres * RpmConstants.Acceleration;

            return cylinder.Force;
        }
    }
}
