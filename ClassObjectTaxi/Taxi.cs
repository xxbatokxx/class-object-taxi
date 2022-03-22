﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassObjectTaxi
{
    class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        // Method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name: {0}", DriverName);
            Console.WriteLine("On Duty: {0}", OnDuty);
            Console.WriteLine("Number of passenger: {0}", NumPassenger);
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang\n", DriverName);
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang\n", DriverName);
        }


    }
}
