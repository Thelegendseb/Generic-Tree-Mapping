using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Tree_Mapping__GTM_.Models
{
    // A class representing a node in a tree.
    internal class Node
    {
        // The value of the node.
        private NodeData data;
        // A list of the node's children.
        private List<Node> children;

        // Constructs a new node with the given value.
        public Node(NodeData value)
        {
            this.data = value;
            this.children = new List<Node>();
        }

        // Adds a child node to the current node.
        public void addChild(Node child)
        {
            this.children.Add(child);
        }

        // Removes a child node from the current node.
        public void removeChild(Node child)
        {
            this.children.Remove(child);
        }

        // Gets all children from the current node.
        public List<Node> getChildren()
        {
            return this.children;
        }

        // Gets all children from the current node.
        public NodeData getData()
        {
            return this.data;
        }
    }
}
