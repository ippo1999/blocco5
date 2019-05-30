using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Esercizio02;

namespace UnitTestBlocco05
{
    [TestClass]
    public class UnitTest02
    {
        [TestMethod]
        public void Test01()
        {
            Die[] dice = new Die[]{new Die(), new Die(), new Die(), new Die(),
                           new Die(), new Die(), new Die(), new Die(),
                          };

            Array.Sort(dice);
            Die prev = dice[0];
            foreach (Die d in dice)
            {
                if (d != prev)
                    Assert.IsTrue(prev.Number() <= d.Number());
                prev = d;
            }
        }
        [TestMethod]
        public void Test02()
        {

            Die d = new Die();
            bool twoSixesDetector = false;
            int numOfTwoSixes = 0;

            d.twoSixesInARow +=
             delegate () {
                 twoSixesDetector = true;
             };
            d.twoSixesInARow +=
             delegate () {
                 numOfTwoSixes++;
             };
            for (int i = 1; i < 1000; i++)
            {
                d.Toss();
            }

            Assert.IsTrue(twoSixesDetector);
            Assert.IsTrue(numOfTwoSixes != 0);
        }
        [TestMethod]
        public void Test03()
        {

            Die d = new Die();
            bool fullHouseDetector = false;

            d.fullHouse +=
             delegate () {
                 fullHouseDetector = true;
             };
            for (int i = 1; i < 1000; i++)
            {
                d.Toss();
            }

            Assert.IsTrue(fullHouseDetector);
        }
    }
}

