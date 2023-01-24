using RpmMeter.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpmMeter.Contracts.Services;

public interface ITransmission
{
    int UpshiftGear(Transmission transmission);

    int DownshiftGear(Transmission transmission);

    void ShiftIntoNeutral(Transmission transmission);


}
