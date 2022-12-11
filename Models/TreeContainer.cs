using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Tree_Mapping__GTM_.Models
{
    // A class representing a container for multiple trees.
    internal class TreeContainer
    {

        // A list of the trees in the container.
        private List<Tree> trees;

        // Constructs a new tree container.
        public TreeContainer()
        {
            this.trees = new List<Tree>();
        }

        // Adds a tree to the container.
        public void addTree(Tree tree)
        {
            this.trees.Add(tree);
        }

        // Removes a tree from the container.
        public void removeTree(Tree tree)
        {
            this.trees.Remove(tree);
        }

        // Returns the tree at the specified index in the container.
        public Tree getTree(int index)
        {
            return this.trees[index];
        }

        // Returns all trees stored by the container.
        public List<Tree> getAllTrees()
        {
            return this.trees;
        }

        // Sets the tree at the specified index in the container.
        public void setTree(int index, Tree tree)
        {
            this.trees[index] = tree;
        }

    }
}
