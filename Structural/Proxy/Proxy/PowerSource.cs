using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// -----------------------------------------------------------------------
// <copyright file="$safeitemrootname$.cs" company="$registeredorganization$">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------
namespace Proxy
{
    public class PowerSource : IPower
    {
        public int GetVoltage(int areaCode)
        {
            switch (areaCode)
            {
                case 101:
                    return 230;
                    break;
                case 102:
                    return 250;
                    break;
                default:
                    return 0;
                    break;
            }
        }
    }
}
