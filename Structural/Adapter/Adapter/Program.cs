using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //same obj is capabe of calling both the orders

            FoodOrder fo = new FastFoodOrder();
            fo.Order("1");

            fo=new FrenchFoodOrder();
            fo.Order("2");
        }
    }
}
