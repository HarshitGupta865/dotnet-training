using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeZone
{
    internal class Program
    {
        public void add(int h1, int m1, int h2, int m2)
        {
            int sh, sm, d;
            sm = m1 + m2;
            if (sm > 59)
            {
                d = sm / 60;
                sh = h1 + h2 + d;
                sm = sm - 60 * d;
            }
            else
            {
                sh = h1 + h2;
            }
            Console.WriteLine("Sum = {0}hours {1}min", sh, sm);
        }
        static void Main(string[] args)
        {
            // First time zone
            Console.WriteLine("Enter the 1st time");
            Console.WriteLine("Enter the hours part");
            int h1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the minutes part");
            int m1 = Convert.ToInt32(Console.ReadLine());

            // Second time zone
            Console.WriteLine("Enter the 2nd time");
            Console.WriteLine("Enter the hours part");
            int h2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the minutes part");
            int m2 = Convert.ToInt32(Console.ReadLine());

            Program obj = new Program();
            obj.add(h1, m1, h2, m2);

        }
    }
}
