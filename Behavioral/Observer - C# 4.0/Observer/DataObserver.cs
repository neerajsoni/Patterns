using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    /// <summary>
    /// A component DataObserver to be notified of updates in another component DataGenerator, without use of .Net events.
    /// Inherited from IObserver
    /// </summary>
    class DataObserver : IObserver<int>
    {
        //give it a name to distinguish it in the output
        //not mandetory
        private readonly string _name = "Observer";
        
        public DataObserver(string observerName)
        {
            _name = observerName;
        }
        
        #region IObserver<int> Members
        public void OnCompleted()
        {
            Console.WriteLine(_name + ":Completed");
        }
        
        public void OnError(Exception error)
        {
            Console.WriteLine(_name + ": Error");
        }
        
        public void OnNext(int value)
        {
            Console.WriteLine(_name + ":Generated data {0}", value);
        }
        #endregion
    }
}
