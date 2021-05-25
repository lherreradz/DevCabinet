using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingChallenges.DSBinaryTree
{
    public class BinaryTree
    {
        public Node root { get; set; } 

        public bool Add(int value)
        {
            Node before = null;
            Node after = root;
            while(after != null)
            {
                before = after;
                if (value < after.Data) after = after.LeftNode;
                else if (value > after.Data) after = after.RightNode;
                else return false;
            }

            Node newNode = new(value);

            if (root == null) root = newNode;
            else
            {
                if (value > before.Data) before.RightNode = newNode;
                else if (value < before.Data) before.LeftNode = newNode;
            }
            return true;            
        }

        public int GetParentValue(int value)
        {
            return GetParentValue(root, value);
        }

        private int GetParentValue(Node node ,int value)
        {
            if ((node.LeftNode != null && node.LeftNode.Data == value) ||
                (node.RightNode != null && node.RightNode.Data == value)) return node.Data;
            else if (node.LeftNode == null && node.RightNode == null) return value;
            else if (value > node.Data) return GetParentValue(node.RightNode, value);
            else if (value < node.Data) return GetParentValue(node.LeftNode, value);
            return value;
        }


    }
}
