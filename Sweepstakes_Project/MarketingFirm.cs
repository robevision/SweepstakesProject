using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sweepstakes_Project
{
    public class MarketingFirm : ISweepstakesManager
    {
        public SweepstakesStackManager SweepstakesStackManager
        {
            get => default(SweepstakesStackManager);
            set
            {
            }
        }

        public SweepstakesQueueManager SweepstakesQueueManager
        {
            get => default(SweepstakesQueueManager);
            set
            {
            }
        }
        //HAS A
        public Sweepstakes sweepstakes;
        //SPAWNER
        //CAN DO
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {

        }
        public Sweepstakes GetSweepstakes(string name)
        {
            sweepstakes = new Sweepstakes();
            return sweepstakes;
        }
    }
}