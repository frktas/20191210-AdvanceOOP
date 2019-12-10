using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_GenericInterface
{
    class IntAdd : IAdd<int>
    {
        public int Add(int param1, int param2)
        {
            return param1 + param2;
        }

    }
}
