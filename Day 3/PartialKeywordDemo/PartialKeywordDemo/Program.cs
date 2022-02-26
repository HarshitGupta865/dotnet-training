using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialKeywordDemo
{
    public partial class Employ
    {
        public void Show()
        {
            Console.WriteLine("I am show method from Employ class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employ employ = new Employ();
            employ.a = 3;
            employ.b = 5;

            employ.Show();
            employ.Display();
            Console.WriteLine(employ);
        }
    }
}
