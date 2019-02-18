using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sweepstakes_Project
{
    public class ContestantFactory
    {
        public Contestant GetContestant()
        {
            Contestant contestant = new Contestant();
            return contestant;
        }
    }
}