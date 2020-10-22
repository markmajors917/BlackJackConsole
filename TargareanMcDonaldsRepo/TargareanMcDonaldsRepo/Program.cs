using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargareanMcDonaldsRepo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make the menu (get the menu)
            Menu ourMenu -new Menu();
            // Display the menu
            MenuDisplayCase displayCase = new MenuDisplayCase();
            displayCase.DisplayMenu();
            // Wecome user, Ask for the order
            Cashier cashier = new Cashier();
            cashier.Greeting();
            // Translate user input to the menu item
            int userOrderItem = cashier.GetOrder();
            // Cook menu item
            string cookedFoodMessage = cook.MakeFood(userOrderItem);
            // Return cooked food
            cashier.SayThanksAndGoodbeye();
            Console.ReadLine();
        }
    }
    


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
        public void  SayThanksAndGoodBye()
        {
            Console.WriteLine("Thank you and goodbye");
        }
        


    }
    class MenuDisplayCase
    {
        public void DisplayMenu()
        {
            Menu menuToDisplay = new Menu();
            foreach (KeyValuePair<int,string> menuItem in menuToDisplay.MenuItems)
            {
                Console.WriteLine($"{menuItem.Key} -- { menuItem.Value}");
            }
            for (int i = 0; i < menuToDisplay.MenuItems.Count; i++)
            {
                Console.WriteLine(menuToDisplay);
            }
        }
    }
    class Menu
    {
        public Menu()
        {
            MenuItems = new Dictionary<int, string>()
            {
                {1, "Big Mac" },
                {2, "McDouble" },
                {3, "SEG McGriddle" },
                {4, "Chicken Nuggets" },
                {5, "Cookies" },
                {6, "Apple Pie" },
                {7, "Bagel" },
                {8, "Pancakes" }
            };
        }
        public Dictionary<int, string> MenuItems { get; set }
    }
}
