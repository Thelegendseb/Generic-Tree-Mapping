using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Tree_Mapping__GTM_
{
    // A class representing a container for multiple trees.
    internal class TreeContainer<NodeData>
    {

        // A list of the trees in the container.
        private List<Tree<NodeData>> trees;

        // Constructs a new tree container.
        public TreeContainer()
        {
            trees = new List<Tree<NodeData>>();
        }

        // Adds a tree to the container.
        public void addTree(Tree<NodeData> tree)
        {
            trees.Add(tree);
        }

        // Removes a tree from the container.
        public void removeTree(Tree<NodeData> tree)
        {
            trees.Remove(tree);
        }

        // Returns the tree at the specified index in the container.
        public Tree<NodeData> getTree(int index)
        {
            return trees[index];
        }

        // Returns all trees stored by the container.
        public List<Tree<NodeData>> getAllTrees()
        {
            return trees;
        }

        // Sets the tree at the specified index in the container.
        public void setTree(int index, Tree<NodeData> tree)
        {
            trees[index] = tree;
        }

    }
}
