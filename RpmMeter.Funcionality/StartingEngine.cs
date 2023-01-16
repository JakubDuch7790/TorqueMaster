using RpmMeter.Contracts;

namespace RpmMeter.Funcionality
{
    public class StartingEngine : PetrolEngine
    {
        private bool StartEngine()
        {
            //GetInitialForce();
            //GetInitialTorque();
            //GetInitialRpm();

            return isRunning = true;
        }

        public void EngineRun()
        {
            while(isRunning)
            {
                Rpm = idleRpm;
            }
        }
    }
}