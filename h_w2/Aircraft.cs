using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil.sicom2
{
    internal class Aircraft
    {
        string flightNumber;
        int altitude;
        public Aircraft(string flightNumber, int altitude)
        {
            this.flightNumber = flightNumber;
            this.altitude = altitude;
        }
        public virtual void PrintStatus()
        {
            Console.WriteLine($"the flight Number {flightNumber} and the altitude is {altitude}");
        }
    }

}
