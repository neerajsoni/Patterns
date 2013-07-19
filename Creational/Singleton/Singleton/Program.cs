using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Trace.Listeners.Add(new ConsoleTraceListener());

            Console.WriteLine("Running ThreadSafeTest");
            ThreadSafeTest();
            Console.WriteLine("Enter to run ThreadUnsafeTest");
            Console.ReadLine();
            Console.Clear();
            ThreadUnsafeTest();

            Console.ReadLine();
        }

        private static void ThreadSafeTest()
        {
            for (int i = 0; i < 20; i++)
            {
                Thread t = new Thread(() =>
                {
                    ThreadSafeSingleton s1 = ThreadSafeSingleton.Instance;
                    ThreadSafeSingleton2 s2 = ThreadSafeSingleton2.Instance;
                });
                t.Start();

                //no impact of join on creation of singleton obj
                //t.Join(); //???
            }
        }

        private static void ThreadUnsafeTest()
        {
            for (int i = 0; i < 20; i++)
            {
                Thread t = new Thread(() =>
                {
                    ThreadUnsafeSingleton s1 = ThreadUnsafeSingleton.Instance;
                });
                t.Start();

                //if we do not join threads, multiple creations will happen for singleton obj!!!
                //t.Join(); //???
            }
        }
    }
}
