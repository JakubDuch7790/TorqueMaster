using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RpmMeter.Contracts.Entities;

public class IntakeValve : IValve
{
    public int Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public IntakeValve()
    {
        Position = 0;
    }

    public int OpenValve()
    {
        
        if (Position == 0)
            {
                Position++;
                return Position;
            }

        Position--;
        return Position;
        
    }

    public int CloseValveAndWait()
    {
        throw new NotImplementedException();
    }
}
