﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SimpleCoffee : ICoffee
    {
        public string GetDescription()
        {
            return "Simple coffee";
        }

        public double GetCost()
        {
            return 5.0;
        }
    }

}
