using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityPublicConsoleApplication.Inputs
{
    class ConsoleInputs
    {
        public int exit()
        {
            var input = Console.ReadLine();
            input = input.ToUpper();
            while (!(input.Equals("Y") || input.Equals("N")))
            {
                Console.WriteLine("Not a valid Option, try again.");
                input = Console.ReadLine();
            }
            return input.Equals("Y") ? 6 : 0;
        }

        public int optionMenu()
        {
            int option;
            var input = Console.ReadLine();
            while (!Int32.TryParse(input, out option))
            {
                Console.WriteLine("Not a valid number, try again.");
                input = Console.ReadLine();
            }
            return option;
        }

        public void PressToBack()
        {
            Console.WriteLine("Press enter to back.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
