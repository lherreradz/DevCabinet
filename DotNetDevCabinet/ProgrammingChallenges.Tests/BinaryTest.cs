using NUnit.Framework;

namespace ProgrammingChallenges.Tests
{
    public class BinaryTest
    {
        [SetUp]
        public void setup() { }
        
        [Test]
        [TestCase(4,"100")]
        [TestCase(1, "1")]
        [TestCase(2, "10")]
        [TestCase(0, "0")]
        [TestCase(8, "1000")]
        [TestCase(9, "1001")]
        public void convertToBinary(int n, string binary)
        {
            //arrange

            //act
            var result = Binary.ConvertToBinary(n);

            //assert
            Assert.AreEqual(result, binary);
        }

    }
}
