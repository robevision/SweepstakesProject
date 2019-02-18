using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sweepstakes_Project
{
    public class Sweepstakes
    {
        //HAS A
        Dictionary<int, Contestant> contestants;
        //SPAWNER
        //CAN DO
        public void GetSweepstakes(string name)
        {
            //choose type of sweepstakes
        }
        private void RegisterContestant(Contestant contestant)
        {
            contestants.Add(UI.GetRegistrationNumber(), contestant);

          
        }
        public string PickWinner()
        {
            throw new System.NotImplementedException();
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            //Console.WriteLine(contestants);

            foreach (KeyValuePair<int, Contestant> person in contestants)
            {
                if (person.Value == contestant)
                {
                    Console.WriteLine($"Contestant ID:{person.Key} First Name: {person.Value.firstName} Last Name: {person.Value.lastName} Email: {person.Value.emailAddress}");
                }
            }


            // do I create a new variable or research how to pass the Contestant object into the Dictionary
        }
      
        
    }
}