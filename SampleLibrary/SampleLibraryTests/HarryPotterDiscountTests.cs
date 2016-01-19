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
        public void BuyFirstBookTest()
        {
            var bookList = new List<Book>
            {
                new Book { BookID = 1, Price = 100 }
            };
            var expected = 100;

            var target = new HarryPotterDiscount(bookList);

            var actual = target.BuyBookDiscountMixing();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BuyFirst_And_SecondBookTest()
        {
            var bookList = new List<Book>
            {
                new Book { BookID = 1, Price = 100 },
                new Book { BookID = 2, Price = 100 }
            };

            var expected = 190;

            var target = new HarryPotterDiscount(bookList);

            var actual = target.BuyBookDiscountMixing();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BuyFirst_And_Second_And_third_BookTest()
        {
            var bookList = new List<Book>
            {
                new Book { BookID = 1, Price = 100 },
                new Book { BookID = 2, Price = 100 },
                new Book { BookID = 3, Price = 100 }
            };

            var expected = 270;

            var target = new HarryPotterDiscount(bookList);

            var actual = target.BuyBookDiscountMixing();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BuyFirst_And_Second_And_third_fourth_BookTest()
        {
            var bookList = new List<Book>
            {
                new Book { BookID = 1, Price = 100 },
                new Book { BookID = 2, Price = 100 },
                new Book { BookID = 3, Price = 100 },
                new Book { BookID = 4, Price = 100 }
            };

            var expected = 320;

            var target = new HarryPotterDiscount(bookList);

            var actual = target.BuyBookDiscountMixing();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BuyAllHarryBookTest()
        {
            var bookList = new List<Book>
            {
                new Book { BookID = 1, Price = 100 },
                new Book { BookID = 2, Price = 100 },
                new Book { BookID = 3, Price = 100 },
                new Book { BookID = 4, Price = 100 },
                new Book { BookID = 5, Price = 100 }
            };

            var expected = 375;

            var target = new HarryPotterDiscount(bookList);

            var actual = target.BuyBookDiscountMixing();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BuyRepeatHarryBookTest()
        {
            var bookList = new List<Book>
            {
                new Book { BookID = 1, Price = 100 },
                new Book { BookID = 2, Price = 100 },
                new Book { BookID = 3, Price = 100 },
                new Book { BookID = 3, Price = 100 }
            };

            var expected = 370;

            var target = new HarryPotterDiscount(bookList);

            var actual = target.BuyBookDiscountMixing();

            Assert.AreEqual(expected, actual);
        }


    }
}