using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsDemo
{
    internal class Program
    {
        static Program()
        {
            Console.WriteLine("Static Constructor");
        }
        public Program()
        {
            Console.WriteLine("Instance Constructor");
        }

        public Program(int n)
        {
            Console.WriteLine("Parameretized constructor 1");
        }

        public Program(double n)
        {
            Console.WriteLine("Parameretized constructor 2");
        }

        public Program(int n, double n1)
        {
            Console.WriteLine("Parameretized constructor 3");
        }

        public Program(double n, int n1)
        {
            Console.WriteLine("Parameretized constructor 4");
        }

        static void Main(string[] args)
        {
            Program ob = new Program();
            Program obj = new Program(5);
            Program obje = new Program(5.5);
            Program objec = new Program(5, 5.5);
            Program o = new Program(5.5, 5);

        }
    }
}
