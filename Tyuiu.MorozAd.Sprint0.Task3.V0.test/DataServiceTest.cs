﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MorozAd.Sprint0.Task3.V0.lib;
namespace Tyuiu.MorozAd.Sprint0.Task3.V0.test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}
