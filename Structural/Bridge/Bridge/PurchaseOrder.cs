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
    public abstract class PurchaseOrder
    {
        protected int Id;

        protected PurchaseOrder(Supplier s, int pid)
        {
            Supplier = s;
            Id = pid;
        }
    
        public Supplier Supplier
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public abstract void Order();
    }
}
