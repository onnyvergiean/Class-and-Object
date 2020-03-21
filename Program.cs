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
            taxi.NumPassenger = 10;


            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();
        }
    }
}
