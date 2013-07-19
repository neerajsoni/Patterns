using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Processor p = new Processor();
            Scoreboard s1 = new Scoreboard("a");
            Scoreboard s2 = new Scoreboard("b");
            Scoreboard s3 = new Scoreboard("c");

            p.Register(s1);
            p.Register(s2);
            p.Register(s3);
            p.Unregister(s2);

            p.Process();

            Console.ReadLine();
        }
    }
}
