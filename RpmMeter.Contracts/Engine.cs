using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpmMeter.Contracts
{
    public abstract class Engine
    {
        private int cylindersInEngine;
        public bool _isRunning = false;
        int _force;
        public const int _initialRpm = 1200;
        public int Rpm;

        private bool StartEngine()
        {
            //GetInitialForce();
            //GetInitialTorque();
            //GetInitialRpm();
            return _isRunning = true;
        }

        public int Cylinders
        {
            get
            {
                return cylindersInEngine;
            }
        }


        public int Force
        {
            get
            {
                return _force;
            }
            set
            {
                _force = value;
            }
        }

        public int GetInitialForce()
        {
            Force = _initialRpm;
            return Force;
        }

        public void GetInitialTorque() 
        {

        }
        public int GetInitialRpm()
        {
            return _initialRpm;
        }
    }
}
