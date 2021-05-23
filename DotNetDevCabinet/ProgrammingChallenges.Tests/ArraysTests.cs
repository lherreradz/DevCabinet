using NUnit.Framework;
using ProgrammingChallenges;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingChallenges.Tests
{
    public class ArraysTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(4, "0 0 1 0 0 1 0")]
        public void jumpingOnCloudsTest(int expected, string listString)
        {
            //arrange
            List<int> c = listString.Split(' ').ToList().Select(cTemp => Convert.ToInt32(cTemp)).ToList();

            //act
            var result = Arrays.jumpingOnClouds(c);

            //assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        [TestCase(1000000, "a", 1000000)]
        [TestCase(7, "aba", 10)]
        [TestCase(1000000000000, "a", 1000000000000)]
        [TestCase(387755102043, "aaababbbjhabhbaaabhabhaabahbahbabbabhbahbabhaabahbaabahbahahbasahbahbababhabshbakbaahbajhbaskahahk", 1000000000000)]
        public void repeatedStringTest(long expected, string s, long n)
        {
            //arrange

            //act
            var result = Arrays.repeatedString(s, n);

            //assert
            Assert.AreEqual(result, expected);
        }
        
    }
}