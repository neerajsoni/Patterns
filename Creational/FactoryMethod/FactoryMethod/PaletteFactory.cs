using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

// -----------------------------------------------------------------------
// <copyright file="$safeitemrootname$.cs" company="$registeredorganization$">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------
namespace FactoryMethod
{
    public class PaletteFactory
    {
        protected List<Color> AllColors = new List<Color>();
    
        public virtual void AddColors()
        {
            AllColors.Add(Color.AliceBlue);
            AllColors.Add(Color.AntiqueWhite);
        }

        public void Show()
        {
            Trace.WriteLine("for " + GetType());

            foreach (var color in AllColors)
            {
                Trace.WriteLine(color);
            }
        }
    }
}
