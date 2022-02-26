using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employ e1 = new Employ();
            Console.WriteLine(e1);

            Employ e2 = new Employ(3, "Tamanna", 99224);
            Console.WriteLine(e2);
        }
    }
}
