using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpmMeter.Contracts
{
    public class Constants
    {
        public const int idleRpm = 1200;
        public const int maxRpm = 12000;
        public const int maxRpmBeforeUpshift = 7500;
        public const int minRpmBeforeUpshift = 2200;
        public const int maxRpmBeforeDownshift = 2500;
        public const int minRpmBeforeDownshift = 1250;
    }
}
