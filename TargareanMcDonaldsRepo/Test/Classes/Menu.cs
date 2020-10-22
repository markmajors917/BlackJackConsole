using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Classes
{
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
        public Dictionary<int, string> MenuItems;
    }
}
