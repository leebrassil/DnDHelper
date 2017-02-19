using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DnDHelper.Models;

namespace DnDHelperTest
{
    [TestClass]
    public class ModifierCalculationTests
    {
        [TestMethod]
        public void Test10Stat()
        {
            var modifier = BaseStats.GetModifier(10);
            Assert.Equals(modifier, 0);
        }

        [TestMethod]
        public void Test11Stat()
        {
            var modifier = BaseStats.GetModifier(11);
            Assert.Equals(modifier, 0);
        }

        [TestMethod]
        public void TestPositiveStat()
        {
            var modifier = BaseStats.GetModifier(17);
            Assert.Equals(modifier, 3);
        }

        [TestMethod]
        public void TestNegativeStat()
        {
            var modifier = BaseStats.GetModifier(8);
            Assert.Equals(modifier, -1);
        }
    }
}
