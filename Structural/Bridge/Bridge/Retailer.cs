using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// -----------------------------------------------------------------------
// <copyright file="$safeitemrootname$.cs" company="$registeredorganization$">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------
namespace Bridge
{
    public class Retailer : Supplier
    {
        public override void Submit()
        {
            throw new NotImplementedException();
        }

        public void VisitStore()
        {
            throw new System.NotImplementedException();
        }
    }
}
