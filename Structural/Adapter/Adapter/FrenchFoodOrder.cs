using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// -----------------------------------------------------------------------
// <copyright file="$safeitemrootname$.cs" company="$registeredorganization$">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------
namespace Adapter
{
    /// <summary>
    /// Adapter class
    /// </summary>
    public class FrenchFoodOrder : FrenchRestaurant, FoodOrder
    {
        public void Order(object request)
        {
            throw new NotImplementedException();
        }
    }
}
