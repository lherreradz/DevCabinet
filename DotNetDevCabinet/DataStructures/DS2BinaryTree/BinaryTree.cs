using DataStructures.DS2BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.DS2BinaryTree
{
    public class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Data { get; set; }

        public Node(int Data)
        {
            Data = Data;
        }
    }

    public class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree(int Data)
        {
            Root = new Node(Data);
        }

        public void Add(int n, Node node)
        {
            if(n > node.Data)
            {
                if (node.Right == null) node.Right = new Node(n);
                else Add(n, node.Right);
            }

            else if (n < node.Data)
            {
                if (node.Left == null) node.Left = new Node(n);
                else Add(n, node.Left);
            }
        }

        public void Add(int n)
        {
            Add(n, Root);
        }

        public Node Find(int n, Node node)
        {
            if (node == null) return null;
            else if (node.Data == n) return node;
            else if (n > node.Data) return node.Right;
            else if (n < node.Data) return node.Left;
            return null;
        }
        public Node Find(int n)
        {
            return Find(n, Root);
        }
    }
}
