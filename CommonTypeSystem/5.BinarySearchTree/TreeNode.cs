using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.BinarySearchTree
{
    /// <summary>
    /// Represents a node from a binary tree structure
    /// </summary>
    public class TreeNode<T> : ICloneable
    {
        // node value
        public T Value { get; private set; }

        // left an right child
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }

        public TreeNode()
        {
            this.Left = null;
            this.Right = null;
        }

        public TreeNode(T value) : this()
        {
            this.Value = value;
        }

        /// <summary>
        /// Creates a copy of the node, with all of its chilren nodes
        /// </summary>
        /// <returns>The copied node</returns>
        public object Clone()
        {
            TreeNode<T> node = new TreeNode<T>(this.Value);

            // copy recursively all child nodes on the left
            if(this.Left != null)
            {
                node.Left = (TreeNode<T>) this.Left.Clone();
            }

            // copy recursively all child nodes on the right
            if(this.Right != null)
            {
                node.Right = (TreeNode<T>) this.Right.Clone();
            }

            return node;
        }
    }
}
