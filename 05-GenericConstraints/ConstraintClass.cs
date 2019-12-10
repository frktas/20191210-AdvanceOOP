using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_GenericConstraints
{
    class ConstraintClass<T>
        //where T : class //Reference Types
        /*where T : struct*/ //Value Type
        //where T : new() //ctor constraint 
        //where T : IComparable //Interface constraint

    {

    }

    interface ILoveInterface
    {

    }

    class Hebele
    {
        public Hebele(string metin)
        {

        }
    }
}
