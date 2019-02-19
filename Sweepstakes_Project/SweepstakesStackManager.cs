using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sweepstakes_Project
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        //HAS A
        Sweepstakes sweepstakes;
        //SPAWNER
        //CAN DO
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            Stack<int> myStack = new Stack<int>();

            myStack.Push(5);
            myStack.Push(21);
            myStack.Push(9);

            Console.WriteLine("Elements in stack: ");
            foreach (int number in myStack)
            {
                Console.WriteLine(number);
            }

            int topOfStack = myStack.Pop();

            myStack.Push(3);

            Console.WriteLine("Elements in stack after Pop and Push(3): ");
            foreach (int number in myStack)
            {
                Console.WriteLine(number);
            }
        }
        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakes = new Sweepstakes();
            return sweepstakes;
        }
    }
}