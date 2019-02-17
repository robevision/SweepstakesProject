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
        //CAN DO
        public void GiveFirstName()
        {
            //ask name
            Console.WriteLine("Please enter your first name.");
            firstName = Console.ReadLine();
            //set up try, catch for invalid entries. Maybe recall input. Does this look right?
            //Console.WriteLine($"Is {firstName} your first name?");
            //UI.PromptForYesOrNo();
            //string yesOrNo = Console.ReadLine().ToLower;
            //switch (yesOrNo)
            //{
            //    case "yes": fadfa;
            //}
           
               
            //receive name
            firstName =Console.ReadLine();
        }
        public void GiveLastName()
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