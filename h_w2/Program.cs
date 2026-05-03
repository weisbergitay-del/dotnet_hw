namespace targil.sicom2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Aircraft[] fleet = new Aircraft[4];

            fleet[0] = new PassengerPlane("Passenger_1", 30000, 150);
            fleet[1] = new PassengerPlane("Passenger2", 32000, 200);
            fleet[2] = new FighterJet("Fighter_1", 20000, true);
            fleet[3] = new FighterJet("Fighter_2", 25000, true);

            foreach (Aircraft aircraft in fleet)
            {
                aircraft.PrintStatus();

                if (aircraft is FighterJet)
                {
                    FighterJet fighter = (FighterJet)aircraft;
                    fighter.FireMissile();
                }

            }
        }
    }
}

