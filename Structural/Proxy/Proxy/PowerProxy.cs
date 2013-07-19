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
    public class PowerProxy : IPower
    {
        private readonly PowerSource _powerSource;

        public PowerProxy()
        {
            _powerSource = new PowerSource();
        }
    
        public int GetVoltage(int areaCode)
        {
            int voltage = _powerSource.GetVoltage(areaCode);
            if (voltage < 220)
            {
                return 220;
            }
            else
            {
                return voltage;
            }
        }
    }
}
