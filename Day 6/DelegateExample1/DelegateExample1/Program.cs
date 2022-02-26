using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample1
{
    internal class Program
    {
        public delegate void MyFirstDelegate(string s);
        public static void SayHello(string s)
        {
            Console.WriteLine("Welcome to Delegates Programming from " + s);
        }
        static void Main(string[] args)
        {
            MyFirstDelegate obj = new MyFirstDelegate(SayHello);
            obj("Manali");
        }
    }
}
