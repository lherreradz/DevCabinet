using DataStructures.DSBinaryTree;
using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            #region BinaryTree
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Add(1);
            binaryTree.Add(2);
            binaryTree.Add(7);
            binaryTree.Add(3);
            binaryTree.Add(10);
            binaryTree.Add(5);
            binaryTree.Add(8);

            Node node = binaryTree.Find(5);
            int depth = binaryTree.GetTreeDepth();

            Console.WriteLine("PreOrder Traversal:");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("InOrder Traversal:");
            binaryTree.TraverseInOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("PostOrder Traversal:");
            binaryTree.TraversePostOrder(binaryTree.Root);
            Console.WriteLine();

            binaryTree.Remove(7);
            binaryTree.Remove(8);

            Console.WriteLine("PreOrder Traversal After Removing Operation:");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();

            Console.ReadLine();
            #endregion

            #region BinaryTree
            DS2BinaryTree.BinaryTree binaryTree2 = new DS2BinaryTree.BinaryTree(6);

            binaryTree2.Add(1);
            binaryTree2.Add(2);
            binaryTree2.Add(7);
            binaryTree2.Add(3);
            binaryTree2.Add(10);
            binaryTree2.Add(5);
            binaryTree2.Add(8);

            DS2BinaryTree.Node node2 = binaryTree2.Find(5);
            //int depth2 = binaryTree2.GetTreeDepth();

            //Console.WriteLine("PreOrder Traversal:");
            //binaryTree2.TraversePreOrder(binaryTree2.Root);
            //Console.WriteLine();

            //Console.WriteLine("InOrder Traversal:");
            //binaryTree2.TraverseInOrder(binaryTree2.Root);
            //Console.WriteLine();

            //Console.WriteLine("PostOrder Traversal:");
            //binaryTree2.TraversePostOrder(binaryTree2.Root);
            //Console.WriteLine();

            //binaryTree2.Remove(7);
            //binaryTree2.Remove(8);

            //Console.WriteLine("PreOrder Traversal After Removing Operation:");
            //binaryTree2.TraversePreOrder(binaryTree2.Root);
            Console.WriteLine();

            Console.ReadLine();
            #endregion

        }
    }
}
