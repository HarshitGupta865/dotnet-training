using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    internal class Program
    {
        interface One
        {
            void Name();
        }
        interface Two
        {
            void Email();
        }

        class Demo: One, Two
        {
            public void Name()
            {
                Console.WriteLine("I am name function");
            }
            public void Email()
            {
                Console.WriteLine("I am Email function");
            }
        }
        static void Main(string[] args)
        {
            Demo demo = new Demo();
            demo.Name();
            demo.Email();
        }
    }
}
