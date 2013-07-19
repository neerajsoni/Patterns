using AbstractFactory.Abstract;

// -----------------------------------------------------------------------
// <copyright file="$safeitemrootname$.cs" company="$registeredorganization$">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------
namespace AbstractFactory.Concrete
{
    public class FilledLightChocolate : LightChocolate
    {
        public FilledLightChocolate()
        {
            System.Diagnostics.Trace.WriteLine(this.GetType().Name + " created");
        }
    }
}
