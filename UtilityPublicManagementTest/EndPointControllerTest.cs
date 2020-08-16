using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityPublicConsoleApplication.Controllers;
using UtilityPublicConsoleApplication.Enums;

namespace UtilityPublicManagementTest
{
    [TestClass]
    public class EndPointControllerTest
    {
        [TestMethod]
        public void CreateSerialNumberNotExist()
        {
            EndPointController controller = new EndPointController();

            String result = controller.Create("KLM14B", SwitchState.Disconnected, MeterModelId.NSX1P3W, 1, "1.0.1");

            Assert.AreEqual("EndPoint has been added.", result);
        }

        [TestMethod]
        public void CreateSerialNumberAlreadyExist()
        {
            EndPointController controller = new EndPointController();

            String result = controller.Create("KLM14A", SwitchState.Connected, MeterModelId.NSX1P2W, 1, "1.0.1");

            Assert.AreEqual("Serial Number already exist. Please, try again.", result);
        }

        [TestMethod]
        public void UpdateSerialNumberExist()
        {
            EndPointController controller = new EndPointController();

            String result = controller.Update("KLM14A", SwitchState.Armed);

            Assert.AreEqual("EndPoint has been updated.", result);
        }

        [TestMethod]
        public void UpdateSerialNumberNotExist()
        {
            EndPointController controller = new EndPointController();

            String result = controller.Update("KLM1CB", SwitchState.Armed);

            Assert.AreEqual("Serial Number dos not exist. Please, try again.", result);
        }

        [TestMethod]
        public void DeleteSerialNumberExist()
        {
            EndPointController controller = new EndPointController();

            String result = controller.Delete("KLM14A");

            Assert.AreEqual("EndPoint has been deleted.", result);
        }

        [TestMethod]
        public void DeleteSerialNumberNotExist()
        {
            EndPointController controller = new EndPointController();

            String result = controller.Delete("KLM1CB");

            Assert.AreEqual("Serial Number dos not exist. Please, try again.", result);
        }
    }
}
