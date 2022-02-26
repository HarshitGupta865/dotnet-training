using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialKeywordDemo
{
    public partial class Employ
    {
        public int a, b;
        public void Display()
        {
            Console.WriteLine("I am display method from Employ class");
        }

        public override string ToString()
        {
            return "Value of a = " + a + "Value of b = " + b;
        }
    }
}
