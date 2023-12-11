using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BorodulinMS.Sprint0.TaskReview.V0.Lib;


namespace Tyuiu.BorodulinMS.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calc()
        {
            Assert.AreEqual(30, DataService.Calc(1, 2, 3));
        }
    }
}
