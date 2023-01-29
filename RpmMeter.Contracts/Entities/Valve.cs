using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RpmMeter.Contracts.Entities;

public class Valve
{
    private int Position 
    {
        get
        {
            return Position;
        }
        
        set
        {

        }
    }

    public int CalculatePosition()
    {
        return Position;
    }

}
