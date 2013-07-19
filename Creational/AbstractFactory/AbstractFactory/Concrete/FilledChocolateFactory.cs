using AbstractFactory.Abstract;

// -----------------------------------------------------------------------
// <copyright file="$safeitemrootname$.cs" company="$registeredorganization$">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------
namespace AbstractFactory.Concrete
{
    public class FilledChocolateFactory : ChocolateFactory
    {
        public override DarkChocolate CreateDarkChocolate()
        {
            return new FilledDarkChocolate();
        }

        public override LightChocolate CreateLightChocolate()
        {
            return new FilledLightChocolate();
        }

        public override CaramelChocolate CreateCaramelChocolate()
        {
            return new FilledCaramelChocolate();
        }
    }
}
