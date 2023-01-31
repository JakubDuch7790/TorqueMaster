using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpmMeter.Contracts.Entities;

public class Stroke
{
    IntakeValve intakeValve1 = new();
    ExhaustValve exhaustValve1 = new();
    Piston piston = new();
    Cylinder cylinder = new();


    public void SimulateIntake()
    {
        piston.MovePiston();
        intakeValve1.OpenValve();
    }
    public void SimulateCompresion()
    {
        piston.MovePiston();
        intakeValve1.CloseValveAndWait();
        exhaustValve1.CloseValveAndWait();
    }

    public void SimulatePower()
    {
        piston.MovePiston();
        cylinder.GenerateForce();

    }

    public void SimulateExhaust()
    {
        piston.MovePiston();
        exhaustValve1.OpenValve();
    }


}
