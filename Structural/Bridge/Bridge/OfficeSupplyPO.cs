﻿using System;
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
    public class OfficeSupplyPO : PurchaseOrder
    {
        public OfficeSupplyPO(Supplier s, int pid) : base(s, pid)
        {
        }

        public override void Order()
        {
            throw new NotImplementedException();
        }
    }
}
