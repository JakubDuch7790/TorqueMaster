using ClassVisualTesting;
using System.Diagnostics.CodeAnalysis;

namespace ClassVisualTesting;

public class Transmission
{
    class TransmissionGearNode
    {
        public Gear gear;
        public TransmissionGearNode? nextGear;

        public TransmissionGearNode(Gear x)
        {
            gear = x;
            nextGear = null;
        }
    }

    TransmissionGearNode? transmissionHead;

    public void AddGeartoTransmission(Gear newGear)
    {
        TransmissionGearNode gear = new TransmissionGearNode(newGear);
        gear.nextGear = transmissionHead;
        transmissionHead = gear;
    }

    public void PrintGearsInTransmission()
    {
        TransmissionGearNode runner = transmissionHead;
        while (runner != null)
        {
            Console.WriteLine(runner.nextGear);
            runner = runner.nextGear;
        }
    }

    LinkedList<Gear> gearsZwei = new();

    




    private bool isInNeutral = true;
    public bool IsInNeutral { get; set; }
    public Gear? CurrentGear { get; set; }

    public LinkedList<Gear> Gears { get; set; }



    public Gear UpshiftGear() => Gears.First();
    public Gear DownshiftGear() => CurrentGear.PreviousGear;

        //public bool ShiftIntoNeutral() => IsInNeutral = true

    public void ShiftIntoNeutral()
        {
            CurrentGear = null;

            IsInNeutral = true;
        }


    


}

