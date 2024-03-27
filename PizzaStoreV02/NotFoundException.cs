using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreV02
{
    internal class NoPizzaFoundException : Exception
    {
        public NoPizzaFoundException()
        { }

        public NoPizzaFoundException(string message) : base(message)
        { }

    }
}
