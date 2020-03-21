using System;

namespace TugasClassDanObject
{
    public class Taxi
    {
        public String DriverName { get; set; }
        public Boolean OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            if (OnDuty)
            {
                Console.WriteLine("On Duty : Yes");
            }
            else
            {
                Console.WriteLine("On Duty : No");
            }
            Console.WriteLine("Number Of Passenger : {0}", NumPassenger);
        }

        public void PickUpPassenger()
        {
            if (OnDuty)
            {
                Console.WriteLine("Driver {0} Sedang Menjeput Penumpang", DriverName);
            }
            else
            {
                Console.WriteLine("Driver {0} Tidak Sedang Menjemput penumpang", DriverName);
            }
        }

        public void DropOffPassenger()
        {
            if (OnDuty)
            {
                Console.WriteLine("Driver {0} Selesai Mengantar Penumpang", DriverName);
            }
            else
            {
                Console.WriteLine("Driver {0} Tidak Sedang Mengantar penumpang", DriverName);
            }
        }
    }
}
