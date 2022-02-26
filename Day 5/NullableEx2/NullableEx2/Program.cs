using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ?? returns the value of its left-hand operand
            // if it isn't null; otherwise, it evaluates the right-hand operand and returns its result.

            int? x = null;
            int? y = 5622;
            int z = x ?? 5;
            Console.WriteLine(z);
            z = y ?? 7;
            Console.WriteLine(z);

        }
    }
}
