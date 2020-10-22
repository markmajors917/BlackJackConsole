using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Classes
{
    class MenuDisplayCase
    {
        public MenuDisplayCase()
        {

        }
        public void DisplayMenu()
        {
            Menu menuToDisplay = new Menu();
            foreach (KeyValuePair<int, string> menuItem in menuToDisplay.MenuItems)
            {
                Console.WriteLine($"{menuItem.Key} - {menuItem.Value}");
            }
}
