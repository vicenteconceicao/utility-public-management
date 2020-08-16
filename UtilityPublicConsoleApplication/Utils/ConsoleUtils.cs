using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityPublicConsoleApplication.Utils
{
    class ConsoleUtils
    {
        public void ShowMenu()
        {
            Console.WriteLine("Select one of the numbers:");
            Console.WriteLine("1 - Insert a new endpoint");
            Console.WriteLine("2 - Edit an existing endpoint");
            Console.WriteLine("3 - Delete an existing endpoint");
            Console.WriteLine("4 - Lista all endpoints");
            Console.WriteLine("5 - Find a endpoint by Serial Number");
            Console.WriteLine("6 - Exit");
        }

        public void ShowTitle(String title)
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("    " + title);
            Console.WriteLine("-------------------------------------------------");
        }

        public void ShowSelectedOptionTitle(int option)
        {
            var optionText = "";
            Console.Clear();

            switch (option)
            {
                case 1:
                    optionText = "1 - Insert a new endpoint";
                    break;
                case 2:
                    optionText = "2 - Edit an existing endpoint";
                    break;
                case 3:
                    optionText = "3 - Delete an existing endpoint";
                    break;
                case 4:
                    optionText = "4 - List all endpoint";
                    break;
                case 5:
                    optionText = "5 - Find a endpoint by Serial Number";
                    break;
                default:
                    optionText = "Not a valid option, try again.";
                    break;
            }

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(" -> " + optionText);
            Console.WriteLine("-------------------------------------------------");
        }
    }
}
