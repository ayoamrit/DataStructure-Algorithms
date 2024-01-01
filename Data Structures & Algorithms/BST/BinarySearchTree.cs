using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures___Algorithms.BST
{
    public class BinarySearchTree
    {
        TreeNode Root { get; set; } = null;

       public void Insert(int key, string value)
       {
            Root = InsertHelper(Root, key, value);
       }

        private TreeNode InsertHelper(TreeNode node, int key, string value)
        {
            TreeNode newTreeNode = new TreeNode(key, value);

            if(node == null)
            {
                return newTreeNode;
            }

            if(key < node.Key)
            {
                node.LeftChild = InsertHelper(node.LeftChild, key, value);
            }
            else
            {
                node.RightChild = InsertHelper(node.RightChild, key, value);
            }

            return node;
        }

        public string Locate(int key)
        {
            TreeNode newNode = Locate(Root, key);
            return newNode == null ? null : newNode.Value;
        }

        private TreeNode? Locate(TreeNode node, int key)
        {
            if(node == null || node.Key == key)
            {
                return node;
            }
            else if(key < node.Key)
            {
                return Locate(node.LeftChild, key);
            }
            else
            {
                return Locate(node.RightChild, key);
            }
        }


        public bool Exist(int key)
        {
            return Exist(Root, key);
        }

        private bool Exist(TreeNode node, int key)
        {
            //Check whether the node is null or not 
            if(node == null)
            {
                return false;
            }

            if(node != null && node.Key == key)
            {
                return true;
            }
            else if(node.Key < key)
            {
                return Exist(node.RightChild, key);
            }
            else
            {
                return Exist(node.LeftChild, key);
            }
        }
     
    }
}
