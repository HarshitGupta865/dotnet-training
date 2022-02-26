using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionConcept3
{
    static class Support
    {
        public static void posNeg(this Operation ob, int n)
        {
            if(n>0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }
        }
    }
}
