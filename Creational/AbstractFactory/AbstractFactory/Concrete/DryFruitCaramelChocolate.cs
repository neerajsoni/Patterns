using System.Diagnostics;
using AbstractFactory.Abstract;

// -----------------------------------------------------------------------
// <copyright file="$safeitemrootname$.cs" company="$registeredorganization$">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------
namespace AbstractFactory.Concrete
{
    public class DryFruitCaramelChocolate : CaramelChocolate
    {
        public DryFruitCaramelChocolate()
        {
            System.Diagnostics.Trace.WriteLine(this.GetType().Name + " created");
        }
    }
}
