using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingChallenges.DSBinaryTree.TreeConstructorProblem
{
    public class TreeConstructorProblem
    {
        public static string TreeConstructor(string[] strArr)
        {
            BinaryTree binaryTree = new BinaryTree();

            foreach(var tuple in strArr)
            {
                var pair = tuple.Replace("(", "").Replace(")", "").Split(",");
                var result = binaryTree.Add(Convert.ToInt32(pair[0]), Convert.ToInt32(pair[1]));
                if (result == false) return "false";
            }

            if (binaryTree.rootList.Count > 1) return "false";

            return "true";
        }
    }

    class Node
    {
        public Node(int value)
        {
            Data = value;
        }
        public int Data { get; set; }
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }
    }

    class BinaryTree
    {
        public List<Node> rootList;

        public BinaryTree()
        {
            rootList = new List<Node>();
        }

        public bool Add(int childValue, int parentValue) {
            if(!rootList.Any())
            {
                return NewTree(childValue, parentValue);           
            }
            else
            {
                Node parentNode = GetNode(parentValue);
                Node childNode = GetNode(childValue);
                if (parentNode == null)
                {
                    if (childNode != null)
                    {
                        Node newParentNode = new Node(parentValue);
                        if (childValue < parentValue) newParentNode.LeftNode = childNode;
                        else if (childValue > parentValue) newParentNode.RightNode = childNode;
                        rootList.Remove(childNode);
                        rootList.Add(newParentNode);
                    }
                    else
                    {
                        NewTree(childValue, parentValue);
                    }
                }
                else
                {
                    if (parentNode.LeftNode != null && parentNode.RightNode != null) return false;
                    if (childNode == null)
                    {
                        if (childValue < parentValue)
                        {
                            parentNode.LeftNode = new Node(childValue);
                        }
                        else if (childValue > parentValue)
                        {
                            parentNode.RightNode = new Node(childValue);
                        }
                    }
                    else
                    {
                        if (childValue < parentValue)
                        {
                            if (parentNode.LeftNode == null) parentNode.LeftNode = childNode;
                            else return false;
                        }
                        else if (childValue > parentValue)
                        {
                            if (parentNode.RightNode == null) parentNode.RightNode = childNode;
                            else return false;
                        }
                        rootList.Remove(childNode);
                    }
                }
            }
            return true;
        }

        private Node GetNode(int value)
        {
            foreach (var root in rootList)
            {
                var node = GetNode(root, value);
                if (node != null) return node;
            }
            return null;
        }
        private Node GetNode(Node node, int value)
        {
            if (node.Data == value) return node;

            var rightNode = (node.RightNode != null)? GetNode(node.RightNode, value) : null;
            var leftNode = (node.LeftNode != null) ? GetNode(node.LeftNode, value) : null;

            if (rightNode != null) return rightNode;
            else if (leftNode != null) return leftNode;

            return null;
        }
        private bool NewTree(int childValue, int parentValue)
        {
            var newParentNode = new Node(parentValue);
            var newChildNode = new Node(childValue);

            if (childValue > parentValue) newParentNode.RightNode = newChildNode;
            else if (childValue < parentValue) newParentNode.LeftNode = newChildNode;
            else return false;

            rootList.Add(newParentNode);

            return true;
        }
    }
}
