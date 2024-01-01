using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures___Algorithms.BST
{
    public class TreeNode
    {
        public int Key { get; set; }
        public string Value { get; set; }
        public TreeNode LeftChild { get; set; }
        public TreeNode RightChild { get; set; }

        public TreeNode(int Key, string Value)
        {
            this.Key = Key;
            this.Value = Value;
        }
    }
}
