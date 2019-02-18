using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            SweepstakesManagerFactory factory = new SweepstakesManagerFactory();
            factory.GetSweepstakesManagement();
            MarketingFirm marketingFirm = new MarketingFirm();

        }
    }
}
