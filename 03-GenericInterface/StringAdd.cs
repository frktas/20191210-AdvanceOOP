﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_GenericInterface
{
    class StringAdd : IAdd<string>
    {
        public string Add(string param1, string param2)
        {
            return param1 + " " + param2;
        }
    }
}
