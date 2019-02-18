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
            GetInfo();
            //registrationnumber needs to be added.
            //GetRegistrationNumber();
        }
        //CAN DO
        public void GetInfo()
        {
            GetFirstName();
            GetLastName();
            GetEmail();
        }
        private string GetFirstName()
        {
            int result = UI.GetRandomNumber(0, 20);
            string[] array = new string[] {"Frank","Philip","Shawntella","Beatrice","Herbert", "Humphrey","Cherish","Samantha","Joe","Jacob","Pedro","Dawn","Casey","Dwayne","John","Thomas"};
            firstName=array[result];
            return firstName;
        }
        private string GetLastName()
        {
            int result = UI.GetRandomNumber(0, 20);
            string[] array = new string[] { "Smith", "Horwitz", "Doe", "Jones", "Dawson", "Carlton", "Jacobson", "Ferrell", "Latifah", "Davidson", "Quagmire", "Bustos", "Baird", "Spearstill", "Dace", "Sharpton" };
            lastName = array[result];
            return lastName;
        }
        private string GetEmail()
        {
            int result = UI.GetRandomNumber(0, 4);
            string[] array = new string[] { "google", "yahoo", "ask", "prodigy", "att" };
            string domain = array[result];
            emailAddress = (firstName + "." + lastName + "@" + domain + ".com");
            return emailAddress;
        }
        
    }
}