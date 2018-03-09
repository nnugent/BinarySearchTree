using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class CustomBinarySearch
    {
        public Node head;

        public void Add(int item)
        {
            Node newNode = new Node(item);
            if (head == null)
            {
                head = newNode;
                return;
            }
            Node currentNode = head;
            while (currentNode != null)
            { 
                if (currentNode.Data > newNode.Data)
                {
                    currentNode = currentNode.left;
                }
                else if (currentNode.Data < newNode.Data)
                {
                    currentNode = currentNode.right;
                }
            }
            currentNode  = newNode;
        }

        public bool Search(int value)
        {
            Node currentNode = head;
            while (currentNode != null)
            {
                if (currentNode.Data == value)
                {
                    return true;
                }
                else if (currentNode.Data < head.Data)
                {
                    currentNode = currentNode.left;
                    Console.WriteLine(currentNode.left + "Left");
                }
                else
                {
                    currentNode = currentNode.right;
                    Console.WriteLine(currentNode.Data + "Right");
                }
            }
            return false;
        }
    }
}
