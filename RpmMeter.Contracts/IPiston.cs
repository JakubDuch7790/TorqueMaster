using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpmMeter.Contracts;

public interface IPiston
{
    decimal PistonPosition(Piston piston);
}
