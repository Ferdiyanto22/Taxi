using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    internal class Taxi
    {
        //properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        //method
        public void TaxiInfo()
        {
            Console.WriteLine("Drive Name : {0}", DriverName);
            if (OnDuty == true)
            {
                Console.WriteLine("On Duty : Yes", OnDuty);
            }
            else
            {
                Console.WriteLine("On Duty : No", OnDuty);
            }
            Console.WriteLine("Number of Passenger : {0}\n", NumPassenger);
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpangan", DriverName);
        }
        public void DropOffPassenger() 
        {
            Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
        }
    } 
}
