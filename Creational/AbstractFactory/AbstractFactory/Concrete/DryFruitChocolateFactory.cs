using AbstractFactory.Abstract;

// -----------------------------------------------------------------------
// <copyright file="$safeitemrootname$.cs" company="$registeredorganization$">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------
namespace AbstractFactory.Concrete
{
    public class DryFruitChocolateFactory : ChocolateFactory
    {
        public override DarkChocolate CreateDarkChocolate()
        {
            return new DryFruitDarkChocolate();
        }

        public override LightChocolate CreateLightChocolate()
        {
            return new DryFruitLightChocolate();
        }

        public override CaramelChocolate CreateCaramelChocolate()
        {
            return new DryFruitCaramelChocolate();
        }
    }
}
