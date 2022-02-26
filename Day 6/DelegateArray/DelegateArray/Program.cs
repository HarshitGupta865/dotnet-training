using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateArray
{
    internal class Program
    {
        public delegate void MyDelegate(int n);
        public static void Fact(int n)
        {
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f = f * i;
            }
            Console.WriteLine("Factorial Value is " + f);
        }
        public static void PosNeg(int x)
        {
            if (x >= 0)
            {
                Console.WriteLine("Positive Number...");
            }
            else
            {
                Console.WriteLine("Negative Number...");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N value  ");
            int n = Convert.ToInt32(Console.ReadLine());
            MyDelegate[] obj =
            {
                new MyDelegate(PosNeg),
                new MyDelegate(Fact)
            };

            foreach (MyDelegate m in obj)
            {
                m(n);
            }
        }
    }
}
