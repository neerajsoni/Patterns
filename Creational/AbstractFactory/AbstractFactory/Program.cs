using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using AbstractFactory.Abstract;
using AbstractFactory.Concrete;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Trace.Listeners.Add(new ConsoleTraceListener());
 
            ChocolateFactory factory;
            DarkChocolate dark;
            LightChocolate light;
            CaramelChocolate caramel;

            Console.Write("ENTER - d for dryfruit, f for filled : ");
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            Trace.WriteLine("\n");

            if(keyInfo.KeyChar.CompareTo('d') == 0)
            {
                factory = new DryFruitChocolateFactory();
            }
            else
            {
                factory = new FilledChocolateFactory();
            }

            dark = factory.CreateDarkChocolate();
            light = factory.CreateLightChocolate();
            caramel = factory.CreateCaramelChocolate();

            Console.ReadLine();
        }
    }
}
