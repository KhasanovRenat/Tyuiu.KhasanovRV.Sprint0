using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KhasanovRV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KhasanovRV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Ренат";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Ренат", res);
        }
    }
}
