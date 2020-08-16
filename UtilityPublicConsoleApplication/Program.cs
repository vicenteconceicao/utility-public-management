using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityPublicConsoleApplication.Controllers;
using UtilityPublicConsoleApplication.Enums;
using UtilityPublicConsoleApplication.Inputs;
using UtilityPublicConsoleApplication.Models;
using UtilityPublicConsoleApplication.Utils;

namespace UtilityPublicConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            EndPointInputs endPointInputs = new EndPointInputs();
            ConsoleInputs consoleInputs = new ConsoleInputs();

            ConsoleUtils console = new ConsoleUtils();

            EndPointController controller = new EndPointController();

            int option = 0;

            while (option != 6)
            {
                console.ShowTitle("Utility Public Management Application");

                console.ShowMenu();

                option = consoleInputs.optionMenu();

                String serialNumber;
                SwitchState switchState;
                MeterModelId meterId;
                int meterNumber;
                String meterFirmwareVersion;

                switch (option)
                {
                    case 1:
                        console.ShowSelectedOptionTitle(option);
                        serialNumber = endPointInputs.SerialNumber();
                        bool exit = controller.ExistEndPoint(serialNumber);
                        if (exit)
                        {
                            Console.WriteLine("Serial Number already exist. Please, try again.");
                        }
                        else
                        {
                            switchState = endPointInputs.SwitchState();
                            meterId = endPointInputs.ModelId();
                            meterNumber = endPointInputs.MeterNumber();
                            meterFirmwareVersion = endPointInputs.MeterFirmwareVersion();
                            Console.WriteLine(controller.Create(serialNumber, switchState, meterId, meterNumber, meterFirmwareVersion));
                        }
                        consoleInputs.PressToBack();
                        break;
                    case 2:
                        console.ShowSelectedOptionTitle(option);
                        serialNumber = endPointInputs.SerialNumber();
                        switchState = endPointInputs.SwitchState();
                        Console.WriteLine(controller.Update(serialNumber, switchState));
                        consoleInputs.PressToBack();
                        break;
                    case 3:
                        console.ShowSelectedOptionTitle(option);
                        serialNumber = endPointInputs.SerialNumber();
                        Console.WriteLine(controller.Delete(serialNumber));
                        consoleInputs.PressToBack();
                        break;
                    case 4:
                        console.ShowSelectedOptionTitle(option);
                        controller.GetAll();
                        consoleInputs.PressToBack();
                        break;
                    case 5:
                        console.ShowSelectedOptionTitle(option);
                        serialNumber = endPointInputs.SerialNumber();
                        Console.WriteLine(controller.GetBySerialNumber(serialNumber));
                        consoleInputs.PressToBack();
                        break;
                    case 6:
                        Console.WriteLine("Do you really want to leave? Y/N");
                        option = consoleInputs.exit();
                        break;
                    default:
                        console.ShowSelectedOptionTitle(option);
                        consoleInputs.PressToBack();
                        break;
                }
            }
        }
    }
}
