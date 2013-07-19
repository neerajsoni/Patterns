// -----------------------------------------------------------------------
// <copyright file="ThreadSafeSingleton.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

using System.Diagnostics;
using System.Threading;

namespace Singleton
{
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton instance;
        private static Mutex mutex = new Mutex();

        private ThreadSafeSingleton()
        {
            System.Threading.Thread.Sleep(50);
            Trace.WriteLine("created");
        }

        public static ThreadSafeSingleton Instance
        {
            get 
            { 
                mutex.WaitOne();

                if(instance == null)
                    instance = new ThreadSafeSingleton();

                mutex.ReleaseMutex();

                return instance;
            }
        }
    }

    public class ThreadSafeSingleton2
    {
        private static ThreadSafeSingleton2 instance = new ThreadSafeSingleton2();

        private ThreadSafeSingleton2()
        {
            System.Threading.Thread.Sleep(50);
            Trace.WriteLine("created");
        }

        public static ThreadSafeSingleton2 Instance
        {
            get { return instance; }
        }
    }
}
