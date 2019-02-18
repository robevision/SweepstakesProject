using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sweepstakes_Project
{
    public class Contestant
    {
        //HAS A
        string firstName;
        string lastName;
        string emailAddress;
        int registrationNumber;
        //SPAWNER
        public Contestant()
        {
            firstName = null;
            lastName = null;
            emailAddress = null;
        }
        //CAN DO
        public void GetFirstName()
        {
           
        }
        public void GetLastName()
        {
            Console.WriteLine("Please enter your last name.");
            lastName = Console.ReadLine();
        }
        public void GetEmail()
        {
            Console.WriteLine("Please enter your email address.");
            emailAddress = Console.ReadLine();
        }
    }
}