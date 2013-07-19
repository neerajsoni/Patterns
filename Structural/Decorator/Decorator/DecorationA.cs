// -----------------------------------------------------------------------
// <copyright file="DecorationA.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Decorator
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    class DecorationA : Decorator
    {
        public DecorationA(IWindowObject decoratedWindow)
            : base(decoratedWindow)
        {
        }

        public override void draw()
        {
            base.draw();
            DecorationAStuff();
        }

        private void DecorationAStuff()
        {
            Console.WriteLine("\t\tdoing DecorationA things on " + _decoratedWindow.GetType());
        }

        public override String getDescription()
        {
            return base.getDescription() + "\n\t\tincluding " + this.ToString();
        }

    }
}
