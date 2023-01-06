using RpmMeter.Contracts;

namespace RpmMeter.Funcionality
{
    public class StartingEngine : Engine
    {
        private bool StartEngine()
        {
            //GetInitialForce();
            //GetInitialTorque();
            //GetInitialRpm();
            return _isRunning = true;
        }

        public void EngineRun()
        {
            while(_isRunning)
            {
                Rpm = _initialRpm;
            }
        }
    }
}