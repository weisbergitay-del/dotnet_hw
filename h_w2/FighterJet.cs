using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace targil.sicom2
{
    internal class FighterJet : Aircraft
    {
        bool missilesLoaded;
        private bool v;

        public FighterJet(bool missilesLoaded, string flightNumber, int altitude) : base(flightNumber, altitude)
        {
            this.missilesLoaded = missilesLoaded;
        }

        public FighterJet(string flightNumber, int altitude, bool v) : base(flightNumber, altitude)
        {
            this.v = v;
        }

        public override void PrintStatus()
        {
            base.PrintStatus();
            Console.WriteLine($"the missiles Loaded: {missilesLoaded}");
        }
        public void FireMissile()
        {
            if (missilesLoaded)
            {
                Console.WriteLine("Fired Missile!");
                missilesLoaded = false;
            }
            else
            {
                Console.WriteLine("No missiles loaded.");
            }
        }
    }
}
