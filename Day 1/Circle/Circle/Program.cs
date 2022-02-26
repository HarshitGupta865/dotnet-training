using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    internal class Program
    {
        public double result(int r)
        {
            double a = 3.14 * r * r;
            return a;
        }
        static void Main(string[] args)
        {
            int r;
            double res;
            Console.WriteLine("Enter the radius");
            r = Convert.ToInt32(Console.ReadLine());
            Program program = new Program();
            res = program.result(r);
            Console.WriteLine("Area of circle = " + res);
        }
    }
}
