using RpmMeter.Contracts;
using RpmMeter.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpmMeter.Domain
{
    public class TransmissionService : ITransmissionService
    {
        public int DownshiftGear(Transmission transmission)
        {
            throw new NotImplementedException();
        }

        public void ShiftIntoNeutral(Transmission transmission)
        {
            throw new NotImplementedException();
        }

        public int UpshiftGear(Transmission transmission)
        {
            throw new NotImplementedException();
        }
    }
}
