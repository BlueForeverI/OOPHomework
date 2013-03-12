using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.BinarySearchTree
{
    /// <summary>
    /// Represents a generic binary search tree structure
    /// </summary>
    struct BinarySearchTree<T> : ICloneable
    {
        // the root element of the tree
        public TreeNode<T> Root { get; private set; }

        /// <summary>
        /// Static method to add element to a node
        /// </summary>
        /// <param name="element">The value to add</param>
        /// <param name="node">The node to add to</param>
        private static void Add(T element, TreeNode<T> node)
        {
            if(node == null)
            {
                // found an empty node
                node = new TreeNode<T>(element);
                return;
            }
            else
            {
                if((dynamic)node.Value > (dynamic)element)
                {
                    // go left and find the appropriate place to add the value
                    if (node.Left == null)
                    {
                        node.Left = new TreeNode<T>(element);
                    }
                    else
                    {
                        // recursively add to the left
                        Add(element, node.Left);
                    }
                }
                else if ((dynamic)node.Value < (dynamic)element)
                {
                    // go right and find the appropriate place to add the value
                    if (node.Right == null)
                    {
                        node.Right = new TreeNode<T>(element);
                    }
                    else
                    {
                        // recursively add to the right
                        Add(element, node.Right);
                    }
                }
            }
        }

        /// <summary>
        /// Add value to the tree
        /// </summary>
        /// <param name="element">Value to add</param>
        public void Add(T element)
        {
            if (this.Root == null)
            {
                // tree is empty
                this.Root = new TreeNode<T>(element);
            }
            else
            {
                //  add to the root element, with the static recursive method
                Add(element, this.Root);
            }
        }

        /// <summary>
        /// Static method to find a value in a node
        /// </summary>
        /// <param name="value">Value to find</param>
        /// <param name="node">Node to search in</param>
        /// <returns>The found node with the value, or null if not found</returns>
        private static TreeNode<T> Find(T value, TreeNode<T> node)
        {
            if(node == null)
            {
                // no node found
                return null;
            }

            if((dynamic)node.Value == (dynamic)value)
            {
                // return a copy of the found node
                return (TreeNode<T>)node.Clone();
            }

            if((dynamic)node.Value > (dynamic)value)
            {
                // recursively search in in the left child
                return (TreeNode<T>)Find(value, node.Left).Clone();
            }
            else
            {
                // recursively search in in the right child
                return (TreeNode<T>)Find(value, node.Right).Clone();
            }
        }

        /// <summary>
        /// Use the static method to search in the root for a node 
        /// with the given value
        /// </summary>
        /// <param name="value">Value to find</param>
        /// <returns>The found node, or null if not found</returns>
        public TreeNode<T> Find(T value)
        {
            return Find(value, this.Root);
        }

        /// <summary>
        /// Removes an element from a given node
        /// </summary>
        /// <param name="value">Node value to remove</param>
        /// <param name="node">Node to delete from</param>
        /// <returns>The deleted node</returns>
        private static TreeNode<T> Delete(T value, TreeNode<T> node)
        {
            if ((dynamic)node.Value > (dynamic)value)
            {
                // recursively delete from the left child
                node.Left = Delete(value, node.Left);
            }
            else if ((dynamic)node.Value < (dynamic)value)
            {
                // recursively delete from the rightr child
                node.Right = Delete(value, node.Right);
            }
            else
            {
                node = null;
            }

            return node;
        }

        /// <summary>
        /// Deletes an element from the root
        /// </summary>
        /// <param name="value">Element value</param>
        public void Delete(T value)
        {
            if(Find(value) != null)
            {
                this.Root = Delete(value, this.Root);
            }
        }

        /// <summary>
        /// Static method to give the string representation of a node
        /// </summary>
        /// <param name="node">The given node</param>
        /// <returns>All values in the node</returns>
        private static string ToString(TreeNode<T> node)
        {
            StringBuilder sb = new StringBuilder();
            if(node != null)
            {
                sb.AppendFormat(" {0} ", node.Value);

                // recursively get string representation of left and right child
                sb.Append(ToString(node.Left));
                sb.Append(ToString(node.Right));
            }

            return sb.ToString();
        }

        /// <summary>
        /// Overrides the default ToString() method
        /// </summary>
        /// <returns>String representation of the root node</returns>
        public override string ToString()
        {
            return ToString(this.Root);
        }

        /// <summary>
        /// Compare two nodes for equality
        /// </summary>
        /// <param name="node1">The first node</param>
        /// <param name="node2">The second node</param>
        /// <returns>True if the nodes are equal, False otherwise</returns>
        private static bool Equals(TreeNode<T> node1, TreeNode<T> node2)
        {
            if(node1 != null && node2 != null)
            {
                // recursively check left and right children
                return Equals(node1.Left, node2.Left) &&
                       Equals(node1.Right, node2.Right);
            }
            else if(node1 == null && node2 == null)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Overrides the default Equals() method
        /// </summary>
        /// <param name="obj">The other tree to compare</param>
        /// <returns>True if the two trees are equal</returns>
        public override bool Equals(object obj)
        {
            BinarySearchTree<T> other = (BinarySearchTree<T>) obj;

            return Equals(this.Root, other.Root);
        }

        /// <summary>
        /// Static method to get the hash code of a single node 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private static int GetHashCode(TreeNode<T> node)
        {
            if(node != null)
            {
                // recursively get the hasch codes of the left and right children
                return ( node.Value.GetHashCode() + GetHashCode(node.Left) + GetHashCode(node.Right))
                    .GetHashCode();
            }

            return 0;
        }

        /// <summary>
        /// Overrides the default GetHashCode() method
        /// </summary>
        /// <returns>Hash code of the root element</returns>
        public override int GetHashCode()
        {
            return GetHashCode(this.Root);
        }

        /// <summary>
        /// Compares two binary search trees for equality
        /// </summary>
        /// <param name="tree1">The first tree</param>
        /// <param name="tree2">The second tree</param>
        /// <returns>True if the trees are equal, False otherwise</returns>
        public static bool operator ==(BinarySearchTree<T> tree1, BinarySearchTree<T> tree2)
        {
            return tree1.Equals(tree2);
        }

        /// <summary>
        /// Compares two binary search trees for unequality
        /// </summary>
        /// <param name="tree1">The first tree</param>
        /// <param name="tree2">The second tree</param>
        /// <returns>True if the trees are NOT equal, False otherwise</returns>
        public static bool operator !=(BinarySearchTree<T> tree1, BinarySearchTree<T> tree2)
        {
            return !tree1.Equals(tree2);
        }

        /// <summary>
        /// Clones the current binary search tree
        /// </summary>
        /// <returns>Deep copy of the tree</returns>
        public object Clone()
        {
            BinarySearchTree<T> tree = new BinarySearchTree<T>();
            tree.Root = (TreeNode<T>)this.Root.Clone();
            return tree;
        }
    }
}
