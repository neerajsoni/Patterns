// -----------------------------------------------------------------------
// <copyright file="ThreadUnsafeSingleton.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

using System.Diagnostics;

namespace Singleton
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class ThreadUnsafeSingleton
    {
        private static ThreadUnsafeSingleton instance;

        private ThreadUnsafeSingleton()
        {
            System.Threading.Thread.Sleep(50);
            Trace.WriteLine("created");
        }

        public static ThreadUnsafeSingleton Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new ThreadUnsafeSingleton();
                }
                
                return instance;
            }
        }
    }
}
