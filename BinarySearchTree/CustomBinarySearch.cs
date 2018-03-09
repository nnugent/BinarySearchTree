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
                if (currentNode.Data == newNode.Data) break;
                else if (currentNode.Data > newNode.Data)
                {
                    if (currentNode.left == null)
                    {
                        currentNode.left = newNode;
                        break;
                    }
                    currentNode = currentNode.left;
                }
                else if (currentNode.Data < newNode.Data)
                {
                    if (currentNode.right == null)
                    {
                        currentNode.right = newNode;
                        break;
                    }
                    currentNode = currentNode.right;
                }
            }
        }

        public bool Search(int value)
        {
            bool found = false;
            string directions = "";
            Node currentNode = head;
            while (currentNode != null)
            {
                if (currentNode.Data == value)
                {
                    found = true;
                    break;
                }
                else if (currentNode.Data > value)
                {
                    directions += currentNode.Data + " Left\n";
                    currentNode = currentNode.left;
                }
                else if (currentNode.Data < value)
                {
                    directions += currentNode.Data + " Right\n";
                    currentNode = currentNode.right;
                }
            }
            if (found)
            {
                Console.WriteLine("We found " + value + "!!!\n" + directions);
            }
            else
            {
                Console.WriteLine("No luck bud.\n" + directions);
            }
            return found;
        }
    }
}
