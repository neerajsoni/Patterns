﻿using System;
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
    public class VisaCard : IValidationStrategy
    {
        public bool IsValid(string number)
        {
            if (number.Length > 5)
                return true;
            return false;
        }
    }
}
