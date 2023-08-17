namespace References_Babcock_Olivia
{
    internal class Program
    {   // Creates string value
        static void Main(string[] args)
        {
            // Defines myFirstSedan
            Sedan myFirstSedan = new Sedan(0);
            IAutomobile myAutomobile = myFirstSedan;

            // Defines new Sedan
            Sedan myOtherSedan = new Sedan(0);

            // Calls IncreaseSpeed method and writes automobile values to console.
            myFirstSedan.IncreaseSpeed();
            Console.WriteLine(myFirstSedan.Speed);
            Console.WriteLine(myAutomobile.Speed);
            Console.WriteLine(myFirstSedan.Equals(myAutomobile));

            // Calls Increase method and writes sedan values to console.
            myOtherSedan.IncreaseSpeed();
            Console.WriteLine(myFirstSedan.Speed);
            Console.WriteLine(myOtherSedan.Speed);
            Console.WriteLine(myFirstSedan.Equals(myOtherSedan));

            // Defines new truck and it's values.
            Truck myTruck = new Truck(50, 500, "MyTrUcK");

            // Calls stringify method and describes automobiles.
            myFirstSedan.Stringify();
            myAutomobile.Stringify();
            myOtherSedan.Stringify();
            myTruck.Stringify();
        }
    }
}