using AbstractFactory.Abstract;

// -----------------------------------------------------------------------
// <copyright file="$safeitemrootname$.cs" company="$registeredorganization$">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------
namespace AbstractFactory.Concrete
{
    public class DryFruitLightChocolate : LightChocolate
    {
        public DryFruitLightChocolate()
        {
            System.Diagnostics.Trace.WriteLine(this.GetType().Name + " created");
        }
    }
}
