using NUnit.Framework;
using ProgrammingChallenges;
using ProgrammingChallenges.DSBinaryTree;
using ProgrammingChallenges.DSBinaryTree.TreeConstructorProblem;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingChallenges.Tests.DSBinaryTree.BinaryTreeConstructorProblem
{
    public class BinaryTreeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(new string[] { "(1,2)", "(2,4)", "(5,7)", "(7,2)", "(9,5)" }, "true")]
        [TestCase(new string[] { "(1,2)", "(3,2)", "(2,12)", "(5,2)" }, "false")]
        public void TreeConstructorTest(string[] strArr, string expected)
        {
            //act
            var result = TreeConstructorProblem.TreeConstructor(strArr);

            //assert
            Assert.AreEqual(result, expected);
        }


    }
}