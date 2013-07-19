using System.Drawing;

// -----------------------------------------------------------------------
// <copyright file="$safeitemrootname$.cs" company="$registeredorganization$">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------
namespace FactoryMethod
{
    public class Palette : PaletteFactory
    {
        public override void AddColors()
        {
            AllColors.Add(Color.Wheat);
            AllColors.Add(Color.White);
        }
    }
}
