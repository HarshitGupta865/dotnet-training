using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException2
{
    internal class Program
    {

        public void check(int a, int b)
        {
            if(a==0 || b==0)
            {
                throw new NumberZeroException("Numbers cannot be equal to zero");
            }
            else if(a<0 || b<0)
            {
                throw new NumberNegativeException("Numbers cannot be negative");
            }
            else
            {
                int c = a + b;
                Console.WriteLine("Sum of {0} and {1} = {2}", a, b, c);
            }
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Program obj = new Program();
            try
            {
                obj.check(a, b);
            }
            catch (NumberZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NumberNegativeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);   
            }
        }
    }
}
