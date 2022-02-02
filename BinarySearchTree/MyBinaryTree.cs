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
        /// insert the node into bst.
        public void InsertNode(T value)
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
                while (true)
                {
                    parent = current;
                    if (current.data.CompareTo(value) >= 0)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newNode;
                            break;
                        }
                    }
                }
            }
        }
        /// display the binary search tree.
        public void Display(INode<T> parent)
        {
            if (parent != null)
            {
                Display(parent.left);
                Display(parent.right);
                Console.WriteLine("{0} is BST Node", parent.data);
            }
        }
        /// display the root node of BST.
        public void Root()
        {
            do
            {
                Console.WriteLine("BST Root Node:" + root.data);
                break;
            } while (root != null);
        }
        /// print the bst in pre-order.
        public void PreOrder(INode<T> root)
        {
            if (root == null)
            {
                return;
            }
            Console.WriteLine(root.data + " ");
            PreOrder(root.left);
            PreOrder(root.right);
        }
        /// print the bst in in-order.
        public void InOrder(INode<T> root)
        {
            if (root == null)
            {
                return;
            }
            InOrder(root.left);
            Console.WriteLine(root.data + " ");
            InOrder(root.right);
        }
        /// print the bst in post-order.
        public void PostOrder(INode<T> root)
        {
            if (root == null)
            {
                return;
            }
            PostOrder(root.left);
            PostOrder(root.right);
            Console.WriteLine(root.data + " ");
        }
        /// length of bst
        public int Size(INode<T> root)
        {
            if (root == null)
                return 0;
            else
                return (Size(root.left) + 1 + Size(root.right));
        }
        // search the key into bst.
        public bool Search(INode<T> root, T key)
        {
            if (root == null)
            {
                return false;
            }
            if (root.data.CompareTo(key) == 0)
            {
                return true;
            }
            else if (root.data.CompareTo(key) < 0)
            {
                return Search(root.left, key);
            }
            else
            {
                return Search(root.right, key);
            }
        }

    }
}