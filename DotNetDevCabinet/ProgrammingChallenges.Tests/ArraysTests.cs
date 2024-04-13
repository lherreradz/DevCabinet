using NUnit.Framework;
using ProgrammingChallenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;

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

        [Test]
        [TestCase("abc", "cba")]
        public void FirstReverseTest(string str, string expected)
        {
            //arrange

            //act
            var result = Arrays.FirstReverse(str);

            //assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        [TestCase(new string[] { "1, 3, 4, 7, 13", "1, 2, 4, 13, 15"}, "1,4,13")]
        public void FindIntersectionTest(string[] str, string expected)
        {
            //arrange

            //act
            var result = Arrays.FindIntersection(str);

            //assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase("4886532165321", 4)]
        [TestCase("1241221", 4)]
        public void lonelyinteger(string numbers, int expected)
        {
            //arrange

            List<int> list = new List<int>();
            foreach (var n in numbers.ToArray()) list.Add(Convert.ToInt32(n.ToString()));

            //act
            var result = Arrays.lonelyinteger(list);

            //assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        [TestCase("523456789", 3, 4)]
        [TestCase("123456789", 3, 0)]
        public void DiagonalDifference(string numberString, int size, int expected)
        {
            List<List<int>> list = new List<List<int>>();
            //arrange
            for(int i=0; i<size; i++)
            {
                List<int> line = new List<int>();
                for(int j = 0; j<size; j++)
                {
                    line.Add(Convert.ToInt32(numberString[j+(i*3)].ToString()));
                }
                list.Add(line);
            }

            //act
            var result = Arrays.DiagonalDifference(list);

            //assert
            Assert.AreEqual(expected, result);
        }


        [Test]
        [TestCase(new string[3] { "abc", "bca", "dbe"}, new int[3] { 0, 2, 1 })]
        [TestCase(new string[3] { "gr", "sd", "rg" }, new int[0])]
        public void solutionChar(string[] S, int[] expected)
        {
            //arrange

            //act
            var result = Arrays.solutionChar(S);

            //assert
            Assert.AreEqual(expected, result);
        }


        [Test]
        [TestCase(new int[3] {3,3,3}, 0)]
        public void IncreaseDecrease(int[] A , int expected)
        {
            //arrange

            //act
            var result = Arrays.IncreaseDecrease(A);

            //assert
            Assert.AreEqual(expected, result);
        }


        [Test]
        //[TestCase(new int[10] { 20, 15, 3, 4, 8, 6, 2, 0, 4, 1 }, new int[3] { 10, 3, 60 }, new int[9] { 20, 15, 4, 8, 6, 2, 0, 4, 1 })]
        [TestCase(new int[10] { 1, 15, 500000, 3, 8, 6, 2, 0, 4, 1 }, new int[3] { 10, 3, 5500000 }, new int[9] { 1, 15, 500000, 8, 6, 2, 0, 4, 1 })]
        public void SetDifferenceArray(int[] A, int[] B, int[] expected)
        {
            var startTime = DateTime.Now;
            //arrange

            //act
            var result = Arrays.SetDifferenceArray2(A, B);

            var EndTime = DateTime.Now;

            //assert
            Assert.AreEqual(expected, result);

            Console.Write("tiempo: ");
            Console.WriteLine(EndTime - startTime);
        }




    }
}