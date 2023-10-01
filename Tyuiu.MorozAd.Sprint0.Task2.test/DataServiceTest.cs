using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MorozAd.Sprint0.Task2.V0.lib;

namespace Tyuiu.MorozAd.Sprint0.Task2.test
{

    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMEssageValid()
        {
            var name = "Артём";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет,Артём", res);
        }
    }
}
