using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Container tree = new Container("root");
            Container a1= new Container("a1");
            INode b1 = new Leaf("b1");
            INode a2 = new Leaf("a2");
            INode a3 = new Leaf("a3");

            tree.Add(a1);
            tree.Add(b1);
            a1.Add(a2);
            a1.Add(a3);

            Console.WriteLine(tree.Print());

            Console.ReadLine();
        }
    }
}
