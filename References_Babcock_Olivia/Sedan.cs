using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Babcock_Olivia
{  
    class Sedan : IAutomobile
    {   // Defines get and set values
        public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public string LicensePlate { get; private set; }

        //States information about parts of the Sedan.
        public Sedan(double speed)
        {
            Wheels = 4;
            Speed = speed;
            LicensePlate = "GCTC-06";
        }
        // Calls Stringify method
        public void Stringify()
        {
            // Prints to the console
            Console.WriteLine($"The Sedan is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LicensePlate}.");
        }
        // Calls IncreaseSpeed method
        public void IncreaseSpeed()
        {   // Increases speed by 5.
            Speed += 5;
        }

        // Calls DecreaseSpeed method
        public void DecreaseSpeed()
        {   // Decreases speed by 5
            Speed -= 5;
        }
    }
}
