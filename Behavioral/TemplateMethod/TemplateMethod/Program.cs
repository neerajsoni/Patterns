using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountProcessor p = new CreditProcessor();
            p.SetAmount(10.25);
            p.Process("123");
            
            p = new DebitProcessor();
            p.SetAmount(10.25);
            p.Process("123");

            Console.ReadLine();
        }
    }
}
