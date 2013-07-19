// -----------------------------------------------------------------------
// <copyright file="$safeitemrootname$.cs" company="$registeredorganization$">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------
namespace AbstractFactory.Abstract
{
    public abstract class ChocolateFactory
    {
        public abstract DarkChocolate CreateDarkChocolate();

        public abstract LightChocolate CreateLightChocolate();

        public abstract CaramelChocolate CreateCaramelChocolate();
    }
}
