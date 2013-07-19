using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// -----------------------------------------------------------------------
// <copyright file="$safeitemrootname$.cs" company="$registeredorganization$">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------
namespace Composite
{
    public class Container : INode
    {
        private readonly string _name;
        private List<INode> _nodes;

        public Container(string name)
        {
            _name = name;
        }

        public List<INode> Nodes
        {
            get { return _nodes ?? (_nodes = new List<INode>()); }
            set { _nodes = value; }
        }

        public string Name
        {
            get { return _name; }
        }

        public string Print()
        {
            //linq for tree traversal
            return Nodes.Aggregate(Name, (current, node) => current + ", " + (node.Print()));   
        }

        public void Add(INode node)
        {
            Nodes.Add(node);
        }
    }
}
