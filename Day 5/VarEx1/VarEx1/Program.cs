using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = 12;
            var y = 12.5;
            var name = "Girish";

            var c = 120.23f;
            var d = 150.23m;
            var e = 'G';

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(name);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);

            Console.WriteLine(x.GetType());
            Console.WriteLine(y.GetType());
            Console.WriteLine(name.GetType());
            Console.WriteLine(c.GetType());
            Console.WriteLine(d.GetType());
            Console.WriteLine(e.GetType());
        }
    }
}
