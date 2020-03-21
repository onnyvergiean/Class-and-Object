using System;

namespace TugasClassDanObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            taxi.DriverName = "Onny";
            taxi.OnDuty = true;
            taxi.numPassenger = 10;


            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();
        }
    }
}
