using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample2
{
    internal class Program
    {
        public delegate void DelegateFunction(int n);
        public static void PosNeg (int n)
        {
            if(n>0)
            {
                Console.WriteLine("Number is positive");
            }
            else
            {
                Console.WriteLine("Number is negative");
            }
        }
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            DelegateFunction obj = new DelegateFunction(PosNeg);
            obj(x);
        }
    }
}
