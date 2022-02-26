using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenSeries
{
    internal class Program
    {
        public void show(int n)
        {
            int i = 0;
            while(i<n)
            {
                Console.WriteLine(i);
                i = i + 2;
            }
        }
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            Program obj = new Program();
            obj.show(n);
        }
    }
}
