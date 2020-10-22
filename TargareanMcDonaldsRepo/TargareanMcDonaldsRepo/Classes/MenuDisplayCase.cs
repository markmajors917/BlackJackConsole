
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargareanMcDonaldsRepo.Classes
{
    class MenuDisplayCase
    {
        public void DisplayMenu()
        {
            Menu menuToDisplay = new Menu();
            foreach (KeyValuePair<int, string> menuItem in menuToDisplay.MenuItems)
            {
                Console.WriteLine($"{menuItem.Key} -- { menuItem.Value}");
            }
            for (int i = 0; i < menuToDisplay.MenuItems.Count; i++)
            {
                Console.WriteLine(menuToDisplay);
            }
        }
    }
}
