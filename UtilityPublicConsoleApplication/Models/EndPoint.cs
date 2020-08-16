using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityPublicConsoleApplication.Enums;

namespace UtilityPublicConsoleApplication.Models
{
    class EndPoint
    {
        public EndPoint(string endPointSerialNumber, SwitchState switchState, MeterModelId meterModelId, int meterNumber, string meterFirmwareVersion)
        {
            EndPointSerialNumber = endPointSerialNumber;
            SwitchState = switchState;
            MeterModelid = meterModelId;
            MeterNumber = meterNumber;
            MeterFirmwareVersion = meterFirmwareVersion;
        }

        public String EndPointSerialNumber { get; set; }
        public SwitchState SwitchState { get; set; }
        public MeterModelId MeterModelid { get; set; }
        public int MeterNumber { get; set; }
        public String MeterFirmwareVersion { get; set; }

        public override string ToString()
        {
            return "| Serial Number: %" + EndPointSerialNumber + " | State: " + SwitchState.ToString() + " | Meter ID: " + MeterModelid + " | Meter Number: " + MeterNumber.ToString() + " | Meter Firmware Version: " + MeterFirmwareVersion;
        }
    }
}
