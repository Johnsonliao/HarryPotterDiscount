using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleLibrary.Tests
{
    [TestClass()]
    public class HarryPotterDiscountTests
    {
        [TestMethod()]
        public void GetBuyFirstBookTest()
        {
            var target = new HarryPotterDiscount();

            var expected = 100;

            var actual = target.BuyFirstBook();

            Assert.AreEqual(expected, actual);
        }

    }
}