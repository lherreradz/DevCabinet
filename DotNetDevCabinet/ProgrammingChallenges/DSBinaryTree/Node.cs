using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingChallenges.DSBinaryTree
{
    public class Node
    {
        public Node(int value)
        {
            Data = value;
        }
        public int Data { get; set; }
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }
    }
}
