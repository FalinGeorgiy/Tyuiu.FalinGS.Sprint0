using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FalinGS.Sprint0.Task5.V0.Lib;

namespace Tyuiu.FalinGS.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        public void CheckedSubstractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }

        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(5, DataService.Multiplication(10, 5));
        }

        public void CheckedDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}
