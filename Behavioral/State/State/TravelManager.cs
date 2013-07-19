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
    public class TravelManager
    {
        private State state;

        public TravelManager()
        {
            state = India.Instance();
        }

        public State State
        {
            get { return state; }
            set { state = value; }
        }

        internal void ChangeState(State s)
        {
            State = s;
        }

        public void ToIndia()
        {
            State.ToIndia(this);
        }

        public void ToUK()
        {
            State.ToUK(this);
        }

        public void ToUS()
        {
            State.ToUS(this);
        }
    }
}
