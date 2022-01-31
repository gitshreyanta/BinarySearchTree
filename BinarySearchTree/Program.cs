using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Program");
            DisplayBST();
            Console.ReadLine();
        }
        //Method to Initialize Nodes.
        public static void DisplayBST()
        {
            MyBinaryTree<int> tree = new MyBinaryTree<int>();
            tree.CreateNode(56);
            tree.CreateNode(30);
            tree.CreateNode(70);
            Console.WriteLine("Display Nodes present in Binary Search Tree");
            tree.Display();
        }
    }
}