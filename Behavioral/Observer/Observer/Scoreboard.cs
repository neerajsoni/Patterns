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
    public class Scoreboard : IObserverContract
    {
        private string _name;
        public Scoreboard()
        {
            _name = "";
        }

        public Scoreboard(string name)
        {
            _name = name + ": ";
        }

        public void Notify(object param)
        {
            //process completion notification
            Console.WriteLine(_name + param);
        }
    }
}
