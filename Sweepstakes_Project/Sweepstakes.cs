﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sweepstakes_Project
{
    public class Sweepstakes
    {
        //HAS A
        //SPAWNER
        //CAN DO
        public void GetSweepstakes(string name)
        {
            //choose type of sweepstakes
        }
        public void RegisterContestant(Contestant contestant)
        {
            Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
            contestants.Add(40, contestant);

            //check factory pattern
        }
        public string PickWinner()
        {
            throw new System.NotImplementedException();
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            //contestants needs to be a group or list of Contestant class
            Dictionary<int, string> sweepstake = new Dictionary<int, string>();
            //When I added contestant to Dictionary, 
            //it stated that contestant can't be used since it was brought in as a parameter. 
            //I used this.contestant and it then had an issue with instantiating Dictionary. Why did this not work?
            //foreach(KeyValuePair<int, string> value in contestant)
            //{
            //    //if ( == contestant)
            //    //{
            //    //    Console.WriteLine($"Contestant ID:{contestant.Key} First Name: {contestant.firstName} Last Name: {contestant.lastName}";
            //    //}
            //}


            // do I create a new variable or research how to pass the Contestant object into the Dictionary
        }
      
        
    }
}