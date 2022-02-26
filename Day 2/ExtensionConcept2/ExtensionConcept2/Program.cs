using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionConcept2
{
    static class Ext
    {
        public static void Harshit(this string s)
        {
            Console.WriteLine("I am Harshit");
        }
        public static void Priya(this string s)
        {
            Console.WriteLine("I am Priya");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello";
            s.Harshit();
            s.Priya();
        }
    }
}
