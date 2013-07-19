using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// -----------------------------------------------------------------------
// <copyright file="$safeitemrootname$.cs" company="$registeredorganization$">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------
namespace State
{
    public abstract class State
    {
        public abstract void ToIndia(TravelManager tm);

        public abstract void ToUK(TravelManager tm);

        public abstract void ToUS(TravelManager tm);

        public void ChangeState(TravelManager tm, State s)
        {
            tm.ChangeState(s);
        }
    }
}
