using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpmMeter.Contracts.Entities
{
    public interface IValve
    {
       int Position { get; set; }

       int CloseValveAndWait();

       int OpenValve();

       


    }
}
