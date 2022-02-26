using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    internal class Program
    {

        public void show(int n)
        {
            int[] a = new int[n];
            Console.WriteLine("Enter {0} elements", n);
            for(int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elements entered in the array are");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int kr = Convert.ToInt32(Console.ReadLine());
            Program obj = new Program();
            obj.show(kr);
        }
    }
}
