﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Host host = new Host();
            host.EntertainGuest();

            Console.ReadLine();
        }
    }
}
