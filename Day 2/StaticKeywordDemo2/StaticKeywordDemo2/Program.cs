using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeywordDemo2
{
    public static class Program
    {

        // If a class is declared as static then every function of the class has to be static
        // and these function has to be accessed by class name and not object name.
        public static void show()
        {
            Console.WriteLine("Show function");
        }
        public static void display()
        {
            Console.WriteLine("Display Function");
        }
        static void Main(string[] args)
        {
            Program.show();
            Program.display();
        }
    }
}
