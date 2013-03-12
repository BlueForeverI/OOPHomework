using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.BinarySearchTree
{
    /// <summary>
    /// A class to test the functionality of the BinarySearchTree
    /// </summary>
    class TreeTest
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> tree1 = new BinarySearchTree<int>();

            // test the add method
            tree1.Add(2);
            tree1.Add(1);
            tree1.Add(3);
            tree1.Add(7);
            tree1.Add(5);

            // test the Clone() method
            BinarySearchTree<int> tree2 = (BinarySearchTree<int>)tree1.Clone();

            // test the ToString() method
            Console.WriteLine("Tree 1: {0}", tree1);
            Console.WriteLine("Tree 2: {0}", tree2);

            // test the Equals() method
            Console.WriteLine("The two trees are equal: {0}",
                (tree1 == tree2));

            // test the Delete() method
            tree2.Delete(7);
            Console.WriteLine("After deleting 5 from tree 2: {0}", tree2);

            // test the Find() method
            var node = tree1.Find(3);
            if(node != null)
            {
                Console.WriteLine("3 was found in tree 1");
            }
            else
            {
                Console.WriteLine("3 was NOT found in tree 1");
            }
        }
    }
}
