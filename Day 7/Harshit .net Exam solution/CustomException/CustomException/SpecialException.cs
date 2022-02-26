using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    class SpecialException : ApplicationException
    {
        public SpecialException(string error) : base(error) { }
    }
}
