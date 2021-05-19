using NUnit.Framework;

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

        [Test]
        [TestCase(2, true)]
        [TestCase(0, true)]
        [TestCase(-546512, true)]
        [TestCase(1, false)]
        [TestCase(5, false)]
        [TestCase(-11, false)]
        public void MathTests_IsPairNumber_Multiple(int value, bool testValue)
        {
            Assert.AreEqual(CustomMath.IsPairNumber(value), testValue);
        }
    }
}