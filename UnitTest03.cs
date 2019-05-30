using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Esercizio03;

namespace UnitTestBlocco05
{
    [TestClass]
    public class UnitTest03
    {
        [TestMethod]
        public void Test01()
        {
            TriBool x = TriBool.isFalse;
            Assert.AreEqual(false, x);
        }
        [TestMethod]
        public void Test02()
        {
            TriBool x, y;
            x = TriBool.isFalse;
            y = TriBool.indeterminate;

            Assert.AreEqual(TriBool.isTrue, !x);
            Assert.AreEqual(TriBool.indeterminate, !y);
            Assert.AreEqual(TriBool.isFalse, x & y);
            Assert.AreEqual(TriBool.indeterminate, x | y);
        }
        [TestMethod]
        public void Test03()
        {
            Assert.AreEqual(TriBool.indeterminate, TriBool.isTrue & TriBool.indeterminate);
            Assert.AreEqual(TriBool.isFalse, TriBool.isFalse & TriBool.isTrue);
            Assert.AreEqual(TriBool.isFalse, TriBool.indeterminate & TriBool.isFalse);
            Assert.AreEqual(TriBool.indeterminate, TriBool.indeterminate | TriBool.isFalse);
            Assert.AreEqual(TriBool.indeterminate, TriBool.indeterminate & TriBool.isTrue);
            Assert.AreEqual(TriBool.isFalse, !TriBool.isTrue & TriBool.indeterminate);
            Assert.AreEqual(TriBool.isTrue, TriBool.isTrue | !TriBool.indeterminate);
            Assert.AreEqual(TriBool.isFalse, !TriBool.isTrue & TriBool.isTrue);
        }
    }
}
