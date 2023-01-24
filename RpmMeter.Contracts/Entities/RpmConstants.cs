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

    }
}
