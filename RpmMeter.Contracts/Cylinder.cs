using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpmMeter.Contracts
{
    public class Cylinder
    {
        private double Volume { get; set; }

        /*dolna a horna uvrat, da sa z toho zistit kedy su 
         * otvorene a zatvorene ventily a aky bude dalsi takt*/

        private bool PistonDown;
        private bool PistonUp;
        public int numberOfCylinders = 0;

        public Cylinder(double volume, int cylinderIndex, bool cylindersPosition)
        {
            Volume = volume;
            PistonUp= cylindersPosition;
            numberOfCylinders++;
            PistonDown= !PistonUp;

        }

    }
}
