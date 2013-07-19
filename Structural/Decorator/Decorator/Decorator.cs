// -----------------------------------------------------------------------
// <copyright file="Decorator.cs" company="Microsoft">
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
    abstract class Decorator : IWindowObject
    {
        protected IWindowObject _decoratedWindow = null; // the object being decorated

        public Decorator(IWindowObject decoratedWindow)
        {
            _decoratedWindow = decoratedWindow;
        }

        public virtual void draw()
        {
            _decoratedWindow.draw();
            Console.WriteLine("\tDecorator::draw() ");
        }

        public virtual String getDescription() // returns a description of the object
        {
            return _decoratedWindow.getDescription() + "\n\t" + "Decorator::getDescription() ";
        }
    }
}
