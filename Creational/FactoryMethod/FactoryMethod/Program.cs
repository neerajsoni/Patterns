using System;
using System.Diagnostics;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Trace.Listeners.Add(new ConsoleTraceListener());
            
            PaletteFactory factory = new PaletteFactory();
            factory.AddColors();
            factory.Show();

            Trace.WriteLine("\n");

            factory = new Palette();
            factory.AddColors(); 
            factory.Show();

            Console.ReadLine();
        }
    }
}
