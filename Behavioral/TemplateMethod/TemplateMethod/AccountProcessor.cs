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
    public abstract class AccountProcessor
    {
        protected int Amount;

        public void Process(string account)
        {
            Console.WriteLine(GetType() + " " + Amount);
        }

        public abstract void SetAmount(double amount);
    }
}
