using NUnit.Framework;
using ProgrammingChallenges;
using ProgrammingChallenges.DSBinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingChallenges.Tests.DSBinaryTree
{
    public class BinaryTreeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(2)]
        [TestCase(0)]
        public void AddSingleValue(int value)
        {
            //arrange
            var binaryTree = new BinaryTree();

            //act
            binaryTree.Add(value);

            //assert
            Assert.AreEqual(binaryTree.root.Data, value);
        }

        [Test]
        public void AddMultipleValues()
        {
            //arrange
            var binaryTree = new BinaryTree();

            //act
            binaryTree.Add(5);
            binaryTree.Add(8);
            binaryTree.Add(6);

            //assert
            Assert.AreEqual(binaryTree.root.Data,5);
            Assert.AreEqual(binaryTree.root.RightNode.Data, 8);
            Assert.AreEqual(binaryTree.root.RightNode.LeftNode.Data, 6);
        }

        [Test]
        [TestCase(6,8)]
        [TestCase(3,5)]
        [TestCase(7,7)]
        [TestCase(5,5)]
        public void GetParentValue(int value, int expected)
        {
            //arrange
            var binaryTree = new BinaryTree();

            //act
            binaryTree.Add(5);
            binaryTree.Add(8);
            binaryTree.Add(6);
            binaryTree.Add(3);

            var result = binaryTree.GetParentValue(value);

            //assert
            Assert.AreEqual(result, expected);
        }



    }
}