using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpmMeter.Contracts.Entities
{
    public class Piston
    {
        private int Position { get; set; }

        public int MovePiston()
        {
            if (Position == 0)
            {
                Position++;
                return Position;
            }

            Position--;
            return Position;
        }

    }
}
