using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpmMeter.Contracts;

public class Valve
{
    private decimal position;

    public decimal Position
    {
        get
        {
            return position;
        }
        set
        {
            position = value;
        }
    }

}
