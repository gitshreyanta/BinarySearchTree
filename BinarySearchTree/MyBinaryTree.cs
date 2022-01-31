using BinarySearchTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class MyBinaryTree<T> where T : IComparable
    {
        public INode<T> root;
        //Creates the node.
        public void CreateNode(T value)
        {
            INode<T> newNode = new INode<T>(value);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                INode<T> parent = root;
                INode<T> current = root;
                if (current.data.CompareTo(value) >= 0)
                {
                    parent.leftTree = newNode;
                    return;
                }
                else
                {
                    parent.rightTree = newNode;
                    return;
                }
            }
        }
        //Displays Nodes in Binary search Tree
        public void Display()
        {
            INode<T> temp = root;
            if (temp != null)
            {
                Console.WriteLine("Root Node:{0}", temp.data.ToString());
            }
            if (temp.leftTree != null)
            {
                Console.WriteLine("Left Node:{0}", temp.leftTree.data.ToString());
            }
            if (temp.rightTree != null)
            {
                Console.WriteLine("Right Node:{0}", temp.rightTree.data.ToString());
            }
        }
    }
}