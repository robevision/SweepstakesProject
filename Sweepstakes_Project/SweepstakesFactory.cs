using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sweepstakes_Project
{
    public class SweepstakesFactory : ISweepstakesManager
    {
        Sweepstakes sweepstakes;
        //SPAWNER
        //CAN DO
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {

        }
        public Sweepstakes GetSweepstakes(string name)
        {
            Sweepstakes sweepstakes = new Sweepstakes();
            return sweepstakes;
        }
    }
}