using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpmMeter;
using static RpmMeter.Contracts.Entities.IgnitionKeyLockPosition;

namespace RpmMeter.Domain;

public class IgnitionLockMovement
{

    public static int RotateKeyLockPosition0()
    {
        
        int angle = (int)IgnitionKeyLockPositions.PositionZero;
        return angle;
    }

    public int RotateKeyLockPosition1()
    {

        int angle = (int)IgnitionKeyLockPositions.PositionI;
        return angle;
    }

    public int RotateKeyLockPosition2()
    { 
        int angle = (int)IgnitionKeyLockPositions.PositionII;
        return angle;
    }

    public int RotateKeyLockPosition3()
    {
    int angle = (int)IgnitionKeyLockPositions.PositionIII;
    return angle;
    }
}
