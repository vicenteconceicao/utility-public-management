using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityPublicConsoleApplication.Enums;

namespace UtilityPublicConsoleApplication.Inputs
{
    class EndPointInputs
    {
        public String SerialNumber()
        {
            Console.WriteLine("Serial Number:");
            var input = Console.ReadLine();
            while (input.Length < 0)
            {
                Console.WriteLine("Not a valid Serial Number, try again.");
                input = Console.ReadLine();
            }
            return input;
        }

        public SwitchState SwitchState()
        {
            int option;
            Console.WriteLine("Switch State: 0 - Disconnected | 1 - Connected | 2 - Armed");
            var input = Console.ReadLine();
            while (!Int32.TryParse(input, out option) || option > 2 || option < 0)
            {
                Console.WriteLine("Not a valid Switch State, try again.");
                input = Console.ReadLine();
            }
            return (SwitchState)option;
        }

        public MeterModelId ModelId()
        {
            int option;
            Console.WriteLine("Meter Model Id: 16 - NSX1P2W | 17 - NSX1P3W | 18 - NSX2P3W | 19 - NSX3P4W");
            var input = Console.ReadLine();
            while (!Int32.TryParse(input, out option) || option > 19 || option < 16)
            {
                Console.WriteLine("Not a valid Meter Model Id, try again.");
                input = Console.ReadLine();
            }
            return (MeterModelId)option;
        }

        public int MeterNumber()
        {
            int option;
            Console.WriteLine("Meter Number:");
            var input = Console.ReadLine();
            while (!Int32.TryParse(input, out option))
            {
                Console.WriteLine("Not a valid Meter Number, try again.");
                input = Console.ReadLine();
            }
            return option;
        }

        public String MeterFirmwareVersion()
        {
            Console.WriteLine("Meter Firmware Version:");
            var input = Console.ReadLine();
            while (input.Length < 0)
            {
                Console.WriteLine("Not a valid Meter Firmware Version, try again.");
                input = Console.ReadLine();
            }
            return input;
        }
    }
}