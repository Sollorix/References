using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Babcock_Olivia
{   
    internal class Truck : IAutomobile
    {   // Defines get and set for parts of the truck.
        public double Speed { get; private set; } 

        public int Wheels { get; private set; }

        public string LicensePlate { get; private set; }

        public double Weight { get; }

        // Defines Parameter values for the truck's parts.
        public Truck(double speedParam, double weightParam, string licenseNum)
        {
            Speed = speedParam;
            Weight = weightParam;
            LicensePlate = licenseNum;

            // Creates an if and else statement for wheels.
            if(Weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }
        // Calls stringify method
        public void Stringify()
        {   // Prints line to the console
            Console.WriteLine($"The Truck is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LicensePlate}!");
        }
        // Calls speed increase method 
        public void IncreaseSpeed()
        {   // Increases speed by 5
            Speed += 5;
        }

        // Calls speed decrease method
        public void DecreaseSpeed()
        {   // Decreases speed by 5
            Speed -= 5;
        }
    }
}
