using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySortExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[n];
            Console.WriteLine("Enter the elements");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine();
            }
            Array.Sort(arr);
            Console.WriteLine("\n");
            Console.WriteLine("Array in sorted format:");
            foreach(string i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
