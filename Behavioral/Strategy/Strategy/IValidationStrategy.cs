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
    /// <summary>
    /// </summary>
    public interface IValidationStrategy
    {
        bool IsValid(string number);
    }
}
