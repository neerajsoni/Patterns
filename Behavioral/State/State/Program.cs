using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            TravelManager tm = new TravelManager();

            tm.ToIndia();
            tm.ToUK();
            tm.ToUS();
            tm.ToIndia();

            Console.ReadLine();
        }
    }
}
