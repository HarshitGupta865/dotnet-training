using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo2
{
    internal class Program
    {
        public void show(int n)
        {
            string []a = new string[n];
            Console.WriteLine("Enter {0} names", n);
            for(int i = 0;i<n; i++)
            {
                a[i] = Console.ReadLine();
            }
            Console.WriteLine("Entered names are");
            foreach (string i in a)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Array in sorted format");
            Array.Sort(a);
            foreach (string i in a)
            {
                Console.WriteLine(i);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            Program obj = new Program();
            obj.show(n);
        }
    }
}
