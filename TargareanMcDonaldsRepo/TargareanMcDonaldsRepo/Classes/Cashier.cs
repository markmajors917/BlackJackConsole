
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargareanMcDonaldsRepo.Classes
{
    class Cashier
    {
        public void Greeting()
        {
            Console.WriteLine("Welcome to McDonald's!");
        }
        public int GetOrder()
        {
            Console.WriteLine("What can I get you today?\n" +
                "Please type in the number for the item and press enter.");
            string userInput = Console.ReadLine();
            int userMenuItem = Convert.ToInt32(userInput);
            return userMenuItem;
        }
        public void SayThanksAndGoodBye()
        {
            Console.WriteLine("Thank you and goodbye");
        }
}
