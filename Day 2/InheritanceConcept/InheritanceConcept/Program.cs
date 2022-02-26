using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConcept
{
    class first
    {
        public void show()
        {
            Console.WriteLine("Base function");
        }
        public void display()
        {
            Console.WriteLine("I am a function of base class but can be accessed by my derived class");
        }
    }

    class Second : first
    {
        public new void show()
        {
            base.show();
            Console.WriteLine("Derived function");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Second obj = new Second();  
            obj.show();
            obj.display();
        }
    }
}
