using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sweepstakes_Project
{
    public static class UI
    {
        //HAS A
        //CAN DO
        private static readonly Random getRandom = new Random();

        public static int GetRandomNumber(int min, int max)
        {
            lock (getRandom) 
            {
                return getRandom.Next(min, max);
            }
        }
        public static void PromptForYesOrNo()
        {
            Console.WriteLine("Type yes or no.");
        }
    public static void GetInfo(Contestant contestant)
        {
            //ask name
            Console.WriteLine("Please enter your first name.");
            //How do I make the GetInfo() method be in the UI without moving variables over.
            //Contestant.firstName = Console.ReadLine();
            //set up try, catch for invalid entries. Maybe recall input. Does this look right?
            //Console.WriteLine($"Is {firstName} your first name?");
            //UI.PromptForYesOrNo();
            //string yesOrNo = Console.ReadLine().ToLower;
            //switch (yesOrNo)
            //{
            //    case "yes": fadfa;
            //}


            //receive name
            //firstName = Console.ReadLine();
        }
         public static string ChooseManagementSystem()
        {
            Console.WriteLine("Which sweepstakes management would you like to use? Type STACK or QUEUE: ");
            string managementChoice = Console.ReadLine().ToLower();
            switch (managementChoice)
            {
                case "stack":
                    managementChoice = "stack";
                    break;
                case "queue":
                    managementChoice = "queue";
                    break;
                case "s":
                    managementChoice = "stack";
                    break;
                case "q":
                    managementChoice = "queue";
                    break;
                default:
                    Console.WriteLine("Please type a valid response.");
                    ChooseManagementSystem();
                    break;
            }
            return managementChoice;
        }   
    }
}