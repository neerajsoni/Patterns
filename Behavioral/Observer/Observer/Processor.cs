using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// -----------------------------------------------------------------------
// <copyright file="$safeitemrootname$.cs" company="$registeredorganization$">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------
namespace Observer
{
    public class Processor : IObservableContract
    {
        private readonly List<IObserverContract> observers = new List<IObserverContract>();

        public void Register(IObserverContract observer)
        {
            observers.Add(observer);
        }

        public void Unregister(IObserverContract observer)
        {
            if (observers.Contains(observer))
                observers.Remove(observer);
        }

        private void NotifyObservers(object param)
        {
            foreach (var observer in observers)
            {
                observer.Notify(param);
            }
        }

        public void Process()
        {
            for (int i = 0; i < 10; i++)
            {
                //algo impl

                //Notify all observers
                NotifyObservers(i);
            }
        }
    }
}
