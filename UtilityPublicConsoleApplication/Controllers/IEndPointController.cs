using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityPublicConsoleApplication.Enums;
using UtilityPublicConsoleApplication.Models;

namespace UtilityPublicConsoleApplication.Controllers
{
    interface IEndPointController
    {
         String Create(String serialNumber, SwitchState switchState, MeterModelId meterId, int meterNumber, string meterFirmwareVersion);
         String Update(String serialNumber, SwitchState switchState);
         String Delete(String serialNumber);
         String GetBySerialNumber(String serialNumber);
         void GetAll();
         bool ExistEndPoint(String serialNumber);
    }
}
