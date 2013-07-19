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
    public class Leaf : INode
    {
        private readonly string _name;
        public Leaf(string name)
        {
            _name = name;
        }
    
        public string Name
        {
            get { return _name; }
        }

        public string Print()
        {
            return _name;
        }
    }
}
