using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Babcock_Olivia
{ 
     interface IAutomobile
    {   // Defines get values for the speed, wheels, and license plate.
        public double Speed { get; }

        public int Wheels { get; }

        public string LicensePlate { get; }

        public void Stringify();
        
    }
}
