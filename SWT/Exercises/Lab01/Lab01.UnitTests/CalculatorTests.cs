using System;
using NUnit.Framework;
using Lab01;

namespace Lab01.UnitTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator c;

        [SetUp]
        public void SetUp()
        {
            c = new Calculator();
        }

        [TestCase(1, 2, 3)]
        [TestCase(5, 4, 9)]
        [TestCase(-5, 2, -3)]
        [TestCase(9, 10, 19)]
        public void Add_Tests_Success(double a, double b, double expected)
        {
            Assert.That(c.Add(a, b), Is.EqualTo(expected));
        }

        [TestCase(1, 2, -1)]
        [TestCase(5, 4, 1)]
        [TestCase(-5, -5, 0)]
        [TestCase(25, 10, 15)]
        public void Subtract_Tests_Success(double a, double b, double expected)
        {
            Assert.That(c.Subtract(a, b), Is.EqualTo(expected));
        }

        [TestCase(1, 2, 2)]
        [TestCase(5, 4, 20)]
        [TestCase(-5, -5, 25)]
        [TestCase(-25, 10, -250)]
        public void Multiply_Tests_Success(double a, double b, double expected)
        {
            Assert.That(c.Multiply(a, b), Is.EqualTo(expected));
        }

        [TestCase(1, 2, 1)]
        [TestCase(5, 5, 3125)]
        [TestCase(2, 3, 8)]
        [TestCase(2, 4, 16)]
        public void Power_Tests_Success(double a, double b, double expected)
        {
            Assert.That(c.Power(a, b), Is.EqualTo(expected));
        }

        [TestCase(2, 2, 1)]
        [TestCase(6,3,2)]
        [TestCase(10,5,2)]
        [TestCase(10,3,(3.3333333333333335d))]
        public void Test_divide_function(double a, double b, double expected)
        {
            Assert.That(c.Divide(a,b), Is.EqualTo(expected));
        }


        [Test]
        public void Accumulator_Add_1_2_Accumulator_Equals_3_Success()
        {
            c.Add(1, 2);
            Assert.That(c.Accumulator, Is.EqualTo(3));
        }



        [TearDown]
        public void TearDown()
        {
            c = null;
        }
    }
}
