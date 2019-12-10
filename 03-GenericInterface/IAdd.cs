using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_GenericInterface
{
    interface IAdd<T>
    {
        T Add(T param1, T param2);
    }
}
