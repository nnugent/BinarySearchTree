using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {
        int data;
        public Node left;
        public Node right;

        public Node(int value)
        {
            data = value;
        }

        public int Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }
    }
}
