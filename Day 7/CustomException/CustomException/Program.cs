using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    internal class Program
    {
        public void Check(string s)
        {
            int k = 1;
            foreach(char i in s)
            {
                if(i == ',' || i == '#' || i == '$' || i == '%' || i == '@')
                {
                    throw new SpecialException("String contains special character");
                    k = 0;
                    break;
                }
            }
            if(k == 1)
            {
                Console.WriteLine("String doesnot contain any special character");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            Program obj = new Program();
            try
            {
                obj.Check(str);
            }
            catch (SpecialException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}
