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

            //add and take out functionality is needed
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            Queue<int> myQueue = new Queue<int>();
            {
            myQueue.Enqueue(1);
            myQueue.Enqueue(5);
            myQueue.Enqueue(2);
            Console.WriteLine("Elements in queue: ");
            foreach (int number in myQueue)
            {
                Console.WriteLine(sweepstakes);
            }
            int startOfQueue = myQueue.Dequeue();
            myQueue.Enqueue(4);

            Console.WriteLine("Elements in queue after Dequeue and Enqueue(5): ");
            foreach (int number in myQueue)
            {
                Console.WriteLine(number);
            }
        }
            
           
        }
        public Sweepstakes GetSweepstakes()
        {
            //Sweepstakes sweepstakes = new Sweepstakes();
            return sweepstakes;
        }
    }
}