// -----------------------------------------------------------------------
// <copyright file="ControlComponent.cs" company="Microsoft">
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
    class ControlComponent : IWindowObject
    {
        public ControlComponent()
        {
        }

        public void draw() // draws the object
        {
            Console.WriteLine("ControlComponent::draw()");
        }

        public String getDescription() // returns a description of the object
        {
            return "ControlComponent::getDescription()";
        }
    }
}
