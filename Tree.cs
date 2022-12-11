using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generic_Tree_Mapping__GTM_.Models;

namespace Generic_Tree_Mapping__GTM_
{
    // A class representing a tree data structure.
    internal class Tree<NodeData>
    {
        // The root node of the tree.
        private Node<NodeData> root;

        // Constructs a new tree with the given root node.
        public Tree(Node<NodeData> root)
        {
            this.root = root;
        }

        // Returns the root node of the tree.
        public Node<NodeData> getRoot()
        {
            return this.root;
        }

        // Sets the root node of the tree.
        public void setRoot(Node<NodeData> root)
        {
            this.root = root;
        }
    }
}
