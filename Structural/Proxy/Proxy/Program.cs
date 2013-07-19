using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            IPower p = new PowerProxy();
            Console.WriteLine(p.GetVoltage(0));
            Console.WriteLine(p.GetVoltage(101));
            Console.WriteLine(p.GetVoltage(102));

            Console.ReadLine();
        }
    }
}
