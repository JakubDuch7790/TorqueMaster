using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpmMeter.Contracts.Entities
{
    public static class RpmConstants
    {
        public const int IdleRpm = 1200;
        public const int MaxRpm = 12000;
        public const int MaxRpmBeforeUpshift = 7500;
        public const int MinRpmBeforeUpshift = 2200;
        public const int MaxRpmBeforeDownshift = 2500;
        public const int MinRpmBeforeDownshift = 1250;
        public const decimal Acceleration = 9.80665M;


        // given Values are valid only for 1.6l Skoda Felicia petrolEngine
        public const int MaxPowerBy4500RpmInKW = 55;
        public const int MaxTorqueBy3500RpmInNewtonMetres = 136;

    }
}
