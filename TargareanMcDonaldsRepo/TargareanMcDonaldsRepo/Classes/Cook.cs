using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargareanMcDonaldsRepo.Classes

  class Cook
    {
        // If you need ______ to make food, ______ is your parameter
        public string MakeFood(int menuItemNumber)
        {
            Menu menu = new Menu();
            KeyValuePair<int, string> menuItem = menu.MenuItems =[menuItemNumber];
            return $"Your {menuItem} is ready!";
        }
    }
