// -----------------------------------------------------------------------
// <copyright file="DecorationC.cs" company="Microsoft">
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
    class DecorationC : Decorator
    {
        public DecorationC(IWindowObject decoratedWindow)
            : base(decoratedWindow)
        {
        }

        public override void draw()
        {
            base.draw();
            DecorationCStuff();
        }

        private void DecorationCStuff()
        {
            Console.WriteLine("\t\tdoing DecorationC things on " + _decoratedWindow.GetType());
        }

        public override String getDescription()
        {
            return base.getDescription() + "\n\t\tincluding " + this.ToString();
        }

    }
}
