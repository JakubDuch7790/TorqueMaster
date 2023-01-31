using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpmMeter.Contracts.Entities
{
    public class ExhaustValve : IValve
    {
        public int Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ExhaustValve()
        {
            Position = 1;
        }
        public int OpenValve()
        {

            if (Position == 0)
            {
                Position++;
                return Position;
            }

            Position--;
            return Position;

        }

        public int CloseValveAndWait()
        {
            throw new NotImplementedException();
        }
    }
}
