using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Classes
{
    class Cashier
    {
        public void Greeting()
        {
            Console.WriteLine("Welcome to McDonald's!");
        }
        public int GetOrder(string input)
        {
            Console.WriteLine("What can I get you today?\n" +
                "Please type in the number for the item and press enter.");
            // From "1" to 1
            int userMenuItem = Convert.ToInt32(input);
            return userMenuItem;
        }
        public void SayThanksAndGoodbye()
        {
            Console.WriteLine("Thank you and have a great day!");
        }
}
