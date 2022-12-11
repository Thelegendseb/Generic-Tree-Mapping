using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Tree_Mapping__GTM_.Models
{
    // A class representing the data associated with a node in a tree.
    internal class NodeData
    {

        // The data associated with the node.
        private object data;

        // Constructs a new node data object with the given data.
        public NodeData(object data)
        {
            this.data = data;
        }

        // Set the data of the current NodeData instance.
        public void setData(object value)
        {
            this.data = value;
        }

        // Get the data of the current NodeData instance.
        public object getData(object value)
        {
            return this.data;
        }

        // Prints the data to the console.
        public void print()
        {
            Console.WriteLine(this.data);
        }

    }
}
