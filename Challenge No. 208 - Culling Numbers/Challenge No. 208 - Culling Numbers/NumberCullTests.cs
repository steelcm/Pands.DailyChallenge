using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_No._208___Culling_Numbers
{
    [TestFixture]
    public class NumberCullTests
    {

        [Test]
        public void GivenNull_ReturnArgumentException()
        {
            var numberCull = new NumberCull();
            Assert.Throws<ArgumentNullException>(() => numberCull.Run(null));
        }

        [Test]
        public void GivenStringContainingAlphabeticalChars_ReturnArgumenException()
        {
            var numberCull = new NumberCull();
            Assert.Throws<ArgumentException>(() => numberCull.Run("a"));
        }

        [Test]
        public void GivenStringContainingAllSpaces_ReturnArgumentException()
        {
            var numberCull = new NumberCull();
            Assert.Throws<ArgumentException>(() => numberCull.Run(" "));
        }

        [Test]
        public void GivenSingleNumber_ReturnThatNumber()
        {
            var numberCull = new NumberCull();
            var rVal = numberCull.Run("1");
            Assert.AreEqual(rVal, "1");
        }

        [Test]
        public void GivenTwoDigitNumber_ReturnThatNumber()
        {
            var numberCull = new NumberCull();
            var rVal = numberCull.Run("12");
            Assert.AreEqual(rVal, "12");
        }

        [Test]
        public void GivenTwoUniqueSingleDigitNumbers_ReturnThoseNumbers()
        {
            var numberCull = new NumberCull();
            var rVal = numberCull.Run("1 2");
            Assert.AreEqual(rVal, "1 2");
        }

        [Test]
        public void GivenTwoUniqueDoubleDigitNumbers_ReturnThoseNumbers()
        {
            var numberCull = new NumberCull();
            var rVal = numberCull.Run("12 34");
            Assert.AreEqual(rVal, "12 34");
        }

        [Test]
        public void GivenTwoSingleDigitNumbersTheSame_ReturnSingleNumbers()
        {
            var numberCull = new NumberCull();
            var rVal = numberCull.Run("1 1");
            Assert.AreEqual(rVal, "1");
        }

        [Test]
        public void GivenTwoDoubleDigitNumbersTheSame_ReturnSingleNumbers()
        {
            var numberCull = new NumberCull();
            var rVal = numberCull.Run("12 12");
            Assert.AreEqual(rVal, "12");
        }

        [Test]
        public void GivenExample1_ReturnResults1()
        {
            var numberCull = new NumberCull();
            var rVal = numberCull.Run("1 1 2 2 3 3 4 4");
            Assert.AreEqual(rVal, "1 2 3 4");
        }

        [Test]
        public void GivenExample2_ReturnResults2()
        {
            var numberCull = new NumberCull();
            var rVal = numberCull.Run("3 1 3 4 4 1 4 5 2 1 4 4 4 4 1 4 3 2 5 5 2 2 2 4 2 4 4 4 4 1");
            Assert.AreEqual(rVal, "3 1 3 4 1 4 5 2 1 4 1 4 3 2 5 2 4 2 4 1");
        }

        [Test]
        public void GivenExample3_ReturnResults3()
        {
            var numberCull = new NumberCull();
            var rVal = numberCull.Run("65 36 23 27 42 43 3 40 3 40 23 32 23 26 23 67 13 99 65 1 3 65 13 27 36 4 65 57 13 7 89 58 23 74 23 50 65 8 99 86 23 78 89 54 89 61 19 85 65 19 31 52 3 95 89 81 13 46 89 59 36 14 42 41 19 81 13 26 36 18 65 46 99 75 89 21 19 67 65 16 31 8 89 63 42 47 13 31 23 10 42 63 42 1 13 51 65 31 23 28");
            Assert.AreEqual(rVal, "65 36 23 27 42 43 3 40 3 40 23 32 23 26 23 67 13 99 65 1 3 65 13 27 36 4 65 57 13 7 89 58 23 74 23 50 65 8 99 86 23 78 89 54 89 61 19 85 65 19 31 52 3 95 89 81 13 46 89 59 36 14 42 41 19 81 13 26 36 18 65 46 99 75 89 21 19 67 65 16 31 8 89 63 42 47 13 31 23 10 42 63 42 1 13 51 65 31 23 28");
        }
    }
}
