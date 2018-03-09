using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            CustomBinarySearch searchTree = new CustomBinarySearch();
            searchTree.Add(50);
            for (int index = 1; index <= 50; index++)
            {
                searchTree.Add(50 + rng.Next(50));
                searchTree.Add(50 - rng.Next(50));
            }
            searchTree.Search(88);
            Console.ReadLine();
        }
    }
}
