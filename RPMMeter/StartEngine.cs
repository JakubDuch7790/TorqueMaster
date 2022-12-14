using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPMMeter
{
    internal class Engine
    {
        private bool _isRunning = false;
        int _force;
        public int _initialRpm = 1200;

        private bool StartEngine()
        {
            GetInitialForce();
            GetInitialTorque();
            GetInitialRpm();
            return _isRunning = true;
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
