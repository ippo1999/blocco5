using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Esercizio01;

namespace UnitTestBlocco05
{
    [TestClass]
    public class UnitTest01
    {
        [TestMethod]
        public void Test01()
        {
            TaxableHouse houseTax = new TaxableHouse("Acitrulla", false, 100.0, 150000.0M);
            Assert.AreEqual("Acitrulla", houseTax.Location);
            Assert.AreEqual(100.0, houseTax.Area);
            Assert.AreEqual(450.0M, houseTax.TaxValue());
        }
        [TestMethod]
        public void Test02()
        {
            TaxableHouse houseTax = new TaxableHouse("Miami", true, 400.0, 100000.0M);
            Assert.AreEqual("Miami", houseTax.Location);
            Assert.AreEqual(400.0, houseTax.Area);
            Assert.AreEqual(4500.0M, houseTax.TaxValue());
        }

        [TestMethod]
        public void Test03()
        {
            TaxableHouse houseTax = new TaxableHouse("Catania", true, 200.0, 35000.0M);
            Assert.AreEqual("Catania", houseTax.Location);
            Assert.AreEqual(200.0, houseTax.Area);
            Assert.AreEqual(1175.0M, houseTax.TaxValue());
        }

        [TestMethod]
        public void Test04()
        {
            TaxableBus busTax = new TaxableBus(25, 156134843, 20000.0M);
            Assert.AreEqual(25, busTax.NumberOfSeats);
            Assert.AreEqual(156134843, busTax.RegistrationNumber);
            Assert.AreEqual(1250.0M, busTax.TaxValue());
        }
        [TestMethod]
        public void Test05()
        {
            TaxableBus busTax = new TaxableBus(50,11516812, 20000.0M);
            Assert.AreEqual(50, busTax.NumberOfSeats);
            Assert.AreEqual(11516812, busTax.RegistrationNumber);
            Assert.AreEqual(2000.0M, busTax.TaxValue());
        }
    }
}

