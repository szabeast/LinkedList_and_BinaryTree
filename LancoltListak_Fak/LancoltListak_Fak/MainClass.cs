using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAndBinaryTree
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //LinkedList testing:

            LinkedList l = new LinkedList();
            l.PushFront(3);
            l.PushFront(25);
            l.PushBack(14);
            l.PushBack(89);
            l.PushBack(31);

            l.PopBack();
            l.PopFront();

            l.Print();

            Console.WriteLine();
            //Filling the Binary tree with the amount of numbers of your choice:
            Random r = new Random();
            BinaryTree x = new BinaryTree();
            BTree root = null;

            Console.Write("Please enter the amount of numbers you want in the tree: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            //Filling the array with these numbers: 
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(1,200);
            }
            //Putting the numbers in the tree:
            for (int i = 0; i < array.Length; i++)
            {
                root = x.PutIn(root, array[i]);
            }
            //Print out the items:
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {array[i]}");
            }

            Console.WriteLine();

            //Binary tree In-Pre-PostOrder:
            Console.WriteLine("PreOrder:");
            x.PreOrder(root);
            Console.WriteLine("\nPostOrder:");
            x.PostOrder(root);
            Console.WriteLine("\nInOrder:");
            x.InOrder(root);

            Console.ReadKey();
        }
    }
}