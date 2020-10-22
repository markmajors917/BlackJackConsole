using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds
{
    class Restaurant
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which menu item would you like:");
            var menuItems = new Dictionary<int, string>;
            {
                { 1, "Big Mac"},
                { 2, "McDouble"},
                { 3, "McRib"},
                { 4, "McNuggets"},
            };
            foreach (var item in menuItems) 
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("What would you like to order");
            string order = Console.ReadLine();
            int cutomerOrder = System.Convert.ToInt32(order);
            int returnOrder = orders;
            Console.WriteLine("You've ordered: " + menuItems{customerOrder});
            Console.ReadLine();
            }
        }
    }
}
