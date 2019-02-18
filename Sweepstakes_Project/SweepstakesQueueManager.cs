using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sweepstakes_Project
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        //HAS A
       Sweepstakes sweepstakes;
        //SPAWNER
        //CAN DO
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {

        }
        public Sweepstakes GetSweepstakes(string name)
        {
            //Sweepstakes sweepstakes = new Sweepstakes();
            return sweepstakes;
        }
    }
}