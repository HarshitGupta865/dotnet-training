using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            Console.WriteLine("Enter two number");
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine(c);
            }
            catch (FormatException e)
            {
                Console.WriteLine("String is invalid");  
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Too big number entered");
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
        }
    }
}
