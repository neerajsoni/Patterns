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
            DataGenerator dataGenerator = new DataGenerator();

            DataObserver dataObserver1 = new DataObserver("O1");
            dataGenerator.Subscribe(dataObserver1);

            DataObserver dataObserver2 = new DataObserver("O2");
            dataGenerator.Subscribe(dataObserver2);

            DataObserver dataObserver3 = new DataObserver("O3");
            dataGenerator.Subscribe(dataObserver3);

            DataObserver dataObserver4 = new DataObserver("O4");
            dataGenerator.Subscribe(dataObserver4);

            DataObserver dataObserver5 = new DataObserver("O5");
            dataGenerator.Subscribe(dataObserver5);

            dataGenerator.Run();

            Console.ReadLine();
        }
    }
}
