using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// -----------------------------------------------------------------------
// <copyright file="$safeitemrootname$.cs" company="$registeredorganization$">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------
namespace Strategy
{
    public class MasterCard : IValidationStrategy
    {
        public bool IsValid(string number)
        {
            if (number.StartsWith("5")) 
                return true;
            return false;
        }
    }
}
