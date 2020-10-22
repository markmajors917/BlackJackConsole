using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Classes
{
    class Cook
    {
        // If you need _____ to make food, ____ is one of your parameters
        public string MakeFood(int menuItemNumber)
        {
            Menu menu = new Menu();
            string menuItem = menu.MenuItems[menuItemNumber];
            return $"Your {menuItem} is ready!";
        }
}
