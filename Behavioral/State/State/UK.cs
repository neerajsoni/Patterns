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
    public class UK : State
    {
        private static readonly State state = new UK();

        private UK()
        {
        }

        public static State Instance()
        {
            return state;
        }

        public override void ToIndia(TravelManager tm)
        {
            Console.WriteLine("To India");
            ChangeState(tm, India.Instance());
        }

        public override void ToUK(TravelManager tm)
        {
            Console.WriteLine("Already In UK");
        }

        public override void ToUS(TravelManager tm)
        {
            Console.WriteLine("To US");
            ChangeState(tm, US.Instance());
        }
    }
}
