using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// -----------------------------------------------------------------------
// <copyright file="$safeitemrootname$.cs" company="$registeredorganization$">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------
namespace Facade
{
    public class Kitchen
    {
        public void CookFood()
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }
    }
}
