using ClassVisualTesting;

namespace ClassVisualTesting;

internal class Program
{
    static void Main(string[] args)
    {


        Gear firstGear = new(1, 750);
        Gear secondGear = new(2, 600);
        Gear thirdGear = new(3, 500);
        Gear fourthGear = new(4, 400);
        Gear fifthGear = new(5, 350);


        Transmission gears = new Transmission();
        gears.AddGeartoTransmission(fifthGear);
        gears.AddGeartoTransmission(fourthGear);
        gears.AddGeartoTransmission(thirdGear);
        gears.AddGeartoTransmission(secondGear);
        gears.AddGeartoTransmission(firstGear);


        LinkedList<Gear> gearsZwei = new();

        gearsZwei.AddFirst(fifthGear);
        gearsZwei.AddFirst(fourthGear);
        gearsZwei.AddFirst(thirdGear);
        gearsZwei.AddFirst(secondGear);
        gearsZwei.AddFirst(firstGear);

        Console.WriteLine(firstGear.ToString());
        Console.WriteLine(fifthGear.ToString());
    }






}