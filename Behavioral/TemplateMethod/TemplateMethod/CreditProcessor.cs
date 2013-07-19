using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// -----------------------------------------------------------------------
// <copyright file="$safeitemrootname$.cs" company="$registeredorganization$">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------
namespace TemplateMethod
{
    public class CreditProcessor : AccountProcessor
    {
        public override void SetAmount(double amt)
        {
            Amount = Convert.ToInt32(-1*Math.Round(amt, 2) * 100);
        }
    }
}
