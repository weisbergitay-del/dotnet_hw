using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil.sicom2
{
    internal class PassengerPlane : Aircraft
    {
        int passengersCount;
        private int v;

        public PassengerPlane(int passengersCount, string flightNumber, int altitude) : base(flightNumber, altitude)
        {
            this.passengersCount = passengersCount;
        }

        public PassengerPlane(string flightNumber, int altitude, int v) : base(flightNumber, altitude)
        {
            this.v = v;
        }

        public override void PrintStatus()
        {
            base.PrintStatus();
            Console.WriteLine($"the passengersCount : {passengersCount}");
        }
    }


}




