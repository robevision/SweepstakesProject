using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sweepstakes_Project
{
    public class SweepstakesManagerFactory
    {
        public ISweepstakesManager GetSweepstakesManagement()
        {
            switch (UI.ChooseManagementSystem())
            {
                case "stack":
                    SweepstakesStackManager stackManager = new SweepstakesStackManager();
                    return stackManager;
                case "queue":
                    SweepstakesQueueManager queueManager = new SweepstakesQueueManager();
                    return queueManager;    
                default:
                    GetSweepstakesManagement();
                    break;
            }
            SweepstakesStackManager stackManager1 = new SweepstakesStackManager();
            return stackManager1;
        }
            
}
}