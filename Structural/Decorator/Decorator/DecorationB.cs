// -----------------------------------------------------------------------
// <copyright file="DecorationB.cs" company="Microsoft">
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
    class DecorationB : Decorator
    {
        public DecorationB(IWindowObject decoratedWindow)
            : base(decoratedWindow)
        {
        }

        public override void draw()
        {
            base.draw();
            DecorationBStuff();
        }

        private void DecorationBStuff()
        {
            Console.WriteLine("\t\tdoing DecorationB things on " + _decoratedWindow.GetType());
        }

        public override String getDescription()
        {
            return base.getDescription() + "\n\t\tincluding " + this.ToString();
        }

    }
}
