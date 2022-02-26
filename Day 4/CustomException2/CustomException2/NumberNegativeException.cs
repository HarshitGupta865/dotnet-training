using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException2
{
    public class NumberNegativeException : ApplicationException
    {
        public NumberNegativeException(string error) : base(error) { }
    }
}
