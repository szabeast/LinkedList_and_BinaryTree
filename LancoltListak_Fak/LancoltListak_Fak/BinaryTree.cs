using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAndBinaryTree
{
    class BTree
    {
        public int val;
        public BTree left;
        public BTree right;
    }
    class BinaryTree
    {
        public BTree PutIn(BTree root, int value)
        {
            if (root == null)
            {
                root = new BTree();
                root.val = value;
            }

            else if (value < root.val) root.left = PutIn(root.left, value);
            else if (value > root.val) root.right = PutIn(root.right,value);

            return root;
        }

        /// <summary>
        /// PreOrder:
        /// root -> left -> right
        /// </summary>
        /// <param name="root"></param>
        public void PreOrder(BTree root)
        {
            if (root == null) return;
            Console.Write(root.val + " ");
            PreOrder(root.left);
            PreOrder(root.right);
        }

        /// <summary>
        /// PostOrder:
        /// left -> right -> root
        /// </summary>
        /// <param name="root"></param>
        public void PostOrder(BTree root)
        {
            if (root == null) return;
            PostOrder(root.left);
            PostOrder(root.right);
            Console.Write(root.val + " ");
        }

        /// <summary>
        /// InOrder:
        /// left -> root -> right
        /// </summary>
        /// <param name="root"></param>
        public void InOrder(BTree root)
        {
            if (root == null) return;
            InOrder(root.left);
            Console.Write(root.val + " ");
            InOrder(root.right);
        }
    }
}