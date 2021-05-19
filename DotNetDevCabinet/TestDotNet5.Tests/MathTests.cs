using NUnit.Framework;
using System;
using TestDotNet5;

namespace TestDotNet5.Tests
{
    public class MathTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SampleTest()
        {
            Assert.Pass();
        }

        [Test]
        public void MathTests_IsPairNumber()
        {
            Assert.IsTrue(CustomMath.IsPairNumber(2));
            Assert.IsTrue(CustomMath.IsPairNumber(10));
            Assert.IsTrue(CustomMath.IsPairNumber(0));
            Assert.IsTrue(!CustomMath.IsPairNumber(1));
            Assert.IsTrue(!CustomMath.IsPairNumber(5));
        }
    }
}