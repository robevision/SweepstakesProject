using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sweepstakes_Project
{
    public interface ISweepstakesManager
    {
        //CAN DO

       void InsertSweepstakes(Sweepstakes sweepstakes);
       Sweepstakes GetSweepstakes();
    }
}