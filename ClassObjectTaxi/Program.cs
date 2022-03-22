using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassObjectTaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat object taxi
            Taxi taxi = new Taxi { };

            // Pengesetan nilai properties
            taxi.DriverName = "Jono";
            taxi.OnDuty = true;
            taxi.NumPassenger = 5;

            // Memanggil method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
