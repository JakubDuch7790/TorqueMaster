using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpmMeter.Contracts.Entities;

namespace RpmMeter.Contracts.Services
{
    public interface ICylinder
    {
        decimal CalculateForce(Cylinder cylinder);
    }
}
