using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionConcept
{
    static class Support
    {
        public static int Mult(this Calculation o, int a, int b)
        {
            return a * b;
        }
    }
}
