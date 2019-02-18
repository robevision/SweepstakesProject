using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sweepstakes_Project
{
    public class SweepstakesManagerFactory
    {
        public void GetSweepstakesManagement()
        {
            switch (UI.ChooseManagementSystem())
            {
                case "stack":
                    SweepstakesStackManager stackManager = new SweepstakesStackManager();
                    break;
                case "queue":
                    SweepstakesQueueManager queueManager = new SweepstakesQueueManager();
                    break;
                default:
                    break;
            }
        }
            
}
}