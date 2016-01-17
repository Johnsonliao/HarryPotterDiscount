﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        public void BuyFirstBookTest()
        {
            var target = new HarryPotterDiscount();
            var quantity = 1;
            var price = 100;

            var expected = 100;

            var actual = target.BuyFirstBook(quantity, price);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BuyFirst_And_SecondBookTest()
        {
            var target = new HarryPotterDiscount();
            var quantity = 2;
            var price = 100;
            var discount = 95;

            var expected = 190;

            var actual = target.BuyBookDiscount(quantity, price, discount);

            Assert.AreEqual(expected, actual);
        }




    }
}