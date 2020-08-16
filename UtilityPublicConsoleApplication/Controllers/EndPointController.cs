using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityPublicConsoleApplication.Enums;
using UtilityPublicConsoleApplication.Models;

namespace UtilityPublicConsoleApplication.Controllers
{
    public class EndPointController : IEndPointController
    {
        private IList<EndPoint> endPoints { get; set; }

        public EndPointController()
        {
            endPoints = new List<EndPoint>(){
                new EndPoint("KLM14A", SwitchState.Connected, MeterModelId.NSX1P2W, 1, "1.0.1"),
                new EndPoint("KLN17A", SwitchState.Connected, MeterModelId.NSX1P2W, 2, "1.0.2"),
                new EndPoint("KJM12A", SwitchState.Connected, MeterModelId.NSX1P3W, 3, "1.0.2"),
                new EndPoint("KKM64A", SwitchState.Armed, MeterModelId.NSX2P3W, 4, "1.0.2"),
                new EndPoint("KBM38A", SwitchState.Armed, MeterModelId.NSX3P4W, 1, "1.0.1"),
                new EndPoint("KNM84A", SwitchState.Disconnected, MeterModelId.NSX3P4W, 1, "1.0.1"),
            };
        }

        public String Create(String serialNumber, SwitchState switchState, MeterModelId meterId, int meterNumber, string meterFirmwareVersion)
        {
            var endPointExist = endPoints
                                .Where(ep => ep.EndPointSerialNumber == serialNumber);
            if (endPointExist.Count() == 0)
            {
                EndPoint endPoint = new EndPoint(serialNumber, switchState, meterId, meterNumber, meterFirmwareVersion);
                endPoints.Add(endPoint);
                return "EndPoint has been added.";
            }
            else
            {
                return "Serial Number already exist. Please, try again.";
            }
        }

        public String Update(String serialNumber, SwitchState switchState)
        {
            var endPointExist = endPoints
                                .Where(ep => ep.EndPointSerialNumber == serialNumber)
                                .Select(ep => ep.SwitchState = switchState);

            if (endPointExist.Count() == 0)
            {
                return "Serial Number dos not exist. Please, try again.";
            }
            else
            {
                return "EndPoint has been updated.";
            }
        }

        public String Delete(String serialNumber)
        {
            var endPointExist = endPoints
                                .Where(ep => ep.EndPointSerialNumber == serialNumber)
                                .FirstOrDefault();

            if (endPointExist == null)
            {
                return "Serial Number dos not exist. Please, try again.";
            }
            else
            {
                endPoints.Remove(endPointExist);
                return "EndPoint has been deleted.";
            }
        }

        public String GetBySerialNumber(String serialNumber)
        {
            var endPointExist = endPoints
                                .Where(ep => ep.EndPointSerialNumber == serialNumber)
                                .FirstOrDefault();

            if (endPointExist == null)
            {
                return "Serial Number dos not exist. Please, try again.";
            }
            else
            {
                return endPointExist.ToString();
            }
        }

        public void GetAll() => ConsoleTable.From(endPoints).Write();

        public bool ExistEndPoint(String serialNumber)
        {
            var endPointExist = endPoints
                                .Where(ep => ep.EndPointSerialNumber == serialNumber)
                                .FirstOrDefault();
            return endPointExist != null;
        }
    }
}
